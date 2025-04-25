use EVMotors;

-- 1. Create Table
create table VehicleRegister (
	VehicleRegNo varchar(10) primary key, --Unique identifier and cannot be null // nvarchar - uses special characters like ü, ë, Š,...
	Make nvarchar(50) not null, --Toyota, Ford, Citroën, Škoda,...
	EngineSize varchar(10) null, -- should not be NULL, (fixed below)
	DateRegistered date not null check(DateRegistered<getdate()), -- registration date is mandatory
	RentalPerDay decimal(10,2) not null check(RentalPerDay > 0), -- currency format, 2 decimals
	Available bit not null default 1 -- 1 = Available, 0 = Not Available
);
		-- setting Engine size to NOT NULL as I made a mistake while creating a table
			alter table VehicleRegister
			alter column EngineSize varchar(10) NOT NULL;


-- 2. Changing Primry key name

	-- Find the existing primary key name
	select name 
	from sys.key_constraints 
	where type = 'PK' and parent_object_id = object_id('VehicleRegister');

	-- Drop the old primary key constraint:
	alter table VehicleRegister
	drop constraint PK__VehicleR__F38BC73376F7BD5C;

	-- Add it again with a new name:
	alter table VehicleRegister
	add constraint PK_VehicleRegNo primary key (VehicleRegNo);


	-- check for index types
		SELECT name, type_desc
		FROM sys.indexes
		WHERE object_id = OBJECT_ID('VehicleRegister');


select * from [dbo].[VehicleRegister];

-------------------------------------------------------------------------------
-- UPDATE #1
	-- 1.1 "EngineSize" already set to NOT NULL

	--	1.2 Change field "EngineSize" to "EngineSize/Power"
		exec sp_rename 'VehicleRegister.EngineSize', 'EngineSize/Power', 'column';

