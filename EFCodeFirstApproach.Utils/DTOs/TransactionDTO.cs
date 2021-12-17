using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.Utils.DTOs
{
    public class TransactionDTO
    {
        public int Id { get; set; }

        public string TransactionType { get; set; }

        public int TransactionAmount { get; set; }
    }
}
