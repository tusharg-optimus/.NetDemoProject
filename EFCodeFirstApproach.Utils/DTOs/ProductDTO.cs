using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.Utils.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int ProductQuantity { get; set; }

        public int ProductAmount { get; set; }
    }
}
