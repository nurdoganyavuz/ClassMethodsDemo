using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) //encapsulation
        {
            //müşteri ekleme simulasyonu

            if (customer.Gender == "Female")
            {
                Console.WriteLine(customer.CustormerName + " " + customer.CustomerSurname + " hanım müşterilere eklendi.");
            }
            else
            {
                Console.WriteLine(customer.CustormerName + " " + customer.CustomerSurname + " bey müşterilere eklendi.");
            }
        }

        public void Delete(Customer customer) //müşteri silme simulasyonu
        {
            Console.WriteLine(customer.CustomerId + " numaralı " + customer.CustormerName + " " + customer.CustomerSurname + " adlı müşterinin bankamızla ilişiği kesilmiştir.");

        }

        public void List(Customer customer)
        {
            if (customer.Age < 65)
            {
                Console.WriteLine(customer.CustormerName + " " + customer.CustomerSurname + " isimli müşteri bireysel emeklilik şartlarını sağlamamaktadır.");
            }
            else
            {
                Console.WriteLine(customer.CustormerName + " " + customer.CustomerSurname + " isimli müşteri bireysel emeklilik şartlarını sağlamaktadır.");
            }


        }
    }
}
