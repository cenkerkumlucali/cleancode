using System;
using Business.Abstract;
using Entity.Concrete;

namespace Business.ServiceAdapters
{
    public class KpsServiceAdapter : IPersonService
    {
        public bool CheckPerson(Person person)
        {
            KpsService kpsService = new KpsService();
            return kpsService.CheckPerson(Convert.ToInt64(person.IdentityNumber),
                person.FirstName,
                person.LastName,
                person.DateOfBirthYear);
        }
    }
}