Use Northwind
Go

Select 
	dbo.fnNameConcat(e.FirstName, e.LastName) as 'Çalýþan',
	dbo.fnCalculateAge(e.BirthDate) as 'Yaþ'
From Employees e