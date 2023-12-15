USE master
GO

DROP DATABASE IF EXISTS HastaneDb
GO

CREATE DATABASE HastaneDb
GO

--Üst taraf varsa HastanaDb'yi silip yeniden oluþturur.
--Yoksa zaten oluþturur.

USE HastaneDb
GO

--HASTALAR TABLOSU 
CREATE TABLE Hastalar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	adres NVARCHAR(50),
	telefon CHAR(11)
)
GO

INSERT INTO Hastalar (adSoyad, cinsiyet, adres) VALUES
	('Erencan Germirli','E','İstanbul'),
	('Selin Fergenç','K','Ankara'),
	('Sadi Kuloğlu','E','İzmir'),
	('Nebe Kalabalık','K','İstanbul'),
	('Sevda Ağalar','K','İzmir'),
	('Nora Taşkesen','K','Ankara'),
	('Emma Çetoğlu','K','İstanbul'),
	('Kerem Sözcü','E','Ankara'),
	('Suat Tartar','E','İzmir')
GO

--BOLUMLER TABLOSU
CREATE TABLE Bolumler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL
)
GO
INSERT INTO Bolumler VALUES
	('Dahiliye'), ('Nöroloji'), ('Ortopedi'),
	('Diş'),('Periodontoloji'),	('Genel Cerrahi')
GO

--DOKTORLAR TABLOSU
CREATE TABLE Doktorlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50),
	bolumId INT DEFAULT NULL,
	FOREIGN KEY(bolumId) REFERENCES Bolumler(id) ON DELETE SET DEFAULT
)
GO
INSERT INTO Doktorlar VALUES
	('Ali Can', 'İstanbul', 1),
	('Demet Evgar', 'Bursa', 2),
	('Sedat Kanar', 'İstanbul', 3),
	('Ferhunde Haným', 'İzmir', 1),
	('Zafer Kimki', 'Ankara', 2),
	('Hale Elveren', 'İstanbul', 3),
	('Tuna Sefer', 'Ankara', 4),
	('Kevser Tutku', 'İstanbul', 4),
	('Tutkum Kapışmak', 'İzmir', 5),
	('İsa Canova', 'İzmir', 5),
	('Tuğçe Bölümsüz', 'İstanbul', null)
GO