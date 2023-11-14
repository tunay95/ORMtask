using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_connection.DAL;
using Test_connection.Models;

namespace Test_connection.Services
{
    internal class GroupService
    {
        AppDbContext context = new AppDbContext();
        public void Add(Group group)
        {
            context.Groups.Add(group);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var groupToRemove = context.Groups.Find(id);
            if (groupToRemove != null)
            {
                context.Groups.Remove(groupToRemove);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Group not found");
            }
        }

        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }

        public void UpdateName(int id, string new_name)
        {
            var updatedGroup = context.Groups.Find(id);
            if (updatedGroup != null)
            {
                updatedGroup.Name = new_name;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        
    }
}
