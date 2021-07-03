using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi!"+" "+customer.Id + " " + customer.Name + " " + customer.Surname);
        }
        public void MusteriListeleme(Customer customer)
        {
            Console.WriteLine("Müşteri Listelendi!"+" "+customer.Id+" "+customer.Name+" "+customer.Surname);
        }
        public void MusteriSilme(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi!"+" "+customer.Id + " " + customer.Name + " " + customer.Surname);
        }
        

    }
}
