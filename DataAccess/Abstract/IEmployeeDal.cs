using System.Collections.Generic;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal
    {
        List<Employee> GetAll();

    }
}