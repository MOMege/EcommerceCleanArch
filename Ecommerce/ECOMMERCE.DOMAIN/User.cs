using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMMERCE.DOMAIN
{
    public class User
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public  required string Email { get; set; }
        public required string Password { get; set; }
 
        public ICollection<Order>? Orders { get; set; }

        public ICollection<Review>? Reviews { get; set; }
        [NotMapped]
        public Cart? Cart { get; set; }
    }
}
