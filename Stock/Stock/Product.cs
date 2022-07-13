using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Products {
	public abstract class Product {
		public int Id { get; set; }
		public string Name { get; set; }
		public int Count { get; set; }
		public int Price { get; set; }
		public abstract void getProductCont();
	}
}
