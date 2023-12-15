USE Northwind
GO

--1-bugune kadar hangi �lkelere kargo g�nderimi yap�lm��t�r
--SELECT DISTINCT ShipCountry FROM Orders 

--2-hangi �lkeye ne kadarl�k sat�� yap�lm��t�r
--SELECT o.ShipCountry,SUM(od.UnitPrice*od.Quantity) as total  FROM Orders o JOIN OrderDetails od ON o.OrderID=od.OrderID GROUP BY o.ShipCountry order by total desc

--3-en �ok sat�� yap�lan ilk 3 hangi �lke
--SELECT top(3) o.ShipCountry,SUM(od.UnitPrice*od.Quantity) as total  FROM Orders o JOIN OrderDetails od ON o.OrderID=od.OrderID GROUP BY o.ShipCountry order by total desc

--4-elimizde en �ok sto�u bulunan ilk 5 �r�n hangileridir
--select top(5) P.ProductName,P.UnitsInStock,s.Country from Products P inner join Suppliers s on p.SupplierID=s.SupplierID order by p.UnitsInStock desc

--5-hangi kategoride ka� adet stok var
--select c.CategoryName,SUM(p.UnitsInStock) as total from Categories c join Products p on c.CategoryID=p.CategoryID  group by c.CategoryName having sum(p.UnitsInStock)>=400

--6-hangi �r�nden ka� adet sat�lm��t�r
--select p.ProductName,sum(p.UnitPrice*od.Quantity) as total from Products p join OrderDetails od on p.ProductID=od.ProductID group by p.ProductName

--7-en �ok ciro yap�lan ilk 3 �r�n hangileridir
--select top(3) p.ProductName,sum(p.UnitPrice*od.Quantity) as total from Products p join OrderDetails od on p.ProductID=od.ProductID group by p.ProductName order by total desc

--8-hangi kargo �irketine ne kadarl�k �deme yap�lm��t�r

--9-bug�ne kadar en az �deme yap�lm�� kargo �irketi ve �deme m�ktar�

--10-hangi m��teriye ne kadarl�k sat�� yap�lm��t�r?sat�� tutar�na g�re b�y�kten k����e s�ral� �ekilde g�sterin

--11-b�lgelere g�re sat�� tutarlar�n� g�sterin

--12-hangi b�lgede hangi �r�nden ne kadarl�k sat�� yap�lm��t�r

