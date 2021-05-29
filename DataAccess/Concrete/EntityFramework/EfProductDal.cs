using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Name = "Masa",
                    Price = 15
                }
            };
        }
    }
}