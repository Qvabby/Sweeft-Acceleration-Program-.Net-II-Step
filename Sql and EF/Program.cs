//6-7 დავალებები
using Sql_and_EF.Data;
using Sql_and_EF.Services;

//Get teacherServices
TeacherServices teacherServices = new TeacherServices(new AppDbContext());
var teachers = teacherServices.GetAllTeachersByStudent("Giorgi");
//Print teachers who teach Giorgi
foreach (var teacher in teachers)
{
    Console.WriteLine(teacher.FirstName + " " + teacher.LastName);
}