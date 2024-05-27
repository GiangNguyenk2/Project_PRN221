using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Prn221_Shop.Model
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 30 characters")]
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Product> Products { get; set; }
    }
}
