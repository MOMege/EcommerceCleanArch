using ECOMMERCE.DOMAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price {  get; set; } 
        public int Stock { get; set;}
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Image>? Images { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
        [NotMapped]
        public ICollection<CartItem>? CartItems { get; set; }

    }
}
