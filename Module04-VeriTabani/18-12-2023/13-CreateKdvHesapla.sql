Create Function fnKdvHesapla
	(@Deger money, @Oran money) 
	Returns money
Begin
	Return @Deger*@Oran
End