--Sipariþlerin indirimli tutarlarýný listeleyen SP
Create Proc spGetOrdersWithDiscount
As
	Select 
		Od.OrderID,
		Sum((1-Od.Discount) * Od.Quantity * Od.UnitPrice) as Total
	From OrderDetails Od
	Group By Od.OrderId
	Order By Total Desc
Go
Exec spGetOrdersWithDiscount