using Stock.Interfaces;
using Stock.Service.SenderService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock {
	internal class Employee : Person, IEmployeeCrud, ISender {
		public int Salary { get; set; }
		public void Create(Employee employee) {

			if (employee == null) {
				Console.WriteLine("Employee is null!");
				return;
			}
			employee.Id = BD.employees.Count;
			BD.employees.Add(employee);
			Console.WriteLine("Created!");
		}
		public void Update(int id, Employee employee) {
			if (employee == null) {
				Console.WriteLine("Employee is null!");
				return;
			}
			Employee curEmployee = BD.employees[id];
			if (curEmployee == null) {
				Console.WriteLine("Employee Not Found");
			}
			curEmployee.FirstName = employee.FirstName;
			curEmployee.LastName = employee.LastName;
			curEmployee.Salary = employee.Salary;
			Console.WriteLine("Updated!");
		}
		public void Delete(int id) {
			Client client = BD.clients.Find(x => x.Id == id);
			if (client == null) {
				Console.WriteLine("Employee Not Found");
			}
			BD.clients.Remove(client);
			Console.WriteLine("Deleted!");
		}
		public Employee Read(int id) {
			Employee employee = BD.employees.Find(x => x.Id == id);
			if (employee == null) {
				Console.WriteLine("Employee Not Found");
			}
			return employee;
		}
		public int GetSalary(int id) {
			Employee curEmployee = BD.employees[id];
			if (curEmployee == null) {
				Console.WriteLine("Employee Not Found");
			}
			return curEmployee.Salary;
		}
		public void Send()
		{
			Console.WriteLine("Send to Employee");
		}
	}
}
