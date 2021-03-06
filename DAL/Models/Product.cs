﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Materials { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        public int? PictureId { get; set; }
        public Picture Picture { get; set; }

        public int? TypeId { get; set; }
        public Type Type { get; set; }

        public int? SubtypeId { get; set; }
        public Subtype Subtype { get; set; }

        public int? TradeMarkId { get; set; }
        public TradeMark TradeMark { get; set; }

        public virtual ICollection<Size> Sizes { get; set; }

        public Product()
        {
            Sizes = new List<Size>();
        }
    }
}