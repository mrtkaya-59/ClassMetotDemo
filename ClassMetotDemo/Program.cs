using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.Id = 1;
            customer.TcNo="11111111111";
            customer.Name = "Murat";
            customer.LastName = "KAYA";

            Customer customer1 = new Customer();
            customer1.Id = 2;
            customer1.TcNo = "22222222222";
            customer1.Name = "Mahmut";
            customer1.LastName = "GELE";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.delete(customer);
            customerManager.Update(customer);


            Console.ReadLine();

        }
    }
}
