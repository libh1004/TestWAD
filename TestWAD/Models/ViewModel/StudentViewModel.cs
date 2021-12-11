using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWAD.Models.ViewModel
{
    public enum FinesValue
    {
        PushUp,
        PayMoney
    }
    public class StudentViewModel
    {
       
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter form of payment of fines")]
        public FinesValue Fines { get; set; }
        [Required(ErrorMessage = "Please enter number of times to pay fines")]
        public int NumFines { get; set; }
        [Required(ErrorMessage = "Please enter fine payment date")]
        public DateTime DateFine { get; set; }
    }
}