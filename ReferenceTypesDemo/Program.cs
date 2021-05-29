using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer{Id = 2,FirstName = "Cenker"};
            Customer customer2 = customer;
            Person person1 = customer;
            Person person2 = new Employee();
            PersonDal personDal = new PersonDal();
            personDal.Add(new Visitor
            {
                Id = 1,
                FirstName = "Cenker"
            });
            Console.ReadLine();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }

    public class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    public class Employee : Person
    {
        public decimal Salary{ get; set; }
    }
    public class Visitor: Person
    {
        public string VisitorCardNumber { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
    }

    public class PersonDal
    {
        public void Add(Person person)
        {
            Console.WriteLine($"{person.FirstName} eklendi :)");
        }
    }
}
