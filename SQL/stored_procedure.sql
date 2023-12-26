use --DB joins
create procedure prod
as
begin
select *from students
end;

--to alter procedure
alter procedure prod 
as 
begin
select*from students end;

select * from students

exec prod

alter procedure prod2
as
begin
select * from students where city='gondia' end;
exec prod2
