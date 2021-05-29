using System.Collections.Generic;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
    }
}