using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.DataAccess.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
