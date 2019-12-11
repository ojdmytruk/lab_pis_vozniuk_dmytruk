using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApplication2.Models
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        //static StudentContext()
        //{
        //    Database.SetInitializer<StudentContext>(new StudentDBInitializer());
        //}
        //public StudentContext(string connectionString)
        //    : base(connectionString)
        //{
        //}

    }
}