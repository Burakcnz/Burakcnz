/*
	- Stored Procedure'ler server tarafında tutulur ve çalıştırılırlar.
	- SP'ler bir kez derlenir ve sonraki çalıştırmalarda performanslı olurlar
	- Pratik ve kullanışlıdırlar. Network trafiği fazla yormazlar. 
	- Diğer yöntemlere göre daha GÜVENLİDİRLER!
*/
Create Procedure spSample 
As 
	Select * 
	From Products 
	Where CategoryID=1 
	Order By UnitPrice DESC
Go
Execute spSample