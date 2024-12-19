using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindEcommerceAPI
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        
        public short UnitsInStock { get; set; }
    }
}