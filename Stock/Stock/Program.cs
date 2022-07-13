using Stock.Products;
using System;
using System.Collections.Generic;

namespace Stock {
	internal class Program {
		
		static void Main(string[] args) {
			//User
			/*User user1 = new User {
				FirstName = "Tom",
				LastName = "Rider",
				Login = "T_Rider",
				Password = "123"
			};
			User user2 = new User {
				FirstName = "Bob",
				LastName = "Marley",
				Login = "B_Marley",
				Password = "321"
			};
			User user3 = new User {
				FirstName = "Leo",
				LastName = "Messi",
				Login = "Messi_10",
				Password = "1010"
			};
			User u = new User();
			u.Create(user1);
			u.Create(user2);
			u.Create(user3);
			Console.WriteLine("Create");
			foreach (User user in BD.users) {
				Console.WriteLine("UserName: " + user.FirstName);
			}
			u.Logon("Messi_10", "111");
			u.Logon("Messi_10", "1010");

			u.Update(1, user3);
			Console.WriteLine("Update");
			foreach (User user in BD.users) {
				Console.WriteLine("UserName: " + user.FirstName);
			}
			u.Delete(0);
			Console.WriteLine("Delete");
			foreach (User user in BD.users) {
				Console.WriteLine("UserName: " + user.FirstName);
			}*/

			//Client
			/*Client cl = new Client();
			Client client1 = new Client {
				FirstName = "Mickhael",
				LastName = "Owen",
				Balance = 2000
			};
			Client client2 = new Client {
				FirstName = "David",
				LastName = "Beckham",
				Balance = 2500
			};
			cl.Create(client1);
			cl.Create(client2);
			cl.SendSms("92-777-77-77", "Добрый день");
			foreach (Client client in BD.clients) {
				Console.WriteLine("Name: " + client.FirstName);
			}*/

			//EMPLOYEE
			
			/*Employee emp = new Employee();
			Employee employee1 = new Employee {
				FirstName = "Lara",
				LastName = "Croft",
				Salary = 800
			};
			Employee employee2 = new Employee {
				FirstName = "Sara",
				LastName = "Conor",
				Salary = 1200
			};
			emp.Create(employee1);
			emp.Create(employee2);
			
			foreach (Employee employee in BD.employees) {
				Console.WriteLine("Name: " + employee.FirstName + "; Salary = " + employee.GetSalary(employee.Id));
			}*/

			//Product
			ConsumerProduct consumerProduct1 = new ConsumerProduct { 
				Name = "RC",
				Count = 100,
				BarCode = "12454565121321",
				Price = 15
			};
			ConsumerProduct consumerProduct2 = new ConsumerProduct {
				Name = "Pepsi",
				Count = 170,
				BarCode = "12453216546515",
				Price = 12
			};
			IndustrialProduct industrialProduct1 = new IndustrialProduct {
				Name = "Cement",
				Count = 20000,
				Price = 50,
				Sampler = false
			};
			IndustrialProduct industrialProduct2 = new IndustrialProduct {
				Name = "Color",
				Count = 35000,
				Price = 5,
				Sampler = true
			};
			BD.products.Add(consumerProduct1);
			BD.products.Add(industrialProduct1);
			BD.products.Add(consumerProduct2);
			BD.products.Add(industrialProduct2);
			foreach (Product product in BD.products) {
				product.getProductCont();
			}
		}
	}
}
