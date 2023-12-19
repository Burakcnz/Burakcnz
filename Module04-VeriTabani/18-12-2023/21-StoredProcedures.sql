/*
	- Stored Procedure'ler server tarafýnda tutulur ve çalýþtýrýlýrlar.
	- SP'ler bir kez derlenir ve sonraki çalýþtýrmalarda performanslý olurlar
	- Pratik ve kullanýþlýdýrlar. Network trafiði fazla yormazlar. 
	- Diðer yöntemlere göre daha GÜVENLÝDÝRLER!
*/
Create Procedure spSample 
As 
	Select * 
	From Products 
	Where CategoryID=1 
	Order By UnitPrice DESC
Go
Execute spSample