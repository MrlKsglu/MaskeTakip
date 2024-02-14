using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrete
{
    public class PttManager : ISupplierService//Bu sınıfta maskeler ptt tarafından dağıtılacak
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) // Constructor new yapıldığında
        {

            _applicantService = applicantService;
        
        }

        public void GiveMask(Person person)
        {
           

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "  için maske verildi");
            }

            else
            {
                Console.WriteLine(person.FirstName+"  için maske verilemedi");
            }
        }
    }
}
