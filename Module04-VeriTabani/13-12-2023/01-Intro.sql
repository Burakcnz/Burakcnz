--Transaction SQL - T-SQL -MsSQL
--CREATE DATABASE Shopping --Db oluþturur
--DROP DATABASE Shopping2 --Db siler
USE master
GO
DROP DATABASE IF EXISTS Shopping --IF EXISTX = varsa sil demek
GO
CREATE DATABASE Shopping
GO
USE Shopping
GO
CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY (1,1) ,
	Name NVARCHAR(100) NOT NULL,
	Description NVARCHAR(500) NULL,
	CreatedDate DATETIME DEFAULT GETDATE(),
) 
GO 
INSERT INTO Categories( Name,Description )VALUES
	('Telefon','Telefonlar bu kategoride'),
	('Televizyon','Televizyonlar bu kategoride'),
	('Beyaz Eþya','Beyaz Eþyalar bu kategoride'),
	('Bilgisayar','Bilgisayarlar bu kategoride')
GO
CREATE TABLE Products(
Id INT PRIMARY KEY IDENTITY(1,1),
Name NVARCHAR(100) NOT NULL,
Properties NVARCHAR(500),
Price MONEY NOT NULL,
CreatedDate DATETIME DEFAULT GETDATE(),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id)
)

GO
INSERT INTO Products(Name,Price,CategoryId)VALUES
('Xiaomi Note 8 Pro',8500,1),
('Samsung S23',42850,1),
('Vestel 105" TV',10500,2),
('LG 81" Android TV',11250,2),
('Acer Nitro 5',20510,4),
('Macbook Air M2 16 Gb',43250,4),
('Macbook Pro M1 Pro 16 Gb',45000,4),
('Macbook Pro M2 16 Gb',48520,4)