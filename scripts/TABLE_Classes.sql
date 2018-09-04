create table Classes(
class_id int,
subject_id int foreign key references subjects(subject_id),
teacher_id int foreign key references Teachers(teacher_id),
class_code varchar(20),
class_name varchar(100),
date_from date,
date_to date
primary key(class_id)
)