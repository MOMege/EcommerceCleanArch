using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ECOMMERCE.DOMAIN
{
    public  class Category
    {
       
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
