create database Store_Management;

create table logintable_admin(
User_ID int not null identity (1,1)primary key ,
Username varchar (150) not null,
Address varchar (150) not null,
E_mail varchar (100) not null,
Phone_NO bigint not null  ,
Password varchar (150) not null,
)
insert into logintable_admin (Username,Address,E_mail,Phone_NO,Password) values ('Kasun','Veyangoda','kasun@gmail.com','0711234567','pass');

select  *
from logintable_admin
where  User_ID='1';za	

