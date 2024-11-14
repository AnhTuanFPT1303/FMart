using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BusinessObject
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        [StringLength(100, MinimumLength = 2)]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Weight")]
        public string Weight { get; set; }

        [Required]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        [Required]
        [Display(Name = "Units In Stock")]
        public int UnitsInStock { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
