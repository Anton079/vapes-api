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
        [Column("model")]
        public string model { get; set; }

        [Required]
        [Column("capacity")]
        public int capacity { get; set; }

        [Required]
        [Column("Price")]
        public int Price { get; set; }
    }
}
