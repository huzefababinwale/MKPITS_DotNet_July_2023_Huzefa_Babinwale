use production--DB name

create table products(
product_id int primary key,
product_name varchar (20))
alter table products add price int 

insert into products values(1,'abc',100),(2,'bcc',200),(3,'cvb',300),(4,'def',400)
select * from products

declare 
@products_name varchar(max),
@lists_price decimal ;

declare c_product cursor
for select product_name ,price from products

open c_product ;
Fetch next from c_product into 
@products_name,
@lists_price

while @@fetch_status=0
begin 
print @products_name +cast(@lists_price as varchar);
fetch next from c_product into
@products_name,
@lists_price;
end;

close c_product;
deallocate c_product;
-------------------------------------------------------------------------------------------------------------------

Declare 
@product2 varchar(20),
@price2 decimal;

Declare cu_product2 cursor
for select product_name,price
from products

open cu_product2
fetch next from cu_product2 into 
@product2,
@price2;

print @product2+cast(@price2 as varchar);
while @@fetch_status =0
begin 
fetch next  from cu_product2 into @product2, @price2

print @product2+ cast(@price2 as varchar);
end;
close cu_product2;
deallocate cu_product2;
--------------------------------------------------------------------------------------------------------

create table customer(
custid int primary key,
custname varchar(20),
custage decimal )

insert into customer values(1,'Bhushan',12),(2,'Shushil',22)
select * from customer

declare
@custname varchar(max),
@custage decimal;

declare cursor_cust cursor
for select custname, custage
from customer

open cursor_cust 
fetch next from cursor_cust into @custname, @custage

print @custname+ cast(@custage as varchar);
while @@fetch_status =0
begin 
	fetch next from cursor_cust into @custname, @custage

	print @custname+cast(@custage as varchar)
	end;

close cursor_cust;
deallocate cursor_cust;
end
------------------------------------------------------------------------------------------------------------------------










