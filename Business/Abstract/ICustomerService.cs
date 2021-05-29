using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void AddByOtherBusiness(Customer customer);
    }
}