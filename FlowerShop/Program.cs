using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string decide = "y";
            FlowerStore flowerStore = new FlowerStore();
            do
            {
                ShowFlowerList(flowerStore);
                SelectFlower(flowerStore);
                decide = ExitFlowerShop(flowerStore);
            } while (decide != "exit");
        }

        static void ShowFlowerList(FlowerStore flowerStore)
        {
            Console.WriteLine("Select number for buy flower");
            foreach (string i in flowerStore.flowerList)
            {
                Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
                Console.WriteLine(i);
            }
        }
        static void SelectFlower(FlowerStore flowerStore)
        {
            string selectFlower = Console.ReadLine();
            switch (selectFlower)
            {
                case "1":
                    flowerStore.addToCart(flowerStore.flowerList[0]);
                    Console.WriteLine("Added" + flowerStore.flowerList[0]);
                    break;

                case "2":
                    flowerStore.addToCart(flowerStore.flowerList[1]);
                    Console.WriteLine("Added" + flowerStore.flowerList[1]);
                    break;

                default:
                    Console.WriteLine("Not Added to cart. found select number of flower");
                    break;
            }
        }
        static string ExitFlowerShop(FlowerStore flowerStore)
        {
            Console.WriteLine("You can stop this progess ? exit for >> exit << progress and pressany key for continue");
            string decide = Console.ReadLine();
            if (decide == "exit")
            {
                Console.Write("Current my cart");
                flowerStore.showCart();
            }
            return decide;
        }
    }
}
