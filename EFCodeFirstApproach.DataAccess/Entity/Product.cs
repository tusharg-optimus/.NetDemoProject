using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.DataAccess.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; }

        [Required]
        public int ProductQuantity { get; set; }

        public int ProductAmount { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
