Declare @Birthday Date
Set @Birthday = '1975-07-16'
Select dbo.fnGetMonthName(@Birthday)