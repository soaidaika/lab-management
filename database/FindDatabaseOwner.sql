create or alter proc sp_FindDatabaseOwner
as
begin
	create table temp
	(
		_CATALOG_NAME nvarchar(100),
		_DESCRIPTION nvarchar(max),
		_OWNER nvarchar(100)
	)

	declare @servername nvarchar(100), @count int, @maxcount int
	set @count=0
	set @maxcount = (select MAX(server_id) from sys.servers)

	while (@count<=@maxcount)
	begin
		set @servername = (select [name] from sys.servers where server_id=@count)

		insert into temp(_CATALOG_NAME, _DESCRIPTION) exec sp_catalogs @servername

		if exists (select _CATALOG_NAME from temp where _CATALOG_NAME = 'Laboratory')
			update temp set _OWNER = @servername where _CATALOG_NAME = 'Laboratory'
			select _CATALOG_NAME, _OWNER from temp where _CATALOG_NAME = 'Laboratory'
			drop table temp

		set @count=@count+1
	end

	if exists (select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'temp')
		drop table temp
end
go

exec sp_FindDatabaseOwner