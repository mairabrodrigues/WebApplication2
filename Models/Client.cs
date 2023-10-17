using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace NetFlex2.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(10)]
        [Required(ErrorMessage = "Field required")]
        public string UserClient { get; set; }

        [Required(ErrorMessage = "Field required")]
        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Rent> Rents { get; set; }

    }
}
