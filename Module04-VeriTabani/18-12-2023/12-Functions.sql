/*
	-Geriye de�er d�nd�rme �zelli�i olan yap�lard�r.
	-Sorgular�n i�inde kullan�labilirler.
	-Geriye bir de�er ya da tablo d�nd�rebilirler.
	-Parametre alabilirler
	-Bir fonksiyon tablo �zerinde INSERT, UPDATE, DELETE i�lemleri YAPAMAZ! AMA, INSERT, UPDATE ya da DELETE Sorgular�n�n i�inde kullanabilirler.
*/
--CREATE FUNCTION fnSample(@metin nvarchar(10)) RETURNS nvarchar(10)
--BEGIN
--	RETURN UPPER(@metin)
--END

--USE Northwind
--GO

--SELECT R.RegionId, dbo.fnSample(R.RegionDescription) AS 'B�lge Ad�'
--FROM Region R
USE Northwind
GO

DECLARE @Metin NVARCHAR(10)
SET @Metin='engin'
SELECT dbo.fnSample(@Metin)