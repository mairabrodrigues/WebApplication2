using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetFlex2.Models
{
    public class Rent
    {
        [Key]
        public string Show { get; set; }
        public DateTime Date { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [ForeignKey("IdClient")]
        public int ID { get; set; }

        
    }
}
