using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using Business.ServiceAdapters;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation;

namespace WorkingWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal(),new KpsServiceAdapter());
            customerManager.Add(new Customer
            {
                FirstName = "Cenker",
                LastName = "Kumlucalı",
                IdentityNumber = "123456789"
            });

            customerManager.AddByOtherBusiness(new Customer
            {
                FirstName = "Derin",
                LastName = "Demiroğ",
                IdentityNumber = "123456789"
            });
        }
    }
}
