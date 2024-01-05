use EmployeesWithConnection


create table EmployeeDetail(
Emp_id varchar(20) primary key,
Emp_name varchar(20),
DOJ varchar(20),
Age varchar (20),
City varchar(20),
Mobile varchar(20),
Salary int);
drop table EmployeeDetail
insert into EmployeeDetail values('e01','Manish','22-2-2022','33','Mumbai','98654123',25000)
select * from EmployeeDetail



