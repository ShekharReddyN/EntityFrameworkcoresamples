using Sample1.Core.Models;
using Sample1.Persistence;
using System;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitWork = new UnitOfWork(new Adventureworks2016Context()))
            {
                foreach (var item in unitWork.Persons.GetPersonNames())
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
