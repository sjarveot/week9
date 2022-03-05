using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wishlist = new List<string>();

            Console.WriteLine(wishlist.Count);

            wishlist.Add("coffeemaker");
            wishlist.Add("new pair of socks");
            wishlist.Add("box of chocolates");
            wishlist.Add("new pillow");

            Console.WriteLine(wishlist.Count);

            //Console.WriteLine(wishList[0]);
            //Console.WriteLine(wishList[1]);
            //Console.WriteLinew(wishList[2]);

            foreach (string wish in wishlist)
            {
                Console.WriteLine(wish);
            }

        }
    }
}

  
