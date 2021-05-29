using Entity.Concrete;

namespace Business.Abstract
{
    public interface IPersonService
    {
        bool CheckPerson(Person person);
    }
}