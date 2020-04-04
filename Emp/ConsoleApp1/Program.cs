using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Methods methods = new Methods();
            Console.WriteLine("*******EMPLOYEE DETAILS***********\nPlease enter an Id:");
            string id = Console.ReadLine();
            methods.FindById(id);


        }
    }
}
