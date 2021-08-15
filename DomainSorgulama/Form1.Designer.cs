
namespace DomainSorgulama
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSorgulananDomain = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSorgula = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlIlkSorgu = new System.Windows.Forms.Panel();
            this.lblIlkSorgu = new System.Windows.Forms.Label();
            this.lblIlkSorguAciklama = new System.Windows.Forms.Label();
            this.pnlIkinciSorgu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSonuc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblIkinciSorgu = new System.Windows.Forms.Label();
            this.lblIkinciSorguAciklama = new System.Windows.Forms.Label();
            this.pnlIlkSorgu.SuspendLayout();
            this.pnlIkinciSorgu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSorgulananDomain
            // 
            this.txtSorgulananDomain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSorgulananDomain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSorgulananDomain.BackgroundImage")));
            this.txtSorgulananDomain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSorgulananDomain.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtSorgulananDomain.Icon = ((System.Drawing.Image)(resources.GetObject("txtSorgulananDomain.Icon")));
            this.txtSorgulananDomain.Location = new System.Drawing.Point(38, 28);
            this.txtSorgulananDomain.Name = "txtSorgulananDomain";
            this.txtSorgulananDomain.Size = new System.Drawing.Size(421, 53);
            this.txtSorgulananDomain.TabIndex = 1;
            this.txtSorgulananDomain.text = "Aramak İstenilen Domain Adını Giriniz";
            // 
            // btnSorgula
            // 
            this.btnSorgula.ActiveBorderThickness = 1;
            this.btnSorgula.ActiveCornerRadius = 20;
            this.btnSorgula.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.btnSorgula.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSorgula.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSorgula.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSorgula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSorgula.BackgroundImage")));
            this.btnSorgula.ButtonText = "DOMAIN SORGULA";
            this.btnSorgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSorgula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorgula.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSorgula.IdleBorderThickness = 1;
            this.btnSorgula.IdleCornerRadius = 20;
            this.btnSorgula.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSorgula.IdleForecolor = System.Drawing.Color.OrangeRed;
            this.btnSorgula.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnSorgula.Location = new System.Drawing.Point(490, 53);
            this.btnSorgula.Margin = new System.Windows.Forms.Padding(5);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(229, 63);
            this.btnSorgula.TabIndex = 5;
            this.btnSorgula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // pnlIlkSorgu
            // 
            this.pnlIlkSorgu.Controls.Add(this.lblIlkSorguAciklama);
            this.pnlIlkSorgu.Controls.Add(this.lblIlkSorgu);
            this.pnlIlkSorgu.Location = new System.Drawing.Point(26, 24);
            this.pnlIlkSorgu.Name = "pnlIlkSorgu";
            this.pnlIlkSorgu.Size = new System.Drawing.Size(681, 130);
            this.pnlIlkSorgu.TabIndex = 6;
            // 
            // lblIlkSorgu
            // 
            this.lblIlkSorgu.AutoSize = true;
            this.lblIlkSorgu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlkSorgu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIlkSorgu.Location = new System.Drawing.Point(28, 28);
            this.lblIlkSorgu.Name = "lblIlkSorgu";
            this.lblIlkSorgu.Size = new System.Drawing.Size(13, 17);
            this.lblIlkSorgu.TabIndex = 0;
            this.lblIlkSorgu.Text = "-";
            // 
            // lblIlkSorguAciklama
            // 
            this.lblIlkSorguAciklama.AutoSize = true;
            this.lblIlkSorguAciklama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlkSorguAciklama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIlkSorguAciklama.Location = new System.Drawing.Point(28, 76);
            this.lblIlkSorguAciklama.Name = "lblIlkSorguAciklama";
            this.lblIlkSorguAciklama.Size = new System.Drawing.Size(13, 17);
            this.lblIlkSorguAciklama.TabIndex = 1;
            this.lblIlkSorguAciklama.Text = "-";
            // 
            // pnlIkinciSorgu
            // 
            this.pnlIkinciSorgu.Controls.Add(this.lblIkinciSorguAciklama);
            this.pnlIkinciSorgu.Controls.Add(this.lblIkinciSorgu);
            this.pnlIkinciSorgu.Controls.Add(this.label1);
            this.pnlIkinciSorgu.Controls.Add(this.label2);
            this.pnlIkinciSorgu.Location = new System.Drawing.Point(26, 160);
            this.pnlIkinciSorgu.Name = "pnlIkinciSorgu";
            this.pnlIkinciSorgu.Size = new System.Drawing.Size(681, 130);
            this.pnlIkinciSorgu.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(28, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Controls.Add(this.pnlIlkSorgu);
            this.groupBox1.Controls.Add(this.pnlIkinciSorgu);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 300);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Açıklamalar";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSonuc.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtSonuc.HintForeColor = System.Drawing.Color.Empty;
            this.txtSonuc.HintText = "";
            this.txtSonuc.isPassword = false;
            this.txtSonuc.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSonuc.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.txtSonuc.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSonuc.LineThickness = 4;
            this.txtSonuc.Location = new System.Drawing.Point(38, 100);
            this.txtSonuc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(421, 45);
            this.txtSonuc.TabIndex = 10;
            this.txtSonuc.Text = "SONUÇ:";
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblIkinciSorgu
            // 
            this.lblIkinciSorgu.AutoSize = true;
            this.lblIkinciSorgu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIkinciSorgu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIkinciSorgu.Location = new System.Drawing.Point(28, 28);
            this.lblIkinciSorgu.Name = "lblIkinciSorgu";
            this.lblIkinciSorgu.Size = new System.Drawing.Size(13, 17);
            this.lblIkinciSorgu.TabIndex = 11;
            this.lblIkinciSorgu.Text = "-";
            // 
            // lblIkinciSorguAciklama
            // 
            this.lblIkinciSorguAciklama.AutoSize = true;
            this.lblIkinciSorguAciklama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIkinciSorguAciklama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIkinciSorguAciklama.Location = new System.Drawing.Point(28, 76);
            this.lblIkinciSorguAciklama.Name = "lblIkinciSorguAciklama";
            this.lblIkinciSorguAciklama.Size = new System.Drawing.Size(13, 17);
            this.lblIkinciSorguAciklama.TabIndex = 12;
            this.lblIkinciSorguAciklama.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(753, 468);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtSorgulananDomain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Domain Sorgulama";
            this.pnlIlkSorgu.ResumeLayout(false);
            this.pnlIlkSorgu.PerformLayout();
            this.pnlIkinciSorgu.ResumeLayout(false);
            this.pnlIkinciSorgu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox txtSorgulananDomain;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSorgula;
        private System.Windows.Forms.Panel pnlIlkSorgu;
        private System.Windows.Forms.Label lblIlkSorguAciklama;
        private System.Windows.Forms.Label lblIlkSorgu;
        private System.Windows.Forms.Panel pnlIkinciSorgu;
        private System.Windows.Forms.Label lblIkinciSorguAciklama;
        private System.Windows.Forms.Label lblIkinciSorgu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSonuc;
    }
}

