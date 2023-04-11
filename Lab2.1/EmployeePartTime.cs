using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
	internal class EmployeePartTime : Employee
	{
		protected int workHour;

		public EmployeePartTime(int workHour)
		{
			this.workHour = workHour;
		}

		public int WorkHour { get { return workHour; } set { workHour = value; } }

		public override void InputInfo()
		{
			base.InputInfo();
			Console.Write("Work Hours: ");
			workHour = Int32.Parse(Console.ReadLine());
		}
		public override void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine(Name + "Has working: " + workHour + "h");
		}
		public override double CalculateSalary()
		{
			return workHour * 15;
		}

	}
}
