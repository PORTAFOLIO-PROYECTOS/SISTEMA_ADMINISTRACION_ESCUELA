create table Homework(
homework_id int,
student_id int foreign key references Students(student_id),
date_created datetime,
homework_content text,
grade varchar(20),
other_homeowrk_details varchar(max)
primary key (homework_id)
)