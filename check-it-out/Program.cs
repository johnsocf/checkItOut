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
			//var cart = new Cart ();
			int[] products = new int[] {product.price, product1.price, product2.price};

			foreach (int i in products) {
				cart.Add(i);
			}

//			cart.Add(product.price);
//			cart.Add(3);
//			cart.Add(5);
//			cart.Add(7);
			var Total = new Checkout (cart);
			var veryTotal = Total.Total;
		}
	}
}
