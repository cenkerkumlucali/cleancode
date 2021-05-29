using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class EfEmployeeDal : IEmployeeDal
    {
        public List<Employee> GetAll()
        {
            return new List<Employee>{new Employee 
            {
                Id = 1, FirstName = "Cenker", LastName = "Kumlucalı",
                DateOfBirthYear = 2002, IdentityNumber = "1010101010000",
                Salary = 600

            },new Employee 
            {
                    Id = 1, FirstName = "Engin", LastName = "Demiroğ",
                    DateOfBirthYear = 1985, IdentityNumber = "1010101010050",
                    Salary = 600
            }
        };
        }
    }
}