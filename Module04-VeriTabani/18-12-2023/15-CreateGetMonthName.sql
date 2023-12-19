Create Function fnGetMonthName
	(@Date Date)
	Returns varchar(10)
Begin
	Declare @MonthNumber int
	Set @MonthNumber= Month(@Date)
	Return 
		(Case @MonthNumber
			 When 1 Then 'Ocak'
			 When 2 Then '�ubat'
			 When 3 Then 'Mart'
			 When 4 Then 'Nisan'
			 When 5 Then 'May�s'
			 When 6 Then 'Haziran'
			 When 7 Then 'Temmuz'
			 When 8 Then 'A�ustos'
			 When 9 Then 'Eyl�l'
			 When 10 Then 'Ekim'
			 When 11 Then 'Kas�m'
			 When 12 Then 'Aral�k'
			 Else 'HATA!'
		End)
End