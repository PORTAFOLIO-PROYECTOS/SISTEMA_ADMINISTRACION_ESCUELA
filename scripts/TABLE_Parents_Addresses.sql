create table Parents_Addresses(
parent_id int,
address_id int foreign key references Addresses(address_id),
date_address_from date,
date_address_to date
primary key(parent_id)
)