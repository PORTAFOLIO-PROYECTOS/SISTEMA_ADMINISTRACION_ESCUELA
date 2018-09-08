create table Family_Members(
family_member_id int,
family_id int foreign key references Families(family_id),
parent_or_student_member int,
parent_id int foreign key references Parents(parent_id),
student_id int foreign key references Students(student_id)
primary key (family_member_id)
)