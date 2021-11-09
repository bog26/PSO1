﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        User User { get; set; }
        public int ProductId { get; set; }
        Product Product { get; set; }
        public int Amount { get; set; }
    }
}
