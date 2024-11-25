using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLab1.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public string SourceAccNumber { get; set; }  // This is the account number for the source account

        [Required]
        public string Operation { get; set; }  // Could be 'Deposit' or 'Withdraw'

        [Required]
        public decimal Amount { get; set; }

        // Foreign key to BankAccount
        public int BankAccountId { get; set; }

        // Navigation property
        public BankAccount BankAccount { get; set; }
    }
}
