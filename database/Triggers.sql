use Laboratory
go

/* Check name, email and phone number when adding or updating a scientist information */
create or alter trigger tg_CheckInsertedandUpdatedScientistInfo
on Scientist for insert, update
as
begin
	if ((select count(Name) from Scientist where Name=(select Name from inserted))>1) 
	begin
		raiserror('The name adready existed!', 16, 1)
		rollback
	end
	if ((select count(Email) from Scientist where Email= (select Email from inserted))>1) 
	begin
		raiserror('The e-mail adready existed!', 16, 1)
		rollback
	end
	if ((select count(Phone) from Scientist where Phone=(select Phone from inserted))>1) 
	begin
		raiserror('The phone number adready existed!', 16, 1)
		rollback
	end
	if ((select Email from inserted) not like '%@gmail.com') 
	begin
		raiserror('Wrong e-mail format!', 16, 1)
		rollback
	end
	if ((select Phone from inserted) not like '+84_________') 
	begin
		raiserror('Wrong phone number format!', 16, 1)
		rollback
	end
end
go

/* Check password when updating */
create or alter trigger tg_CheckUpdatedPass
on LoginInfo for update
as
begin
	declare @pass varchar(20)=(select Password from inserted)
	if(len(@pass) < 8 and len(@pass) > 16) 
	begin
		raiserror('The password must be at least 8 characters and less than 16 characters!', 16, 1)
	end
end
go