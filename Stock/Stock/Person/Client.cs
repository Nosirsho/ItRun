using Stock.Interfaces;
using Stock.Service.SenderService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock {
	internal class Client : Person, IClientCrud, ISender {
		public int Balance { get; set; }
		public void Create(Client client) {

			if (client == null) {
				Console.WriteLine("Client is null!");
				return;
			}
			client.Id = BD.clients.Count;
			BD.clients.Add(client);
			Console.WriteLine("Created!");
		}
		public void Update(int id, Client client) {
			if (client == null) {
				Console.WriteLine("Client is null!");
				return;
			}
			Client curClient = BD.clients[id];
			if (curClient == null) {
				Console.WriteLine("Client Not Found");
			}
			curClient.FirstName = client.FirstName;
			curClient.LastName = client.LastName;
			curClient.Balance = client.Balance;
			Console.WriteLine("Updated!");
		}
		public void Delete(int id) {
			Client client = BD.clients.Find(x => x.Id == id);
			if (client == null) {
				Console.WriteLine("Client Not Found");
			}
			BD.clients.Remove(client);
		}
		public Client Read(int id) {
			Client client = BD.clients.Find(x => x.Id == id);
			if (client == null) {
				Console.WriteLine("Client Not Found");
			}
			return client;
		}
		public void SendSms(string phone, string text) {
			Console.WriteLine(text);
		}

		public void Send() {
			Console.WriteLine("Send to Client");
		}
	}
}
