using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class customerManager
    {
        public void Add(Customer customer) 
        {

            Console.WriteLine("Yeni bir müşteri eklendi: " + "Adı: " + customer.customerName);
        }

        public void ChangeAccountNumber(Customer customer)
        {
            Console.WriteLine("Eski Hesap Numarası: " + customer.customerAccountNumber);
            customer.customerAccountNumber = 5897485468;
            Console.WriteLine("Müşterinin hesap numarası değiştirildi: " + customer.customerAccountNumber);
        }
    }
}
