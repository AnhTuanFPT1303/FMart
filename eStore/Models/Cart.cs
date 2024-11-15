using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStore.Models
{
    public class Cart
    {
        private static Dictionary<int, int> cart;


        public Dictionary<int, int> GetCart() => cart;
        public void AddToCart(int productId, int quantity)
        {

            if (cart == null)
            {
                cart = new Dictionary<int, int>();
            }

            if (cart.ContainsKey(productId))
            {
                int _quantity;
                cart.TryGetValue(productId, out _quantity);
                quantity = _quantity + quantity;

                cart[productId] = quantity;
            } else
            {

                cart.Add(productId, quantity);
            }
            
            
        }
        public void RemoveFromCart(int ProductId)
        {

            if (cart != null)
            {

                if (cart.ContainsKey(ProductId))
                {
                    cart.Remove(ProductId);
                    if (cart.Count == 0)
                    {
                        cart = null;
                    }
                }
            }
            
        }
        public void UpdateCart(int productId, int quantity)
        {
            if (cart != null)
            {
                if (cart.ContainsKey(productId))
                {
                    cart[productId] = quantity;
                }
            }
        }

        public void DeleteCart()
        {
            cart = null;
        }
    }
}
