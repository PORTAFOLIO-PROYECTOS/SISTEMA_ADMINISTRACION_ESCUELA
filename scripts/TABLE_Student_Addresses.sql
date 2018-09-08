create table Student_Addresses(
student_id int foreign key references Students(student_id),
address_id int foreign key references Addresses(address_id),
date_from date,
date_to date,
address_details varchar(max)
primary key(date_from, student_id, address_id)
)