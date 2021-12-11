using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWAD.Models
{
     public enum FinesValue
        {
            PushUp,
            PayMoney
        }
    public class Student
    {
        public int Id { get; set; }
        public FinesValue Fines { get; set; }
        public int NumFines { get; set; }
    }
}