--Gönderilen kategoriye göre ürünleri listeleyen sp
Drop Proc If Exists spGetProductsByCategoryName
Go

Create Proc spGetProductsByCategoryName
	@CategoryName nvarchar(15)
As
	Select 
		c.CategoryName, p.ProductName, p.UnitPrice
	From Categories c Join Products p
		On c.CategoryID=p.CategoryID
	Where c.CategoryName=@CategoryName
	Order By p.UnitPrice Desc
Go

Exec spGetProductsByCategoryName @CategoryName='Produce'