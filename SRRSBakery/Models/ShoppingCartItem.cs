﻿namespace SRRSBakery.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Item item { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }

    }
}
