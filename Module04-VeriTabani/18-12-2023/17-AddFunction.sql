--Gönderilen iki sayýyý toplayýp, sonucu döndüren bir function hazýrlayýn.
--Function Name: fnAdd
Drop Function If Exists dbo.fnAdd
Go

Create Function fnAdd(@value1 int, @value2 int) Returns int
Begin
	Declare @result int
	Set @result = @value1 + @value2
	Return @result
End
Go

Select dbo.fnAdd(5,8)
Select dbo.fnAdd(15,58)
Select dbo.fnAdd(555,548)