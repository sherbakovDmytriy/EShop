﻿using EShop.Models.Sizes;
using EShop.Models.Subtypes;
using EShop.Models.TradeMarks;
using EShop.Models.Types;
using System.Collections.Generic;

namespace EShop.Models.Products
{
    public class ProductCreateEditVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Materials { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        public int? PictureId { get; set; }
        public PictureVM Picture;

        public int? TypeId { get; set; }
        public TypeVM Type { get; set; }

        public int? SubtypeId { get; set; }
        public SubtypeVM Subtype { get; set; }

        public int? TradeMarkId { get; set; }
        public TradeMarkVM TradeMark { get; set; }

        public List<SizeVM> Sizes { get; set; }
    }
}