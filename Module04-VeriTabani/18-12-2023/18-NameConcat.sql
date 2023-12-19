Drop Function If Exists fnNameConcat
Go

Create Function fnNameConcat
	(@FirstName nvarchar(50), @LastName nvarchar(50))
	Returns nvarchar(101)
Begin
	Declare @ResultText nvarchar(101)
	Set @ResultText = @FirstName + ' ' + @LastName
	Return @ResultText
End
Go

Use Northwind
Go

Select dbo.fnNameConcat(e.FirstName, e.LastName) as 'Ad Soyad'
From Employees e