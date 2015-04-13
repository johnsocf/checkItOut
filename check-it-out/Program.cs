using System;
using System.Collections.Generic;

namespace checkitout
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var product = new Product ();
			//var cart = new Cart ();
			List<int> cart = new List<int>();
			cart.Add(2);
			cart.Add(3);
			cart.Add(5);
			cart.Add(7);
			var Total = new Checkout (cart);
			var veryTotal = Total.Total;
			//var price = new Price ();
		}
	}
}
