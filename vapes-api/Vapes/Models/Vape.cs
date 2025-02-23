using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vapes_api.Vapes.Models
{
    [Table("vape")]
    public class Vape
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("type")]
        public string type { get; set; }

        [Required]
        [Column("capacity")]
        public int capacity { get; set; }

        [Required]
        [Column("price")]
        public int price { get; set; }
    }
}
