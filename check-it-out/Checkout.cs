using System;
using System.Collections.Generic;
using System.Linq;

namespace checkitout
{
	public class Checkout
	{
		List<int> cart;
		public int Total;

		public Checkout (List<int> cart) {
			CheckThisOut(cart);
		}


		public int CheckThisOut (List<int> cart)
		{
			//return cart;
			//return AddProducts(cart);
			//return Total;
			Total = cart.Sum();
			return Total;
		}


		public int AddProducts(List<int> cart) {
			cart.Sum ();
			return Total;
		}
	}
}

