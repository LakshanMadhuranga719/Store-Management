create table Add_Material(
Material_ID int not null identity (1,1)primary key ,
Material_Name varchar (150) not null,
Discription varchar (150) not null,
Unit varchar (100) not null,
QTY int not null  ,
Price bigint not null,
Date varchar (150) not null,
)

select  *
from  Add_Material