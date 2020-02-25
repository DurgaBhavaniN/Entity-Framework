create database Assignment

create table customers(customerid char(5) not null,companyname varchar(40) not null,contactname char(30) null,
caddress varchar(60) null,city char(15)null,phone char(24) null,fax char(24) null)

create table orders(orderid integer not null,customerid char(5) not null,orderdate datetime null,
shippeddate datetime null,freight money null,shipname varchar(40)null,shipaddress varchar(60) null,quantity integer null)

ALTER TABLE orders ADD shipregion integer null

ALTER TABLE orders ALTER COLUMN shipregion char(8) null

ALTER TABLE orders DROP COLUMN shipregion

insert into orders values(10,'ord01',getdate(),getdate(),100.0,'Windstar','Ocean',1)
select * from orders

ALTER TABLE orders ADD CONSTRAINT datetime DEFAULT GETDATE() FOR orderdate
insert into orders(orderid,customerid,shippeddate,freight,shipname,shipaddress,quantity) values(10,'ord01',getdate(),100.0,'Windstar','Ocean',1)

select * from customers
EXEC SP_RENAME 'customers.city','town','COLUMN'

create table Department(dept_no varchar(10) primary key,dept_nam varchar(10),location varchar(10))
insert into Department(dept_no,dept_nam,location) 
values('d1','Research','Dallas'),
('d2','Accounting','Seattle'),
('d3','Marketing','Dallas');
select * from Department

create table Employee(emp_no integer primary key,emp_fname varchar(10),emp_lname varchar(10), 
dept_no varchar(10) foreign key references Department(dept_no))
insert into Employee values(25348,'Matthew','Smith','d3')
insert into Employee values(101012,'Ann','Jones','d3')
insert into Employee values(18316,'John','Barrimore','d1')
insert into Employee values(29346,'James','James','d2')
 select * from Employee

create table Project(project_no integer primary key,project_name varchar(10),budget integer)
insert into Project(project_no,project_name,budget) 
values(1,'Apollo',120000),(2,'Gemini',95000),(3,'Mercury',185600)
select * from Project

create table Works_on(emp_no integer foreign key references Employee(emp_no),
project_no integer foreign key references Project(project_no),job varchar(10) null,enter_date date not null)
insert into Works_on(emp_no,project_no,job,enter_date) 
values(101012,1,'Analyst','1997.10.1'),
(101012,3,'Manager','1999.1.1'),
(25348,2,'Clerk','1998.2.15'),
(18316,2,'','1998.6.1'),
(29346,2,'','1997.12.15'),
(25348,3,'Analyst','1998.10.15'),
(18316,1,'Manager','1998.4.15'),
(29346,1,'','1998.8.1'),
(25348,2,'Clerk','1992.2.1'),
(18316,3,'Clerk','1997.11.15'),
(29346,1,'Clerk','1998.1.4')

select * from Works_on
select emp_no from Works_on where job='Clerk'
select emp_no from Works_on where (project_no=2) intersect  select emp_no from Works_on where (emp_no<20000) order by emp_no
select emp_no from Works_on where year(enter_date)!=1998
select emp_no from Works_on where (job='Analyst'or job='Manager') and project_no=1
select enter_date from Works_on where job='' and project_no=2
select emp_no,emp_lname from Employee where emp_fname Like'%tt%'
select emp_no,emp_fname from Employee where (emp_lname Like '_[o,a]%es')
select emp_no from Employee where dept_no in(select dept_no from Department where location='Seattle')
select emp_fname,emp_lname from Employee where emp_no in(select emp_no from Works_on where enter_date='1998.1.4')
select dept_nam,location from Department group by dept_nam,location
select max(emp_no) from Employee
select w.job from Employee as e,Works_on as w where w.emp_no=e.emp_no group by w.job having count(*)>1
select emp_no from Works_on where job='Clerk' union select emp_no from Employee where dept_no='d3'