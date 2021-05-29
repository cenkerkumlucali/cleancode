using System;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Entity Framework kullanarak veri tabanına eklendi");
        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }
}