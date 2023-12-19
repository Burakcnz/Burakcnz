Use Northwind
Go

Select 
	Od.OrderID,
	Od.Quantity*Od.UnitPrice as Total,
	dbo.fnKdvHesapla(Od.Quantity*Od.UnitPrice,0.18) as Kdv
From OrderDetails Od