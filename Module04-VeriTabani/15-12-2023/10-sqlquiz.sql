USE Northwind
GO

--1-bugune kadar hangi ülkelere kargo gönderimi yapýlmýþtýr
--SELECT DISTINCT ShipCountry FROM Orders 

--2-hangi ülkeye ne kadarlýk satýþ yapýlmýþtýr
--SELECT o.ShipCountry,SUM(od.UnitPrice*od.Quantity) as total  FROM Orders o JOIN OrderDetails od ON o.OrderID=od.OrderID GROUP BY o.ShipCountry order by total desc

--3-en çok satýþ yapýlan ilk 3 hangi ülke
--SELECT top(3) o.ShipCountry,SUM(od.UnitPrice*od.Quantity) as total  FROM Orders o JOIN OrderDetails od ON o.OrderID=od.OrderID GROUP BY o.ShipCountry order by total desc

--4-elimizde en çok stoðu bulunan ilk 5 ürün hangileridir
--select top(5) P.ProductName,P.UnitsInStock,s.Country from Products P inner join Suppliers s on p.SupplierID=s.SupplierID order by p.UnitsInStock desc

--5-hangi kategoride kaç adet stok var
--select c.CategoryName,SUM(p.UnitsInStock) as total from Categories c join Products p on c.CategoryID=p.CategoryID  group by c.CategoryName having sum(p.UnitsInStock)>=400

--6-hangi üründen kaç adet satýlmýþtýr
--select p.ProductName,sum(p.UnitPrice*od.Quantity) as total from Products p join OrderDetails od on p.ProductID=od.ProductID group by p.ProductName

--7-en çok ciro yapýlan ilk 3 ürün hangileridir
--select top(3) p.ProductName,sum(p.UnitPrice*od.Quantity) as total from Products p join OrderDetails od on p.ProductID=od.ProductID group by p.ProductName order by total desc

--8-hangi kargo þirketine ne kadarlýk ödeme yapýlmýþtýr

--9-bugüne kadar en az ödeme yapýlmýþ kargo þirketi ve ödeme mýktarý

--10-hangi müþteriye ne kadarlýk satýþ yapýlmýþtýr?satýþ tutarýna göre büyükten küçüðe sýralý þekilde gösterin

--11-bölgelere göre satýþ tutarlarýný gösterin

--12-hangi bölgede hangi üründen ne kadarlýk satýþ yapýlmýþtýr

