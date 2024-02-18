using Businesss.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor -> new yapildiginda calisir.
        {
            _applicantService = applicantService;

        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " icin maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERILEMEDI.");
            }
        }
    }
}
