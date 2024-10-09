--create database xd

use xd 

--create table student(
--id int identity(100,1)  primary key,
--fname varchar(20)  default 'No name',
--lname varchar(20)  default 'No name',
--mark decimal(4,2)  default 0
--)

--insert into student values
--('ali','mamadi',12.50),
--('hami','kalale',16.75),	
--('mohamad','ehsani',14.25)

--update student set mark=20
--where id=101

--delete from student where id=102

--insert into student values
--('bila','hamidi',13)

--alter table student add email varchar(100) default 'no email'


--update student set email=default


backup database xd 
 to disk='D:\Prj\_leaning\sql\xd_bak.bak'

select*from student