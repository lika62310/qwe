﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        public string Design {  get; set; }
        public Level Quality { get; set; }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
        }

        public Amulet(string itemId)
        {
            ItemId = itemId;
            Quality = Level.medium;
        }

        public Amulet (string itemId, Level quality)
        {
            ItemId = itemId;
            Quality = quality;
        }

        public override string ToString()
        {
            string s = $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
            return s;
        }
    }
}
