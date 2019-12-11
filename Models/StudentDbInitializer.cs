using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class StudentDBInitializer: DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext db)
        {
            db.Students.Add(new Student { Name = "Иван Иванов", Faculty="FICT", Dormitory = 8, Room = 111, BirthYear = 1999 });
            db.Students.Add(new Student { Name = "Петр Петров", Faculty = "FICT", Dormitory = 3, Room = 222, BirthYear = 1998 });
            db.Students.Add(new Student { Name = "Василий Васильев", Faculty = "FICT", Dormitory = 20, Room = 333, BirthYear = 1997 });

            base.Seed(db);
        }
    }
}