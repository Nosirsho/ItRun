using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Products {
	internal class ConsumerProduct : Product {
		public string BarCode { get; set; }

		public override void getProductCont() {
			Console.WriteLine("Остаток потребительского товара '" +this.Name + "' = " + this.Count);
		}
	}
}
