using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuthSystem.Models
{
    //item model with entities 
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }

        [Required]
        [StringLength(250)]
        public string ItemName { get; set; }

        [Required]
        [StringLength(250)]
        public string ItemCategory { get; set; }

        [Required]
        public decimal ItemPrice { get; set; }

        [Required]
        [StringLength(250)]
        public string ItemAvailability { get; set; }

        
    }
}
    
