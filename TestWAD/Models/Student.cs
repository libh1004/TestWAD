using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWAD.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fines { get; set; }
        public int NumFines { get; set; }
        public DateTime DateFine { get; set; }
    }
}