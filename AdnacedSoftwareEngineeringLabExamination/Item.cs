﻿using System;
using System.Collections.Generic;

namespace OOPDemo
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> FinePerday { get; set; }
        public DateTime AddedAt { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
