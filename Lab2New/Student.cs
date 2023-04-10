using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student : Person
    {
        protected string id;
        protected int dtb;
        protected string email;

        public Student()
        {
            // Default constructor
        }

        public Student(string name, string gender, int birthday, string address, string id, int dtb, string email)
                : base(name, gender, birthday, address)
        {
            this.Id = id;
            this.DTB = dtb;
            this.Email = email;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public int DTB
        { get { return dtb; } set {  dtb = value; } }

        public string Email
        { get { return email; } set {  email = value; } }


        public new void Input()
        {
            base.Input(); // Call InputInfo method from Person
            Console.Write("Student IDs: ");
            Id = Console.ReadLine();
            Console.Write("AverageScore : ");
            DTB = Int32.Parse(Console.ReadLine());
            Console.Write("Email: ");
            Email = Console.ReadLine();
        }

        // Override ShowInfo method
        public new void Show()
        {
            base.Show(); // Call ShowInfo method from Person
            Console.WriteLine("Ma sinh vien: " + Id);
            Console.WriteLine("Diem trung binh: " + DTB);
            Console.WriteLine("Email: " + Email);

            if (DTB > 8) { Console.WriteLine("u got học bổng"); } else { Console.WriteLine("Ráng học thêm nha!"); }
        }

    }
}
