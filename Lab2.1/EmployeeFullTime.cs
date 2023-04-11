using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
	internal class EmployeeFullTime : Employee
	{
		protected double basic_salary;
		protected int overtime;
		protected int typeOfPosition;

		public EmployeeFullTime() { }

		public EmployeeFullTime(string id, string name, string address, double basic_salary, int overtime, int typeOfPosition)
		: base(id, name, address)
		{
			this.basic_salary = basic_salary;
			this.overtime = overtime;
			this.typeOfPosition = typeOfPosition;
		}

		public double BasicSalary {get { return basic_salary; }set {  basic_salary = value; } }
		public int Overtime { get {  return overtime; } set {  overtime = value; } }
		public int TypeOfPosition { get {  return typeOfPosition; } set {  typeOfPosition = value; } }

		public override void InputInfo()
		{
			base.InputInfo();
			Console.Write("Basic Salary: ");
			basic_salary = double.Parse(Console.ReadLine());
			Console.Write("OverTime: ");
			overtime = Int32.Parse(Console.ReadLine());
			Console.Write("Type of Position: ");
			typeOfPosition = Int32.Parse(Console.ReadLine());
		}

		public override void PrintInfor()
		{ 
			
		}
	}
}
