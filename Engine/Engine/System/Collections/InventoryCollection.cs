﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Items;

namespace Engine.System.Collections
{
    public class InventoryCollection
    {
        public Item Item { get; set; }
        public int Quanity { get; set; }

        public InventoryCollection(Item item, int quanity)
        {
            Item = item;
            Quanity = quanity;
        }
    }
}