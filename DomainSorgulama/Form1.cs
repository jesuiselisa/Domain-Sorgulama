using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DomainSorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DomainSorguEntities dse = new DomainSorguEntities();

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string domain = txtSorgulananDomain.Text;
            WhoIsGetir(domain);
            Domain dmn = new Domain();
            dmn.DomainAdi = txtSorgulananDomain.Text;
            
            if (lblIlkSorgu.Text.Contains("No match"))
            {
                txtSonuc.Text = "SONUÇ:  ALINABİLİR  ";
                dmn.Durum = "Alınabilir";
            }
            else
            {
                txtSonuc.Text = "SONUÇ:  ALINAMAZ  ";
                dmn.Durum = "Alınamaz";
            }

            dse.Domain.Add(dmn);
            dse.SaveChanges();

        }

        void WhoIsGetir (string domain)
        {
            if(domain.IndexOf(".") < 0)
            {
                txtSonuc.Visible = true;
                return;
            }

            string uzanti = domain.Substring(domain.LastIndexOf("."));
            XElement xdoc = XElement.Load("/App_Data/whois.xml");
            var node = (from x in xdoc.Elements("whois")
                        where x.Element("TLD").Value.Equals(uzanti)
                        select new
                        {
                            Domain = domain,
                            TLD = x.Element("TLD").Value,
                            Server = x.Element("Server").Value
                        }).FirstOrDefault();

            Stopwatch timer = new Stopwatch();

            timer.Start();
            string ilkSorgu = WhoisBilgisiGetir(node.Server, node.Domain);
            timer.Stop();

            if (!string.IsNullOrEmpty(ilkSorgu))
            {
                lblIlkSorguAciklama.Text =
                    string.Format(
                    @"Whois server: <b>{0}</b>,&nbsp;&nbsp;&nbsp;<b>{1}</b> milisaniye,&nbsp;&nbsp;&nbsp;<b>{2}</b> byte",
                    node.Server, timer.ElapsedMilliseconds.ToString(), ilkSorgu.Length);

                lblIlkSorgu.Text = string.Format(@"<pre>{0}</pre>", ilkSorgu);

                string ikinciSorgu = "";
                string ikinciServer = "";
                if (ilkSorgu.IndexOf("Whois Server") > -1)
                {
                    string[] satirlar = ilkSorgu.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    string aranan = "Whois Server: ";
                    foreach (string item in satirlar)
                    {
                        if (item.Trim().StartsWith(aranan))
                        {
                            ikinciServer = item.Substring(item.IndexOf(aranan) + aranan.Length);
                            break;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(ikinciServer))
                {
                    timer.Reset();
                    timer.Start();
                    ikinciSorgu = WhoisBilgisiGetir(ikinciServer, domain);
                    timer.Stop();

                    lblIkinciSorguAciklama.Text =
                            string.Format(
                            @"Whois server: <b>{0}</b>,&nbsp;&nbsp;&nbsp;<b>{1}</b> milisaniye,&nbsp;&nbsp;&nbsp;<b>{2}</b> byte",
                            ikinciServer, timer.ElapsedMilliseconds.ToString(), ikinciSorgu.Length);

                    lblIkinciSorgu.Text = string.Format(@"<pre>{0}</pre>", ikinciSorgu); ;
                }
            }

        }

        private string WhoisBilgisiGetir(string server, string domain)
        {
            StringBuilder sb = new StringBuilder();
            TcpClient tc = new TcpClient(server, 43);
            NetworkStream ns = tc.GetStream();
            BufferedStream bs = new BufferedStream(ns);
            StreamWriter sw = new StreamWriter(bs);

            sw.WriteLine(domain);
            sw.Flush();

            StreamReader sr = new StreamReader(bs, Encoding.UTF8);

            while (!sr.EndOfStream)
                sb.AppendLine(sr.ReadLine());

            return sb.ToString();
        }
    }
}
