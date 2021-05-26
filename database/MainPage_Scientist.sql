use Laboratory
go

/* Show scientific information */
create or alter proc sp_ShowScientificInfo(@id varchar(10))
as
begin
	select a.ID, a.Name, b.Name, c.Name, a.DoB, a.Gender, a.Nationality, a.CreditCard, a.Address, a.Phone, a.Email
	from Scientist a, Position b, Department c
	where a.PosID = b.ID and a.DepID = c.ID and a.ID = @id
end
go

/* Show login information */
create or alter proc sp_ShowLoginInfo(@id varchar(10))
as
begin
	select*
	from LoginInfo
	where @id=ScientistID
end
go

/* Change password */
create or alter proc sp_ChangePassword(@id varchar(10), @oldpass varchar(30), @newpass varchar(30), @confirmpass varchar(30))
as
begin
	update LoginInfo set Password = @confirmpass 
	where ScientistID = @id and Password = @oldpass and @newpass = @confirmpass
end
go

/* Update scientist/manager information */
create or alter proc sp_UpdateYourInfo(@id varchar(10), @card varchar(30), @address varchar(30), @phone varchar(30), @mail varchar(50))
as
begin
	update Scientist set CreditCard = @card, Address = @address, Phone = @phone, Email = @mail 
	where ID = @id
end
go

/*Change profile picture */
create or alter proc sp_ChangeProfilePic(@id varchar(10), @pic varchar(max))
as
begin
	update Scientist set ProfilePic = convert(varbinary(max), @pic, 1)
	where @id = ID
end
go
