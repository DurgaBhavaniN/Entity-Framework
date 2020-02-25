create database ShopDB

use ShopDB

create table items(itemid varchar(20) primary key,name varchar(20),price int,stock int);

create table orders(orderid varchar(20) primary key,orderdate date,itemid varchar(20) foreign key references items(itemid));

insert into items(itemid,name,price,stock)
values('I0001','KeyBoard',500,10),('I002','Mouse',500,10)

insert into orders values('D0001',getdate(),'I0001')