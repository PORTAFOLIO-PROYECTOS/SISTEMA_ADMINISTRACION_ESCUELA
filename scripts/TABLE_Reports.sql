create table Reports(
report_id int,
student_id int foreign key references Students(student_id),
date_create datetime,
report_content varchar(max),
teachers_coments varchar(max),
other_report_detail varchar(max)
)