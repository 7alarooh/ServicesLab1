using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLab1.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AccountId { get; set; } // Foreign Key to BankAccount

        [Required]
        [StringLength(20)]
        public string Operation { get; set; } // Deposit, Withdraw, Transfer

        [Required]
        public decimal Amount { get; set; }

        [StringLength(50)]
        public string SourceAccNumber { get; set; } // "ATM", source account, or "None"

        [ForeignKey(nameof(AccountId))]
        public BankAccount BankAccount { get; set; } // Navigation Property
    }
}
