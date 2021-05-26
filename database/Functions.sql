use Laboratory
go

/* Convert position name to position ID */
create or alter function fn_ConvertToPosID(@input varchar(30))
returns int
as
begin
	declare @posid int
	if(@input='Chemist') set @posid=1
	else if(@input='Case Navigator') set @posid=2
	else if(@input='Greenhouse Technician') set @posid=3
	else if(@input='Lab Assistant') set @posid=4
	else if(@input='Lab Inspector') set @posid=5
	else if(@input='Laboratory Manager') set @posid=6
	else if(@input='Lab Scientist') set @posid=7
	else if(@input='Lab Technician') set @posid=8
	else if(@input='Process Operator') set @posid=9
	else if(@input='Research Assistant') set @posid=10
	else if(@input='Research Engineer') set @posid=11
	else if(@input='Security') set @posid=12
	return @posid
end
go

/* Convert department name to department ID */
create or alter function fn_ConvertToDepID(@input varchar(30))
returns varchar(10)
as
begin
	declare @depid varchar(10)
	if(@input='Chemistry') set @depid='CMT123'
	else if(@input='Cytology') set @depid='CTL789'
	else if(@input='Hematology') set @depid='HMT567'
	else if(@input='Microbiology') set @depid='MCB345'
	return @depid
end
go

/* Generate scientist ID when adding a new scientist */
create or alter function fn_GenerateScientistID(@pos varchar(30))
returns varchar(10)
as
begin
	declare @memid varchar(10), @i varchar(5)
	if (@pos='Chemist')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=1)+1)
		if (len(@i)<2) set @memid='Ch0'+@i
		else set @memid='Ch'+@i
	end
	if (@pos='Case Navigator')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=2)+1)
		if (len(@i)<2) set @memid='CN0'+@i
		else set @memid='CN'+@i
	end
	if (@pos='Greenhouse Technician')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=3)+1)
		if (len(@i)<2) set @memid='GT0'+@i
		else set @memid='GT'+@i
	end
	if (@pos='Lab Assistant')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=4)+1)
		if (len(@i)<2) set @memid='LA0'+@i
		else set @memid='LA'+@i
	end
	if (@pos='Lab Inspector')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=5)+1)
		if (len(@i)<2) set @memid='LI0'+@i
		else set @memid='LI'+@i
	end
	if (@pos='Laboratory Manager')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=6)+1)
		if (len(@i)<2) set @memid='LM0'+@i
		else set @memid='LM'+@i
	end
	if (@pos='Lab Scientist')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=7)+1)
		if (len(@i)<2) set @memid='LS0'+@i
		else set @memid='LS'+@i
	end
	if (@pos='Lab Technician')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=8)+1)
		if (len(@i)<2) set @memid='LT0'+@i
		else set @memid='LT'+@i
	end
	if (@pos='Process Operator')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=9)+1)
		if (len(@i)<2) set @memid='PO0'+@i
		else set @memid='PO'+@i
	end
	if (@pos='Research Assistant')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=10)+1)
		if (len(@i)<2) set @memid='RA0'+@i
		else set @memid='RA'+@i
	end
	if (@pos='Research Engineer')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=11)+1)
		if (len(@i)<2) set @memid='RE0'+@i
		else set @memid='RE'+@i
	end
	if (@pos='Security')
	begin
		set @i=convert(varchar, (select count(ID) from Scientist where PosID=11)+1)
		if (len(@i)<2) set @memid='Se0'+@i
		else set @memid='Se'+@i
	end
	return @memid
end
go