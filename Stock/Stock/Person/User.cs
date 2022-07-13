using System;
using System.Collections.Generic;
using System.Text;

namespace Stock {
	internal class User : Person{
		public string Login { get; set; }
		public string Password { get; set; }
		public void Create(User user) {
			
			if (user == null || string.IsNullOrWhiteSpace(user.Login)) {
				Console.WriteLine("User is null!");
				return;
			}
			user.Id = BD.users.Count;
			BD.users.Add(user);
			Console.WriteLine("Created!");
		}
		public void Update(int id, User user) {
			if (user == null || string.IsNullOrWhiteSpace(user.Login)) {
				Console.WriteLine("User is null!");
				return;
			}
			User curUser = BD.users[id];
			if (curUser == null) {
				Console.WriteLine("User Not Found");
			}
			curUser.Login = user.Login;
			curUser.Password = user.Password;
			curUser.FirstName = user.FirstName;
			curUser.LastName = user.LastName;
			Console.WriteLine("Updated!");
		}
		public void Delete(int id) {
			User user = BD.users.Find(x => x.Id == id);
			if (user == null) {
				Console.WriteLine("User Not Found");
			}
			BD.users.Remove(user);
		}
		public User Read(int id) {
			User user = BD.users.Find(x => x.Id == id);
			if (user == null) {
				Console.WriteLine("User Not Found");
			}
			return user;
		}
		public void Logon(string login, string password) {
			foreach (User user in BD.users) {
				if (user.Login == login && user.Password == password) {
					Console.WriteLine(user.FirstName + " " + user.LastName + " wellcome");
					return;
				}
			}
			Console.WriteLine("Неправильный логин или пароль!");
		}
	}
}
