create table Schools(
school_id int,
addres_id int foreign key references Addresses(address_id),
school_name varchar(500),
school_principal bit,
other_school_details text
primary key(school_id)
)