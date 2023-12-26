use functions ----DB name

create table mEmployee(
empid int primary key identity,
empname varchar(20))
select * from mEmployee

------------------------Log Tble--------------------------

create table empLog(
LogID int identity(1,1) not null,
EmpId int not null,
operation nvarchar(20) not null,
updateDate Datetime not null)

-------------------Trigger Operation----------------------
create trigger empt
on mEmployee
for insert 
as insert into 
empLog(EmpId, operation, updateDate)
select empid, 'insert',GETDATE() from 
inserted;
-------------------------trial----------------------------
insert into memployee values('amit')
insert into mEmployee values('bachhan')
select * from mEmployee
select* from empLog
-------------------------------trigger for update-----------------------------

create trigger emptu
on mEmployee
after update as insert into 
empLog(EmpId, operation, updateDate)
select empid, 'update', GetDate() from deleted;

update mEmployee set empname='amitabh' where empid=1

select * from mEmployee
select * from empLog
----------------------------------------------------------------------
create trigger empdelete
on mEmployee after delete
as insert into 
empLog(EmpId, operation, updateDate)
select empid,'Delete',GETDATE() from deleted;

delete from memployee where empid=1






