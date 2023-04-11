using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Menu student_list = new Menu();

            int option;

            while (true)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\t  Menu \n");
                        Console.WriteLine("\t1. Add \n");
                        Console.WriteLine("\t2. Show . \n");
                        Console.WriteLine("\t3. ShowHiLoScore\n");
                        Console.WriteLine("\t4. Search by Id \n");
                        Console.WriteLine("\t5. Remove by Id\n");
                        Console.WriteLine("\t6. Update by Id\n");
                        Console.WriteLine("\t0. Exit\n");
                        Console.Write("\tChoose menu: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.Clear();
                                student_list.AddStudent();
                                Console.ReadKey();
                                break;

                            case 2:
                                Console.Clear();
                                student_list.DisplayAllStudent();
                                Console.ReadKey();
                                break;

                            case 3:
                                Console.Clear();
                                student_list.ShowHiLoScore();
                                Console.ReadKey();
                                break;

                           case 4:
                                Console.Clear();
                                Console.WriteLine("ID:");
                                string id = Console.ReadLine();
                                student_list.SearchStudentById(id);
                                Console.ReadKey();
                                break;

                            case 5:
                                Console.Clear();
                                student_list.hocBong();
                                Console.ReadKey();
                                break;

/*
                            
       */
                            case 0:
                                break;
                            default:
                                break;
                        }
                    } while (option != 0);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number. Please write option");
                }
            }
        }
    }
}
