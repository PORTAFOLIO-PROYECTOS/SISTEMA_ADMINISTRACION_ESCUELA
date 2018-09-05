create table Student_Classes(
student_id int foreign key references Students(student_id),
class_id int foreign key references Classes(class_id),
date_from date,
date_to date
primary key(date_from, student_id, class_id)
)