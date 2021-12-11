using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWAD.Models.ViewModel
{
    public class StudentViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter form of payment of fines")]
        public string Fines { get; set; }
        [Required(ErrorMessage = "Please enter form of payment of fines")]
        public int NumFines { get; set; }
        [Required(ErrorMessage = "Please enter form of payment of fines")]
        public DateTime DateFine { get; set; }
    }
}