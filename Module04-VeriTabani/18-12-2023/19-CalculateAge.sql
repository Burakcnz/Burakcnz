Drop Function If Exists dbo.fnCalculateAge
Go

Create Function fnCalculateAge
	(@DateOfBirthday Date)
	Returns int
Begin
	Declare @Result int
	Declare @Today Date
	Set @Today=GETDATE()
	Set @Result=DATEDIFF(YEAR,@DateOfBirthday,@Today)
	Return @Result
End
Go

Select dbo.fnCalculateAge('1975-07-16')
Go