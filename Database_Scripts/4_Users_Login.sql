use EVMotors;

-- 1. Creating table "users"
create table users (
    username nvarchar(50) not null check (user <> ''),
    password nvarchar(50) not null check (password <> '')
);

select * from users;

-- 2. Import csv file "4_Users_Login.csv"

bulk insert users
	from 'C:\Users\rogan\Desktop\Cenit College Courses\Software_Development_24\PROJECT\4_Users_Login.csv'
	with (
		fieldterminator = ',',  -- Comma-separated values
		rowterminator = '\n',   -- Newline-separated rows
		firstrow = 2           -- Skip the header row (if present)
	);


select * from users;


