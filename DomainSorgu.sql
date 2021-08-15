CREATE DATABASE DomainSorgu
GO

use DomainSorgu 
GO

CREATE TABLE Domain (
  Id int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  DomainAdi nvarchar(MAX) NOT NULL,
  Durum nvarchar(50),
)