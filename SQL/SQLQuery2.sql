create table logintable_store_keeper(
SK_User_ID int not null identity (1,1)primary key ,
Username varchar (150) not null,
Address varchar (150) not null,
E_mail varchar (100) not null,
Phone_NO bigint not null  ,
Password varchar (150) not null,
)