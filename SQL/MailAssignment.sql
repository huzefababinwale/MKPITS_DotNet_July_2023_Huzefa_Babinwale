create table departments(DepartmentID int primary key , 
						DepartmentName nvarchar(50) not null)

						insert into departments(DepartmentID, DepartmentName) values
						(1,'Engineering'),
						(2,'Marketing'),
						(3,'Sales');
						select * from departments

create table Employees( EmployeeID int primary key,
						EmployeeName nvarchar(50) not null,
						DepartmentID int, constraint fk_department_Employee foreign key (departmentID)
						references Departments (DepartmentID));

						insert into Employees (EmployeeID, EmployeeName, DepartmentID) values 
						(12,'Huzefa',1),
						(14,'Priyanka',3),
						(16,'Palam tree',2)

						select *from Employees
						SELECT e.EmployeeID, e.EmployeeName, d.DepartmentName
						FROM Employees e, Departments d
						WHERE e.DepartmentID = d.DepartmentID;
				-- Attempt to insert a record violating the foreign key constraint
				-- Uncomment the following lines to see the error
						INSERT INTO Employees (EmployeeID, EmployeeName, DepartmentID)
							VALUES (5, 'Sam Wilson', 4);

						update employees set DepartmentID=1 where EmployeeID=14;

						SELECT e.EmployeeID, e.EmployeeName, d.DepartmentName
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID;



