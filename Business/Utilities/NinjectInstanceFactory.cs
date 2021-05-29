using Business.DependencyResolvers.Ninject;
using Ninject;

namespace Business.Utilities
{
    public class NinjectInstanceFactory
    {
        public static T GetInstance<T>()
        {
            StandardKernel kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}