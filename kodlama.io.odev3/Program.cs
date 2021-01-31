using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.customerId = 1024589874;
            customer1.customerName = "Ceren";
            customer1.customerSurname = "Yıkılmaz";
            customer1.customerAccountNumber = 8546897458;

            customerManager customerManager = new customerManager();
            customerManager.Add(customer1);

            customerManager.ChangeAccountNumber(customer1);
            
        }
    }
}
