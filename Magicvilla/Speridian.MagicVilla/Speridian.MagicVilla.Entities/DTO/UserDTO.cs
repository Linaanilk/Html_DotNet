﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MagicVilla.Entities.DTO
{
    public class UserDTO
    {
        public int Id { get; set; } 
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
