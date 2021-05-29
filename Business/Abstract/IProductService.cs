using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}