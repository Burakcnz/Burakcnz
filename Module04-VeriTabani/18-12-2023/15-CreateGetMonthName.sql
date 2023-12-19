Create Function fnGetMonthName
	(@Date Date)
	Returns varchar(10)
Begin
	Declare @MonthNumber int
	Set @MonthNumber= Month(@Date)
	Return 
		(Case @MonthNumber
			 When 1 Then 'Ocak'
			 When 2 Then 'Þubat'
			 When 3 Then 'Mart'
			 When 4 Then 'Nisan'
			 When 5 Then 'Mayýs'
			 When 6 Then 'Haziran'
			 When 7 Then 'Temmuz'
			 When 8 Then 'Aðustos'
			 When 9 Then 'Eylül'
			 When 10 Then 'Ekim'
			 When 11 Then 'Kasým'
			 When 12 Then 'Aralýk'
			 Else 'HATA!'
		End)
End