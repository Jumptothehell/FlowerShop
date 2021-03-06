using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class FlowerStore
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();

        public FlowerStore() {
            flowerList.Add("Rose");
            flowerList.Add("Lotus");
        }

        public void addToCart(string name) {
            cart.Add(name);
        }

        public void showCart() {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else {
                Console.WriteLine("My cart: ");
                foreach (string i in cart) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
