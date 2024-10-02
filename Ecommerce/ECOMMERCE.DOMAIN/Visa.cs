using ECOMMERCE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Visa
    {
        public int VisaId { get; set; }
        public required string HolderName { get; set; }
        public DateTime DateOfExpired { get; set; }
        public double Cvv { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        
        
    }
}
