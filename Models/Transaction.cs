using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuthSystem.Models
{
    //transaction model with entities 
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  
        public int TransactionID { get; set; }

        [Required]
        public int ItemID { get; set; } // Foreign key property

        [ForeignKey("ItemID")]
        [Required]
        public Item Item { get; set; }  

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

       // public ICollection<Transaction> Transactions { get; set; }
    }
}