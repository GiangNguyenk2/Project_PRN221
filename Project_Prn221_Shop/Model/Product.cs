using System;
using System.Collections.Generic;

namespace Project_Prn221_Shop.Model
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public int? Stock { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
