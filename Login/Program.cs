using Login.Models;
using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password daxil edin");
            string password = Console.ReadLine();
            Console.WriteLine("Email daxil eedin!");
            string email = Console.ReadLine();
            User user = new User(email, password);
            
            int choice;
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Secim edin:(0-Info)/n" +
                   "1.User ShowInfo/n" +
                   "2.Group melumatlari ve yeni qrup yaradilmali/n" +
                   "3.Program from exit!");
                        break;
                    case 1:
                        Console.WriteLine("==============================");                       
                        user.ShowInfo();
                        Console.WriteLine("==============================");
                        break;
                        case 2:
                        Console.WriteLine("==============================");
                        string groupNo = "";
                        int studentLimit = 0;
                        Group group=new Group(groupNo,studentLimit);
                        Console.WriteLine("==============================");
                        break ;
                        case 3:
                        Console.WriteLine("==============================");
                        Console.WriteLine("Exit!");
                        Console.WriteLine("==============================");
                        break;
                    default:
                        Console.WriteLine("==============================");
                        Console.WriteLine("WRONG IS INFORMATION");
                        break;
                }
            } while (choice != 3);
        }
    }
}
