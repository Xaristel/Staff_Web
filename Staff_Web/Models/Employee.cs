using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Staff_Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staff_Web.Models
{
    [Table("Employees")]
    [Index("FIO", IsUnique = true)]
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "ФИО")]
        public string FIO { get; set; } = "";

        [Display(Name = "Должность")]
        public string Position { get; set; } = "";
    }
}
