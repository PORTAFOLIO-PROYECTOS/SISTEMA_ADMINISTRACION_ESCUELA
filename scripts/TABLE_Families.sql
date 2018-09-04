create table Families(
family_id int,
head_of_family_parent_id int foreign key references Parents(parent_id),
family_name varchar(100)
primary key(family_id)
)