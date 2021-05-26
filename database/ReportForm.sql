use Laboratory
go

/* Show reports of an experiment */
create or alter proc sp_ShowReportsInExp(@expid varchar(10))
as
begin
	select a.ReportTime, b.Name, a.Author
	from Report a, Scientist b
	where @expid = ExpID and a.Author = b.ID
end
go

/* Show report in details */
create or alter proc sp_ShowReportInDetail(@expid varchar(10), @by varchar(10))
as
begin
	select ReportFile
	from Report
	where @expid = ExpID and @by = Author
end
go

/* Remove report */
create or alter proc sp_RemoveReport(@expid varchar(10), @date datetime2(3), @by varchar(10))
as
begin
	declare @datetime datetime = @date
	delete Report
	where @expid = ExpID and @by = Author and @datetime = ReportTime
end
go

/* Add report */
create or alter proc sp_AddReport(@expid varchar(10), @sctid varchar(10), @file varchar(max))
as
begin
	insert into Report(ExpID, ReportTime, Author) values(@expid, getdate(), @sctid)
	update Report set ReportFile = convert(varbinary(max), @file)
	where @expid = ExpID and @sctid = Author
end
go