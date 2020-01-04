using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAngularTest.Models
{   
    [Table("Values")]
    public class Value
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}