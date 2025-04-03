# ProjeTakipSistemi
## Teknolojiler ve Araçlar  

<p align="left">
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET">
  <img src="https://img.shields.io/badge/MS%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white" alt="MS SQL Server">
  <img src="https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white" alt="Visual Studio">
</p>


![Ekran görüntüsü 2025-04-03 181640](https://github.com/user-attachments/assets/07911da2-10b0-4bd0-80d7-181a45006223)
![Ekran görüntüsü 2025-04-03 181619](https://github.com/user-attachments/assets/646ce210-bb43-4f50-8a6e-b8891120238f)
![Ekran görüntüsü 2025-04-03 181630](https://github.com/user-attachments/assets/cbd48585-950d-46f0-8ff5-548cd1c2c49e)



# SQL Kurulum Kodları

Bu proje için gerekli olan **MS SQL Server** veritabanını oluşturmak için aşağıdaki SQL komutlarını çalıştırabilirsiniz.

## 📌 Veritabanı Oluşturma
```sql
CREATE DATABASE [ProjeTakipDB]
GO

USE [ProjeTakipDB]
GO

CREATE TABLE [dbo].[PersonelBilgileri](
	[PersonelBilgileriId] INT IDENTITY(1,1) PRIMARY KEY,
	[Eposta] NVARCHAR(25) NOT NULL,
	[Sifre] NVARCHAR(25) NOT NULL,
	[Yetki] NVARCHAR(50) NOT NULL,
	[AdSoyad] NVARCHAR(25) NOT NULL,
	[TCNO] NVARCHAR(15) NOT NULL,
	[Departman] NVARCHAR(25) NOT NULL,
	[Gorev] NVARCHAR(25) NOT NULL,
	[Aciklama] NVARCHAR(25) NOT NULL,
	[PozisyonAciklama] NVARCHAR(25) NOT NULL,
	[TelNo] NVARCHAR(25) NOT NULL,
	[Adres] NVARCHAR(25) NOT NULL,
	[MedeniHal] NVARCHAR(25) NOT NULL,
	[YakinlikBilgisi] NVARCHAR(25) NOT NULL,
	[YakinTC] NVARCHAR(25) NOT NULL,
	[YakinTel] NVARCHAR(25) NOT NULL,
	[DogumTarihi] DATETIME2 NOT NULL,
	[IseGirisTarihi] DATETIME2 NULL
)
GO

CREATE TABLE [dbo].[PersonelProjeleri](
	[PersonelProjeId] INT IDENTITY(1,1) PRIMARY KEY,
	[ProjeBaslik] NVARCHAR(150) NOT NULL,
	[ProjeAciklama] NVARCHAR(MAX) NOT NULL,
	[OlusturmaTarihi] DATETIME2 NOT NULL,
	[OncelikDurumu] NVARCHAR(25) NOT NULL,
	[TamamlanmaOrani] INT NOT NULL,
	[TamamlanmaTarihi] DATETIME2 NULL,
	[TamamlanmaDurumu] BIT NOT NULL
)
GO

CREATE TABLE [dbo].[PersonelBilgileriPersonelProjeleri](
	[PersonelBilgileriId] INT NOT NULL,
	[PersonelProjeId] INT NOT NULL,
	PRIMARY KEY ([PersonelBilgileriId], [PersonelProjeId]),
	FOREIGN KEY ([PersonelBilgileriId]) REFERENCES [dbo].[PersonelBilgileri]([PersonelBilgileriId]) ON DELETE CASCADE,
	FOREIGN KEY ([PersonelProjeId]) REFERENCES [dbo].[PersonelProjeleri]([PersonelProjeId]) ON DELETE CASCADE
)
GO

CREATE TABLE [dbo].[Users](
	[UserID] INT IDENTITY(1,1) PRIMARY KEY,
	[UserNameSurname] NVARCHAR(MAX) NOT NULL,
	[UserEmail] NVARCHAR(MAX) NOT NULL,
	[UserPassword] NVARCHAR(MAX) NOT NULL
)
GO
```
