using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer1 = new Customer() ;
            customer1.Id = 1;
            customer1.Name = "Umut";
            customer1.Surname = "Uçar";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Engin";
            customer2.Surname = "Demiroğ";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Ahmet";
            customer3.Surname = "Yılmaz";

            Customer[] customers = new Customer[] {customer1,customer2,customer3 };
            Console.WriteLine("-----MÜŞTERİLER-----");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id+" "+customer.Name+" "+customer.Surname);
            }
            Console.WriteLine("-------------------------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(customer1);
            musteriManager.MusteriEkleme(customer2);
            musteriManager.MusteriEkleme(customer3);
            Console.WriteLine("-------------------------");
            musteriManager.MusteriListeleme(customer1);
            musteriManager.MusteriListeleme(customer2);
            musteriManager.MusteriListeleme(customer3);
            Console.WriteLine("-------------------------");
            musteriManager.MusteriSilme(customer1);
            musteriManager.MusteriSilme(customer2);
            musteriManager.MusteriSilme(customer3);
        }
    }
}
