use Laboratory
go

/* Show list of scientists */
create or alter proc sp_ListOfScientist
as
begin
	select a.ID, a.Name, b.Name as 'Position', c.Name as 'Department', a.DoB, a.CreditCard, a.Address, a.Nationality, a.Email, a.Phone, a.Gender, a.Salary, a.ProfilePic
	from Scientist a, Position b, Department c
	where a.DepID = c.ID and a.PosID = b.ID
end
go

/* Search for scientist */
create or alter proc sp_SearchScientist(@sctid varchar(10))
as
begin
	select a.ID, a.Name, b.Name as 'Position', c.Name as 'Department', a.DoB, a.CreditCard, a.Address, a.Nationality, a.Email, a.Phone, a.Gender, a.Salary, a.ProfilePic
	from Scientist a, Position b, Department c
	where a.DepID = c.ID and a.PosID = b.ID and @sctid = a.ID
end
go
