using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Menu
    {
        private ArrayList studentList;


        public Menu()
        {
            this.studentList = new ArrayList();
        }

        public void AddStudent()
        {
            Console.WriteLine("How many student you want to add: ");
            int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
            {
				Console.WriteLine("___________________________________");

				Student new_stu = new Student();
                new_stu.Input();
                studentList.Add(new_stu);
                
            }
			Console.WriteLine("___________________________________");


			Console.WriteLine("enter any key to leave");
        }

        public void DisplayAllStudent()
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine("!----------------------!");
                student.Show();
                Console.WriteLine("!----------------------!");
            }
        }

        public void ShowHiLoScore()
        {
			if (studentList.Count > 0)
			{
				float highest = ((Student)studentList[0]).DTB;
				String nameHighest = ((Student)studentList[0]).Name;
				float lowest = ((Student)studentList[0]).DTB;
				String nameLowest = ((Student)studentList[0]).Name;

				foreach (Student student in studentList)
				{
					if (student.DTB > highest)
					{
						highest = student.DTB;
						nameHighest = student.Name;
					}

					if (student.DTB < lowest)
					{
						lowest = student.DTB;

					}
				}
				Console.WriteLine("!-----------Highest AverageScore-----------!");
				Console.WriteLine("\n Name: " + nameHighest);
				Console.WriteLine("\n Highest Average: " + highest);
				Console.WriteLine("!------------------------------------------!");

				Console.WriteLine("\n!------------Lowest AverageScore-----------!");
				Console.WriteLine("\n Name: " + nameLowest);
				Console.WriteLine("\n Lowest Average: " + lowest);
				Console.WriteLine("!------------------------------------------!");

			}
			else
			{
				Console.WriteLine("Student list is empty!");
			}
		}

		internal void SearchStudentById(String Id)
		{
			bool found  = false;
			foreach (Student student in studentList)
			{
				if (student.Id == Id)
				{
					student.Show();
					found = true;
					break;
				}
				if (!found)
				{
					Console.WriteLine("There is no student with ID: " + Id);
				}
			}
		}
		public void hocBong()
		{
			foreach (Student student in studentList)
			{
				if (student.DTB >= 8)
				{
					Console.WriteLine("\n Congratulation!, you got the Hoc Bong");
					student.Show();
				}
			}
		}

		


	}
}
