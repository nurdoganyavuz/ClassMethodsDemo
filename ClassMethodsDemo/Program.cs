using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.CustomerId = 101;
            customer1.CustormerName = "Nur";
            customer1.CustomerSurname = "Yavuz";
            customer1.Age = 23;
            customer1.Gender = "Female";

            Customer customer2 = new Customer();

            customer2.CustomerId = 102;
            customer2.CustormerName = "Engin";
            customer2.CustomerSurname = "Demiroğ";
            customer2.Age = 35;
            customer2.Gender = "Male";

            Customer customer3 = new Customer();

            customer3.CustomerId = 103;
            customer3.CustormerName = "Kerem";
            customer3.CustomerSurname = "Ünal";
            customer3.Age = 65;
            customer3.Gender = "Male";

            Customer customer4 = new Customer();

            customer4.CustomerId = 104;
            customer4.CustormerName = "Bilge";
            customer4.CustomerSurname = "Eralp";
            customer4.Age = 21;
            customer4.Gender = "Female";

            Customer customer5 = new Customer();

            customer5.CustomerId = 105;
            customer5.CustormerName = "Asya";
            customer5.CustomerSurname = "Koçak";
            customer5.Age = 66;
            customer5.Gender = "Female";

            Customer customer6 = new Customer();

            customer6.CustomerId = 106;
            customer6.CustormerName = "Kayra";
            customer6.CustomerSurname = "Yılmaz";
            customer6.Age = 26;
            customer6.Gender = "Male";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5, customer6 };

            foreach (Customer customer in customers)
            {

                if (customer.Gender == "Female")
                {
                    Console.WriteLine(customer.CustormerName + " hanım bankamızın müşterisidir.");
                }
                else
                {
                    Console.WriteLine(customer.CustormerName + " bey bankamızın müşterisidir.");
                }

            }
            Console.WriteLine("----------------------------");

            CustomerManager customerManager = new CustomerManager();
            //müşteri ekleme
            customerManager.Add(customer1); //bu şekilde spesifik olarak ekleyebiliriz.
            for (int i = 1; i < customers.Length; i++) //for ile çoklu olarak müşteri ekleme.
            {
                customerManager.Add(customers[i]);
                
            }
            
            Console.WriteLine("----------------------------");

            //müşteri silme
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);

            Console.WriteLine("----------------------------");

            //şartı bağlı müşterileri listeleme
            foreach (Customer customer in customers)
            {
                customerManager.List(customer);

            }

        }
    }
}
