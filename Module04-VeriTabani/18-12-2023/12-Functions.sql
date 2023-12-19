/*
	-Geriye deðer döndürme özelliði olan yapýlardýr.
	-Sorgularýn içinde kullanýlabilirler.
	-Geriye bir deðer ya da tablo döndürebilirler.
	-Parametre alabilirler
	-Bir fonksiyon tablo üzerinde INSERT, UPDATE, DELETE iþlemleri YAPAMAZ! AMA, INSERT, UPDATE ya da DELETE Sorgularýnýn içinde kullanabilirler.
*/
--CREATE FUNCTION fnSample(@metin nvarchar(10)) RETURNS nvarchar(10)
--BEGIN
--	RETURN UPPER(@metin)
--END

--USE Northwind
--GO

--SELECT R.RegionId, dbo.fnSample(R.RegionDescription) AS 'Bölge Adý'
--FROM Region R
USE Northwind
GO

DECLARE @Metin NVARCHAR(10)
SET @Metin='engin'
SELECT dbo.fnSample(@Metin)