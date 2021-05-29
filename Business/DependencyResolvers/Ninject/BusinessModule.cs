using System.Net.Http.Headers;
using Business.Abstract;
using Business.Concrete;
using Business.ServiceAdapters;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerDal>().To<EfCustomerDal>();
            Bind<ICustomerService>().To<CustomerManager>();

            Bind<IPersonService>().To<KpsServiceAdapter>();
            
            Bind<IEmployeeDal>().To<EfEmployeeDal>();
            Bind<IEmployeeService>().To<EmployeeManager>();

            Bind<IProductDal>().To<EfProductDal>();
            Bind<IProductService>().To<ProductManager>();
        }
    }
}