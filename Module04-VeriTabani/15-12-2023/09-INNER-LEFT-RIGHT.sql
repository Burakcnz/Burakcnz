USE HastaneDb
GO

--INSERT INTO Doktorlar(adSoyad,adres)VALUES
--('Burak Can','Çorum')
--INNER JOIN = JOIN
--SELECT d.adSoyad AS [Doktor Adý],d.adres AS [Adres],b.ad AS [Bölüm Adý] FROM Doktorlar d 
--	INNER JOIN Bolumler b ON d.bolumId=b.id
--SELECT d.adSoyad AS [Doktor Adý],d.adres AS [Adres],b.ad AS [Bölüm Adý] FROM Doktorlar d 
--	LEFT JOIN Bolumler b ON d.bolumId=b.id
--SELECT d.adSoyad AS [Doktor Adý],d.adres AS [Adres],b.ad AS [Bölüm Adý] FROM Doktorlar d 
--	RIGHT JOIN Bolumler b ON d.bolumId=b.id
--SELECT d.adSoyad,d.adres,b.ad FROM Bolumler b LEFT JOIN Doktorlar d ON b.id=d.bolumId
