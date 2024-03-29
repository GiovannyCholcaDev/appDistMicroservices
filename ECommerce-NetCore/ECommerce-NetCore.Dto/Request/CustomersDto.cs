﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_NetCore.Dto.Request
{
    public class CustomersDto
    {

        public string? Id { get; set; }

        public string? Name { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public DateTime BirthDate { get; set; }

        public string? Dni { get; set; }
    }
}
