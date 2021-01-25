using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {  /*Müşteri operasyonları için  Console.WriteLine (); ile similasyon */
        public void Add(Customer customer)
        {
             Console.WriteLine("Müştri eklendi");
        
        }
        public void delete(Customer customer)
        {

            Console.WriteLine("Müşteri Silindi");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Güncellendi");
        }


    }
}
