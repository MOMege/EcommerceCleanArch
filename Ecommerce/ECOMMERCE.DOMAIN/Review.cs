﻿using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMMERCE.DOMAIN
{
    public class Review
    {
        public int Id {  get; set; }
        public int Rating { get; set; }
        public  string? Comment { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public int ProductId {  get; set; }
        public Product?  Product { get; set; }
          

    }
}
