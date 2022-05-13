﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dit.Umb9.Mutobo.ToolBox.Models.PoCo
{
    public class Basket
    {
        public Guid BasketId { get; set; }
        public IEnumerable<Product> Products  { get; set; }
        public double TotalPrice { get; set; }
    }
}
