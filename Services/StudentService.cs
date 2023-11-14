using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_connection.DAL;
using Test_connection.Models;

namespace Test_connection.Services
{
    internal class StudentService
    {
        AppDbContext context = new AppDbContext();
        public void Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var studentToRemove = context.Students.Find(id);
            if (studentToRemove != null)
            {
                context.Students.Remove(studentToRemove);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Such student not found.");
            }
        }

        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }

        public void UpdateName(int id, string new_name)
        {
            var updatedStudent = context.Students.Find(id);
            if (updatedStudent != null)
            {
                updatedStudent.Name = new_name;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Such student not found.");
            }
        }

       
    }
}
