use EVMotors;



-- Import CSV file

	-- 2.1 Load the CSV File 

	bulk insert VehicleRegister
	from 'C:\Users\rogan\Desktop\Cenit College Courses\Software_Development_24\PROJECT\Copy of EVMotorsTableDataGenerator - Data.csv'
	with (
		fieldterminator = ',',  -- Comma-separated values
		rowterminator = '\n',   -- Newline-separated rows
		firstrow = 2           -- Skip the header row (if present)
	);

	
select * from VehicleRegister;
