/*
	- Stored Procedure'ler server taraf�nda tutulur ve �al��t�r�l�rlar.
	- SP'ler bir kez derlenir ve sonraki �al��t�rmalarda performansl� olurlar
	- Pratik ve kullan��l�d�rlar. Network trafi�i fazla yormazlar. 
	- Di�er y�ntemlere g�re daha G�VENL�D�RLER!
*/
Create Procedure spSample 
As 
	Select * 
	From Products 
	Where CategoryID=1 
	Order By UnitPrice DESC
Go
Execute spSample