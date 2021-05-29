using System;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.NHibernate
{
    public class NhCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Nhibernate kullanarak veri tabanına eklendi");
        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }
}