using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuuHoangPhi.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public string? Id { get;set; }
        public string? FullName { get;set; }
        public string? Address { get;set; }
        
    }
}