using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        //çıplak class kalmasın !!
        //PersonManager personManager = new PersonManager(); // bir iş sınıfı başka bir iş sınıfında new leniyorsa yeniliklere ve değişimlere yeterince açık değildir

        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if(_applicantService.CheckPerson(person)) //default : personManager.CheckPerson(person) == true
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi.");
            }
        }
    }
}
