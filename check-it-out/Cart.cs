using System;
using System.Collections.Generic;

namespace checkitout
{
	public class Cart
	{
		public Cart ()
		{
			BuildProductList();
		}

//		public int Total;
		//List<int> Items = new List<int>();
		public List<int> cart = new List<int>();

		//new Product();

		public List<int> BuildProductList() {
			//var productPrice = Product.Price();
			//Items.Add(productPrice);
			cart.Add(2);
			cart.Add(3);
			cart.Add(5);
			cart.Add(7);
			return cart;
		}

	}
}

