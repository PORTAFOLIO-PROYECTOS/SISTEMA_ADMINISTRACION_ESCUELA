create table Teachers(
teacher_id int,
school_id int foreign key references Schools(school_id),
gender varchar(20),
firts_name varchar(100),
middle_name varchar(100),
last_name varchar(100),
other_teacher_details varchar(max)
primary key (teacher_id)
)