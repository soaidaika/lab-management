use Laboratory
go

/* Show scientists of a department */
create or alter proc sp_ShowScientistInDep(@dep varchar(10))
as
begin
	select a.Name, c.Name as 'Position', a.Phone, a.Email
	from Scientist a, Department b, Position c
	where @dep = b.ID and a.DepID = b.ID and a.PosID = c.ID
end
go

/* Number of members in a department */
create or alter proc sp_NumOfMemInDep(@dep varchar(10))
as
begin
	select count(a.ID) as 'Members'
	from Scientist a, Department b
	where @dep = b.ID and a.DepID = b.ID
end
go
