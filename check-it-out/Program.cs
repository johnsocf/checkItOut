using System;
using System.Collections.Generic;

namespace checkitout
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var product = new Product ();
			var product1 = new Product1 ();
			var product2 = new Product2 ();
			List<int> cart = new List<int>();

			int[] products = new int[] {product.price, product1.price, product2.price};

			foreach (int i in products) {
				cart.Add(i);
				Console.Write ("you added a product at $" + i + " to your cart\n");
			}

			var Total = new Checkout (cart);
			var veryTotal = Total.Total;
			Console.Write ("for a total cost of $" + veryTotal + ".  now pay up!\n");
		}
	}
}
