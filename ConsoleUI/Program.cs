using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Business.Abstract;
using Business.Utilities;
using Entity.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Product();
            Employee();
            Customer();
        }

        private static void Product()
        {
            IProductService productService = NinjectInstanceFactory.GetInstance<IProductService>();
            var result = productService.GetAll();
            foreach (var product in result)
            {
                Console.WriteLine($"Ad: {product.Name} " +
                                  $"Fiyat: {product.Price} ");
            }

            Console.ReadLine();
        }

        private static void Employee()
        {
            IEmployeeService employeeService = NinjectInstanceFactory.GetInstance<IEmployeeService>();
            var result = employeeService.GetAll();
            foreach (var employee in result)
            {
                Console.WriteLine($"Ad: {employee.FirstName} " +
                                  $"Soyad: {employee.LastName} " +
                                  $"Maaş: {employee.Salary}");
            }
        }

        private static void Customer()
        {
            ICustomerService customerService = NinjectInstanceFactory.GetInstance<ICustomerService>();
            customerService.Add(new Customer
            {
                Id = 1,
                CityId = 1,
                FirstName = "Cenker",
                LastName = "Kumlucalı",
                IdentityNumber = "2312312312",
                DateOfBirthYear = 2002
            });
        }
    }
}
