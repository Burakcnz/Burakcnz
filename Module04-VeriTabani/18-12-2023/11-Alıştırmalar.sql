USE Northwind
GO

--7) En çok ciro yapýlan ilk 3 ürün hangileridir?
--SELECT TOP(3) P.ProductName, SUM(OD.UnitPrice*OD.Quantity) AS Total
--FROM Products P JOIN OrderDetails OD
--	ON P.ProductID=OD.ProductID
--GROUP BY P.ProductName
--ORDER BY Total DESC

--8) Hangi kargo þirketine, ne kadarlýk ödeme yapýlmýþtýr? (Freight)
--SELECT S.CompanyName, SUM(O.Freight) AS Total
--FROM Orders O JOIN Shippers S
--	ON O.ShipVia=S.ShipperID
--GROUP BY S.CompanyName

--9) Bugüne kadar en az ödeme yapýlmýþ kargo þirketi ve ödeme miktarý nedir?
--SELECT TOP(1) S.CompanyName, SUM(O.Freight) AS Total
--FROM Orders O JOIN Shippers S
--	ON O.ShipVia=S.ShipperID
--GROUP BY S.CompanyName
--ORDER BY Total

--10) Hangi müþteriye ne kadarlýk satýþ yapýlmýþtýr? Satýþ tutarýna göre büyükten küçüðe sýralý þekilde gösteriniz.
--SELECT C.CompanyName, SUM(OD.Quantity*OD.UnitPrice) AS Total
--FROM Customers C JOIN Orders O
--	ON C.CustomerID=O.CustomerID JOIN OrderDetails OD
--		ON O.OrderID=OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY Total DESC
--11) Bölgelere göre satýþ tutarlarýný gösteriniz.
--SELECT R.RegionDescription, SUM(OD.Quantity * OD.UnitPrice) AS Total
--FROM Region R JOIN Territories T
--	ON R.RegionID=T.RegionID JOIN EmployeeTerritories ET
--		ON T.TerritoryID=ET.TerritoryID JOIN Employees E
--			ON ET.EmployeeID=E.EmployeeID JOIN Orders O
--				ON E.EmployeeID=O.EmployeeID JOIN OrderDetails OD
--					ON O.OrderID=OD.OrderID
--GROUP BY R.RegionDescription
--ORDER BY Total DESC
			
--12) Hangi bölgede, hangi üründen, ne kadarlýk satýþ yapýlmýþtýr?
SELECT R.RegionDescription, P.ProductName, SUM(OD.Quantity * OD.UnitPrice) AS Total
FROM Region R JOIN Territories T
	ON R.RegionID=T.RegionID JOIN EmployeeTerritories ET
		ON T.TerritoryID=ET.TerritoryID JOIN Employees E
			ON ET.EmployeeID=E.EmployeeID JOIN Orders O
				ON E.EmployeeID=O.EmployeeID JOIN OrderDetails OD
					ON O.OrderID=OD.OrderID JOIN Products P
						ON OD.ProductID=P.ProductID
GROUP BY R.RegionDescription, P.ProductName
ORDER BY R.RegionDescription, P.ProductName




