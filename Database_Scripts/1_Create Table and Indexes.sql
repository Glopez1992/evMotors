use EVMotors;

-- 1. Create Table
create table VehicleRegister (
	VehicleRegNo varchar(10) primary key, --Unique identifier and cannot be null // nvarchar - uses special characters like ü, ë, Š,...
	Make nvarchar(50) not null, --Toyota, Ford, Citroën, Škoda,...
	EngineSize varchar(10) null, -- can be null for electric vehicles
	DateRegistered date not null check(DateRegistered<getdate()), -- registration date is mandatory
	RentalPerDay decimal(10,2) not null check(RentalPerDay > 0), -- currency format, 2 decimals
	Available bit not null default 1 -- 1 = Available, 0 = Not Available
);
		-- setting Engine size to NOT NULL
			alter table VehicleRegister
			alter column EngineSize varchar(10) NOT NULL;


-- 2. Create Non-Clustered Indexes on Searchable columns
	create nonclustered index idx_vehicle_make on VehicleRegister (Make);
	create nonclustered index idx_vehicle_date_registered on VehicleRegister (DateRegistered);
	create nonclustered index idx_vehicle_rental_per_day on VehicleRegister (RentalPerDay);
	create nonclustered index idx_vehicle_available on VehicleRegister (Available);

----------------------------------------------------------------------------------
--Database not big enough (only 200 records) to use these: 

-- 3. Composite Indexes
	-- if you regularly filter or sort by multiple columns together, like:
	/* where Make = 'Toyota' and Available = 1 */

	create nonclustered index idx_make_available on VehicleRegister (Make, Available);

-- 4. Filtered Indexes
	/* if you you often query only available vehicles: */
		
		select * from VehicleRegister where Available = 1;

		-- Then this index would be more efficient than indexing all values:

		create nonclustered index idx_available_only on VehicleRegister (Available)
		where Available = 1;
------------------------------------------------------------------------------------



	-- check for index types
		SELECT name, type_desc
		FROM sys.indexes
		WHERE object_id = OBJECT_ID('VehicleRegister');







