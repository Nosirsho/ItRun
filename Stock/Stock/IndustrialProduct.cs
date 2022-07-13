using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Products {
	internal class IndustrialProduct : Product {
		public bool Sampler { get; set; }

		public override void getProductCont() {
			Console.WriteLine("Остаток промышленного товара '" + this.Name + "' = " + this.Count);
		}
	}
}
