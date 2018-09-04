create table Student_Parents(
student_id int foreign key references Students(student_id),
parent_id int foreign key references Parents(parent_id)
)