using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;
        private IPersonService _personService;

        public CustomerManager(ICustomerDal customerDal, IPersonService personService)
        {
            _customerDal = customerDal;
            _personService = personService;
        }

        public void Add(Customer customer)
        {

            Utility.Validate(new CustomerValidator(),customer);
            CheckPersonExists(customer);
            CheckCustomerExists(customer);
            _customerDal.Add(customer);
        }

        public void AddByOtherBusiness(Customer customer)
        {
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);
            ValidateFirstNameLength(customer);
            CheckCustomerExists(customer);

            _customerDal.Add(customer);
        }


        private void ValidateFirstNameIfEmpty(Customer customer)
        {
            if (!string.IsNullOrEmpty(customer.FirstName))
            {
                throw new Exception("İsim validasyon hatası oldu!");
            }
        }
        private void ValidateLastNameIfEmpty(Customer customer)
        {
            if (!string.IsNullOrEmpty(customer.LastName))
            {
                throw new Exception("Soyisim validasyon hatası oldu!");
            }
        }
        private void ValidateIdentityNumberIfEmpty(Customer customer)
        {
            if (!string.IsNullOrEmpty(customer.IdentityNumber))
            {
                throw new Exception("Tc kimlik validasyon hatası oldu!");
            }
        }
        private void ValidateFirstNameLength(Customer customer)
        {
            if (customer.FirstName.Length < 2)
            {
                throw new Exception("İsim 2 harften az olamaz!");
            }
        }

        private void CheckCustomerExists(Customer customer)
        {
            if (!_customerDal.CustomerExists(customer))
            {
                throw new Exception("Müşteri zaten mevcut");
            }
        }
        /// <summary>
        /// Kişi bilgilerinin doğruluğunu kullanıyoruz
        /// </summary>
        /// <param name="person">Kişi bilgisi</param>
        private void CheckPersonExists(Person person)
        {
            if (!_personService.CheckPerson(person))
            {
                throw new Exception("Kişi bilgileri hatalı");
            }
        }
    }
}