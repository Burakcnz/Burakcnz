USE HastaneDb
--Filtreleme 
---------------------------------------------------
--SELECT ad AS BolumAdi FROM Bolumler
--SELECT * FROM Doktorlar WHERE adSoyad='TUNA SEFER'
--SELECT * FROM Doktorlar WHERE adres!='tuna sefer'
--SELECT * FROM Doktorlar WHERE adSoyad!='tuna sefer' AND adSoyad!='kevser tutku'
--SELECT * FROM Doktorlar WHERE id=3 OR id=5
--SELECT * FROM Doktorlar WHERE NOT adSoyad='tuna sefer'
--SELECT * FROM Doktorlar WHERE adres='izmir' AND bolumId=5
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 't%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'tut%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%evgar'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%a'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%s%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '_e%' --ilk harfi ne olursa olsun 2. harfi 'e' olan kiþileri çaðýrýr
--SELECT * FROM  Doktorlar WHERE adSoyad LIKE 't_n%'

--Sýralama
----------------------------------------------------
--SELECT * FROM Doktorlar ORDER BY adSoyad --default alfabetik
--SELECT * FROM Doktorlar ORDER BY adSoyad ASC --alfabetik
--SELECT * FROM Doktorlar ORDER BY adSoyad DESC --ters alfabetik
--SELECT * FROM Doktorlar ORDER BY adres DESC,adSoyad ASC
--SELECT * FROM Doktorlar WHERE adres='istanbul' ORDER BY adSoyad

--Hesaplamalar
----------------------------------------------------
--USE Northwind

--SELECT MIN(UnitPrice) AS [En Küçük Fiyat] FROM Products
--SELECT MAX(UnitPrice) AS [En Küçük Fiyat] FROM Products
--SELECT COUNT(ProductID) FROM Products

--USE HastaneDb
--SELECT COUNT(*) - COUNT(bolumId) AS 'atanmayan doktor sayýsý' FROM Doktorlar 
--SELECT COUNT(*) FROM Doktorlar WHERE bolumId IS NULL
--SELECT COUNT(*) FROM Doktorlar WHERE bolumId IS NOT NULL
--SELECT AVG(UnitPrice) AS 'ortalama fiyat' FROM Products
--SELECT SUM(UnitsInStock) FROM Products
--SELECT ProductName,UnitPrice,UnitsInStock,UnitPrice*UnitsInStock AS 'TOTAL' FROM Products
--SELECT SUM(UnitPrice*UnitsInStock) AS 'TOTAL' FROM Products 

--Stringler
--------------------------------------------------------------
--SELECT ProductName,UPPER(ProductName),LOWER(ProductName) FROM Products
--SELECT ProductName,REPLACE(ProductName,'C','Infotech') AS 'Saçmalýk' FROM Products
--SELECT REPLACE(REPLACE(LOWER(ProductName),' ','-'),'''','') AS PRODUCTURL FROM Products

USE HastaneDb
GO
--UPDATE Doktorlar SET adres='Bursa' WHERE id=3
--UPDATE Doktorlar SET bolumId=3 WHERE bolumId=5

DELETE FROM Doktorlar WHERE bolumId IS NULL


