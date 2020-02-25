create database EmartDB

create table Buyer(bid varchar(20) primary key,bname varchar(20) not null,pwd varchar(20) unique not null,
email varchar(20) not null,phn integer not null,createdt date)

create table Seller(sid varchar(20) primary key, sname varchar(20) not null,pwd varchar(20) unique not null,
companyname varchar(20) not null,address varchar(20) not null, email varchar(20) not null, phn integer not null)

create table Category(cid varchar(20) primary key, cname varchar(20) not null,brief varchar(20) not null)

create table SubCategory(subid varchar(20) primary  key,subname varchar(20) not null,
cid varchar(20) foreign key references Category(cid),brief varchar(20) not null,gstin decimal(3,2))

create table Items(i_id varchar(20) primary key,cid varchar(20) foreign key references Category(cid),
subid varchar(20) foreign key references SubCategory(subid),iname varchar(20) not null, price money not null,
stock integer not null,brief varchar(20) not null,remarks varchar(20))

create table Purchase_History(id varchar(20) primary key,sid varchar(20) foreign key references Seller(sid),
bid varchar(20) foreign key references Buyer(bid),i_id varchar(20) foreign key references Items(i_id),
transactiontype varchar(20) not null,no_of_items integer not null,date_time date not null,remarks varchar(20))

create table Discounts(id varchar(20) not null, dis_code varchar(20) not null,percentage integer not null,
startdate date not null,enddate date not null,brief varchar(20) not null)




