using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMMERCE.DOMAIN
{
    public class CartItem
    {
        public int id { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int CartId { get; set; }
        public Cart? Cart { get; set; }
    }
}
