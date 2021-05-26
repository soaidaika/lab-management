use Laboratory
go

/* Show list of apparatuses */
create or alter proc sp_ListOfApparatus
as
begin
	select*
	from Equipment
end
go

/* Search for apparatus */
create or alter proc sp_SearchApparatus(@aprtname varchar(10))
as
begin
	select*
	from Equipment
	where @aprtname = Name
end
go
