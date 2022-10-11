using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staff_Web.Models
{
    [Table("Employees")]
    [Index("FIO", IsUnique = true)]
    public class Employee
    {
        public int Id { get; set; }
        public string FIO { get; set; } = "";
        public string Position { get; set; } = "";
    }
}
