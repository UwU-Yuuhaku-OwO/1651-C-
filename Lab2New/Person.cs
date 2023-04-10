using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Person
    {
        protected string gender;
        protected string name;
        protected int birthday;
        protected string address;


        public Person()
        {
            // Default constructor
        }

        public Person(string name, string gender , int birthday, string address)
        {
            this.Name = name;
            this.Gender = gender;
            this.Birthday = birthday;
            this.Address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public void Input()
        {
            Console.Write("\n - Name: ");
            Name = Console.ReadLine();

            Console.Write("\n - Gender: ");
            Gender = Console.ReadLine();

            Console.Write("\n - DayOfBirth: ");
            Birthday = Int32.Parse(Console.ReadLine());

            Console.Write("\n - Address: ");
            Address = Console.ReadLine();

        }

        public void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("DayOfBirth: " + Birthday);
            Console.WriteLine("Address: " + Address);
        }
    }
}
