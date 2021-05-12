using NeroStarbucks;
using NeroStarbucks.Abstract;
using NeroStarbucks.Concrete;
using StarbucksNeroDemo.Adapters;
using System;

namespace StarbucksNeroDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { dateYear = new DateTime(1998, 2, 1), firstName = "Muhammet", lastName = "balıkçı", TcNo = "12722371948" });
            //Console.ReadLine();


        }
    }
}
