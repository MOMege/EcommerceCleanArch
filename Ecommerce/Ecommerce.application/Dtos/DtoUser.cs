﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.application.Dtos
{
    public class DtoUser
    {
        public required string FirstName { get; set; }
        public required string Email { get; set;}
        public required string Password { get; set;}
      
    }
}
