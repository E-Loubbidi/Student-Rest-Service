using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Model
{
    public class Student
    {
        [Key]
        public long Id{get; set;}
        [Required, StringLength(25)]
        public string Name{get; set;}
        public int Score{get; set;}
    }
}