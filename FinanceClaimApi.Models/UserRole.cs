﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public class UserRole
    {
        public int Id { get; set; }
 
        public Role Role { get; set; }
        public User User { get; set; }

    }
}