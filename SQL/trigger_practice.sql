	create procedure GetEmployeeCount 
	as begin 
	select count (EmpName) as "Count"
	from Employee
	end

exec GetEmployeeCount

--------------------------Parameterized Stored Procedure------------------------------
create procedure GetEmpByDep(
@EmpDepartnment as varchar(20))
as begin 
select EmpName, EmpContact, EmpDepartnment from Employee where EmpDepartnment=@EmpDepartnment
end
exec GetEmpByDep @EmpDepartnment='computer'
exec GetEmpByDep @EmpDepartnment='account'
exec GetEmpByDep @EmpDepartnment='managment'
-------------------------------------------------------------------------------------------

create procedure Getabove(
@Salary as int)
as begin 
select EmpName, EmpDepartnment, EmpCity, Salary from Employee where salary>=@Salary
end
exec Getabove @Salary=19000

--------------------------------------------------------------------------------------------
create procedure InsertEmployee(
@EmpName as varchar(30), @EmpContact varchar(10), @EmpEmail varchar(40) , @EmpDepartnment varchar (20) not null, @City varchar (20) not null, @salary int)
as begin
select EmpEmail, Count(EmpEmail) from Employee Group by EmpEmail having count(EmpEmail)>1
select EmpContact, Count(EmpContact) from Employee Group by EmpContact having count(EmpContact)>1
if count(EmpEmail)>1 || count(EmpContact)>1
{}
insert into Employee values ( @EmpName, @EmpContact, @EmpEmail, @EmpDepartnment,@City, @salary)

end
--------------------------------------------------------------------------------------------

create procedure GetAverageSalary (@AverageSal decimal(10,2) output)
as begin 
select @AverageSal=avg(salary)
from Employee 
END
drop proc GetAverageSalary

declare @result decimal(10,2);
exec GetAverageSalary @AverageSal=@result output;
print 'Average Salary:  ' + cast(@result as varchar );
--------------------------------------------------------------------------------------------


--------------------------------------------------------------------------------------------
create function CalculateTax(@income decimal(10,2))
returns decimal (10,2)
as begin
select salary from Employee 
salary=salary * tax
end




