using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
	internal class Employee
	{
		protected string id;
		protected string name;
		protected string address;

		public Employee()
		{
			id = "";
			name = "";
			address = "";
		}

		public Employee(string id, string name, string address)
		{
			this.id = id;
			this.name = name;
			this.address = address;
		}

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		public void InputInfo()
		{
			Console.Write("Enter employee id: ");
			id = Console.ReadLine();
			Console.Write("Enter employee name: ");
			name = Console.ReadLine();
			Console.Write("Enter employee address: ");
			address = Console.ReadLine();
		}

		public void PrintInfo()
		{
			Console.WriteLine("Employee Information:");
			Console.WriteLine("ID: " + id);
			Console.WriteLine("Name: " + name);
			Console.WriteLine("Address: " + address);
		}

		public double CalculateSalary()
		{
			return 0;
		}
	}
}
