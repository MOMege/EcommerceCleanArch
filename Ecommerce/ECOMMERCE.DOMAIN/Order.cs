﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMMERCE.DOMAIN
{
    public  class Order
    {
        public int Id { get; set; } 
        public DateTime OrderDate { get; set; }
        public double TotalAmoun {  get; set; } 
        public int Status {  get; set; }

        public int UserId {  get; set; }
        public User? User { get; set; }
        
        public ICollection<OrderItem>? OrderItems { get; set; }
    }

}
