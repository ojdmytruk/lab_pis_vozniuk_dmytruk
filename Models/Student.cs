using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int BirthYear { get; set; }
        public int Dormitory { get; set; }
        public int Room { get; set; }
    }
}