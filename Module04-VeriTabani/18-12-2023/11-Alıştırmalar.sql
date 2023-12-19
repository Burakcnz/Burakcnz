USE Northwind
GO

--7) En �ok ciro yap�lan ilk 3 �r�n hangileridir?
--SELECT TOP(3) P.ProductName, SUM(OD.UnitPrice*OD.Quantity) AS Total
--FROM Products P JOIN OrderDetails OD
--	ON P.ProductID=OD.ProductID
--GROUP BY P.ProductName
--ORDER BY Total DESC

--8) Hangi kargo �irketine, ne kadarl�k �deme yap�lm��t�r? (Freight)
--SELECT S.CompanyName, SUM(O.Freight) AS Total
--FROM Orders O JOIN Shippers S
--	ON O.ShipVia=S.ShipperID
--GROUP BY S.CompanyName

--9) Bug�ne kadar en az �deme yap�lm�� kargo �irketi ve �deme miktar� nedir?
--SELECT TOP(1) S.CompanyName, SUM(O.Freight) AS Total
--FROM Orders O JOIN Shippers S
--	ON O.ShipVia=S.ShipperID
--GROUP BY S.CompanyName
--ORDER BY Total

--10) Hangi m��teriye ne kadarl�k sat�� yap�lm��t�r? Sat�� tutar�na g�re b�y�kten k����e s�ral� �ekilde g�steriniz.
--SELECT C.CompanyName, SUM(OD.Quantity*OD.UnitPrice) AS Total
--FROM Customers C JOIN Orders O
--	ON C.CustomerID=O.CustomerID JOIN OrderDetails OD
--		ON O.OrderID=OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY Total DESC
--11) B�lgelere g�re sat�� tutarlar�n� g�steriniz.
--SELECT R.RegionDescription, SUM(OD.Quantity * OD.UnitPrice) AS Total
--FROM Region R JOIN Territories T
--	ON R.RegionID=T.RegionID JOIN EmployeeTerritories ET
--		ON T.TerritoryID=ET.TerritoryID JOIN Employees E
--			ON ET.EmployeeID=E.EmployeeID JOIN Orders O
--				ON E.EmployeeID=O.EmployeeID JOIN OrderDetails OD
--					ON O.OrderID=OD.OrderID
--GROUP BY R.RegionDescription
--ORDER BY Total DESC
			
--12) Hangi b�lgede, hangi �r�nden, ne kadarl�k sat�� yap�lm��t�r?
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




