﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2_1
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double BasePrice { get; set; }
        public string ImagePath { get; set; }
        public abstract double Price { get; set; }

    }
}
