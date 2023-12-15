USE Northwind
GO

--SELECT * FROM Products WHERE CategoryID=7
--SELECT Products.ProductName,Products.UnitPrice,Categories.CategoryName FROM Products JOIN Categories ON Products.CategoryID=Categories.CategoryID
--SELECT P.ProductName,P.UnitPrice,C.CategoryName FROM Products P JOIN Categories C ON P.CategoryID=C.CategoryID WHERE CategoryName='beverages' AND UnitPrice>=15 ORDER BY UnitPrice DESC
--SELECT P.ProductName,S.CompanyName,S.Country FROM Products P JOIN Suppliers S ON P.SupplierID=S.SupplierID
--germany den temin edilen ürünleri sadece isim ve temin edilen ülkesi olacak þekilde soruguyu yazýn

--SELECT P.ProductName,S.Country FROM Products P JOIN Suppliers S ON P.SupplierID=S.SupplierID WHERE Country='germany'

--germany den tedarik edilen ürünlerin elimizdeki toplam tutarlarýný bulun
--SELECT SUM(P.UnitPrice*P.UnitsInStock) FROM Products P JOIN Suppliers S ON P.SupplierID=S.SupplierID
--germany den tedarik edilen ürünlerin satýþ tutarlarýný bulun
--SELECT *
--FROM Products p
--	JOIN Suppliers s ON p.SupplierID=s.SupplierID 
--		JOIN OrderDetails od ON p.ProductID=od.ProductID 
--			JOIN Categories c ON p.CategoryID=c.CategoryID
--WHERE s.Country='germany' AND c.CategoryName='seafood'
--ernst handel müþterisine ait satýþ toplamýný bulalým
--SELECT SUM(od.UnitPrice*od.Quantity)
--FROM OrderDetails od 
--	JOIN Orders o ON od.OrderID=o.OrderID
--		JOIN Customers c ON o.CustomerID=c.CustomerID
--WHERE c.CompanyName='ernst handel'