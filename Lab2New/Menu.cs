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
                
                Student new_stu = new Student();
                new_stu.Input();
                studentList.Add(new_stu);
                
            }

            
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
            //Student HiScore = [0];
        }




    }
}
