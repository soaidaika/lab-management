use Laboratory
go

/* Add scientist */
create or alter proc sp_AddScientist(@fn varchar(max), @pos varchar(30), @dep varchar(20), @dob date, @credit bigint, @address varchar(max), @nationality varchar(50), @mail varchar(50), @phone varchar(15), @gd varchar(10), @pp varchar(max))
as
begin
	declare @id varchar(10) = (select dbo.fn_GenerateScientistID(@pos)), @posid int = (select dbo.fn_ConvertToPosID(@pos)), @depid varchar(10) = (select dbo.fn_ConvertToDepID(@dep))
	insert into Scientist values(@id, @fn, @posid, @depid, @dob, @credit, @address, @nationality, @mail, @phone, @gd, 8527, convert(varbinary(max), @pp, 1))
	insert into LoginInfo values(@id, replace(lower(@fn),' ',''), replace(lower(@fn),' ','') + lower(@id), 'scientist')
end
go

/* Remove scientist */
create or alter proc sp_RemoveScientist(@sctid varchar(10))
as
begin
	delete LoginInfo where ScientistID = @sctid
	delete Scientist where ID = @sctid
end
go

/* Show list of projects */
create or alter proc sp_ListOfProject
as
begin
	select a.ID, a.Description, a.StartDate, a.EndDate, b.Name as 'Leader', a.Participants, c.Description 'Status'
	from Experiment a, Scientist b, Status c
	where a.LeaderID = b.ID and a.StatusID = c.ID
end
go

/* Search for project by ID */
create or alter proc sp_SearchProject(@expid varchar(10))
as
begin
	select a.ID, a.Description, a.StartDate, a.EndDate, b.Name as 'Leader', a.Participants, c.Description as 'Status'
	from Experiment a, Scientist b, Status c
	where a.LeaderID = b.ID and a.StatusID = c.ID and a.ID = @expid
end
go

/* Remove project */
create or alter proc sp_RemoveProject(@id varchar(10))
as
begin
	delete Experiment where ID = @id
end
go

/* Add new apparatus */
create or alter proc sp_AddApparatus(@name varchar(max), @des varchar(max), @q int, @pic varchar(max))
as 
begin
	insert into Equipment(Name, Description, Quantity, Image) values(@name, @des, @q, convert(varbinary(max), @pic, 1))
end
go

/* Remove apparatus */
create or alter proc sp_RemoveApparatus(@id varchar(10))
as
begin
	delete Equipment where ID = @id
end
go

/* Update quantity of an existed apparatus */
create or alter proc sp_UpdateApparatus(@id int, @q int)
as
begin
	update Equipment set Quantity = @q 
	where ID = @id
end
go

/* Show list of taken apparatuses */
create or alter proc sp_ShowApparatusInProject(@id varchar(10))
as
begin
	select a.Name, b.Quantity
	from Equipment a, Supply b, Experiment c
	where a.ID = b.EqmID and b.ExpID = c.ID and @id = b.ExpID
end
go

/* Add participants */
create or alter proc sp_AddParticipant(@name varchar(50))
as
begin
	declare @id varchar(10) = (select ID from Scientist where @name = Name)
	insert into Participation(ScientistID) values(@id)

end
go

/* Take participants information from name */
create or alter proc sp_TakeParticipants(@name varchar(50))
as
begin
	select a.ID, a.Name, b.Name as 'Position', c.Name as 'Department'
	from Scientist a, Position b, Department c
	where a.DepID = c.ID and a.PosID = b.ID and a.Name = @name
end
go

/* Take apparatuses information from name */
create or alter proc sp_TakeApparatus(@name varchar(50), @q int)
as
begin
	select ID, Name, @q as 'Quantity'
	from Equipment
	where @name = Name
	update Equipment set Quantity = Quantity - @q
	where Name = @name
end
go

/* Add project */
create or alter proc sp_AddProject(@id varchar(10), @des varchar(max), @sd date, @ed date, @leader varchar(10), @ptcp int, @sctdata as dbo.UDT_Participation readonly, @eqmdata as dbo.UDT_Suppy readonly)
as
begin
	insert into Experiment values(@id, @des, @sd, @ed, @leader, @ptcp, 1)
	insert into Participation 
	select* from @sctdata
	insert into Supply
	select* from @eqmdata
end
go

