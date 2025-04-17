--TC01
Insert into VehicleRegister values('ABC123', 'Toyota', '2.0L', '2024-01-01', 100.00, 1)

--TC02
Insert into VehicleRegister values('XYZ123', 'Nissan', '2.1L', '2025-12-31', 200.00, 0)

--TC03
Insert into VehicleRegister values('XYZ123', 'Nissan', '2.1L', '2025-03-31', 0.00, 0)

--TC04
Insert into VehicleRegister values('XYZ123', 'Škoda', '2.1L', '2025-03-31', 300.00, 1)

--TC05
Update VehicleRegister Set Available=0 where VehicleRegNo='ABC123'

--TC06
Delete from VehicleRegister where VehicleRegNo='ABC123'

--TC07
Insert into VehicleRegister values('XYZ789', 'Tesla', '3.1L', '2025-04-01', 500.00, 1)
Insert into VehicleRegister values('XYZ789', 'Tesla', '3.1L', '2025-04-01', 500.00, 1)

--TC08
Insert into VehicleRegister values('XYZ456', 'Tesla', NULL, '2025-04-01', 500.00, 1)

--TC09
Insert into VehicleRegister(VehicleRegNo,Make,EngineSize,DateRegistered,RentalPerDay) values('DEF456', 'Ford', '1.5L', '2024-02-01', 80.00)

--TC10
Insert into VehicleRegister values('FGH123', 'Nissan', '2.1L', '2025-04-01', 99.999, 1)

--TC11
select * from VehicleRegister where Available=1
