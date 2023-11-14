﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_connection.Models;

namespace Test_connection.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-0HF9IVP;database=ORM;Trusted_Connection=true;Integrated security=true;Encrypt=false");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }



    }
}
