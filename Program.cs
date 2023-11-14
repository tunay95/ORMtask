using System.Data.SqlClient;
using Test_connection.DAL;
using Test_connection.Models;
using Test_connection.Services;

namespace Test_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AppDbContext dbContext = new AppDbContext();
            StudentService studentService = new StudentService();
            Student student1 = new Student()
            {
                Name = "Tunay",
                Age = 19
            };
            Student student2 = new Student()
            {
                Name = "Ilkin",
                Age = 19
            };
            Student student3 = new Student()
            {
                Name = "MIRaga",
                Age = 20
            };
            Student student4 = new Student()
            {
                Name = "Rufet",
                Age = 35
            };

            studentService.Add(student1);
            studentService.Add(student2);
            studentService.Add(student3);
            studentService.Add(student4);


            studentService.Remove(1);


            List<Student> students = new List<Student>();
            foreach (Student student in students)
            {
                Console.WriteLine("Id:"+ student.Id+"Name:"+ student.Name+"Age:" + student.Age) ;

            }




             Student updatedStudent = new Student()
             {
                    Name = "Seid"
             };
             studentService.UpdateName(4, updatedStudent.Name);


            
        }
    }
}