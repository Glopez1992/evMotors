use EVMotors;

-- 1. Create Table CarMake

create table CarMake (
Make nvarchar(50) not null, --Toyota, Ford, Citroën, Škoda,...
);


-- 2. Load the CSV File 

	bulk insert CarMake
	from 'C:\Users\rogan\Desktop\Cenit College Courses\Software_Development_24\PROJECT\Updates#2\car_make.csv'
	with (
		fieldterminator = ',',  -- Comma-separated values
		rowterminator = '\n',   -- Newline-separated rows
		firstrow = 1           
	);

			-- delete from CarMake;

	select * from CarMake;

			/* 
			select N'Citroën' as TestValue;
			select N'Škoda' as TestValue;
				- to check special characters are correctly displayed 
					- if not, save Notepad++ file as UTF-16 LE BOM


