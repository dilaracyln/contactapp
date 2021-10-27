using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            var contactList = new List<ContactList>
            //ContactList new ile bir değere atanmak zorundadır. Çünkü sonrasında bu değerlerin kullanılabilmesi
            //bu şekilde mümkün olur ve ayrıca atanan değer sayesinde, bu liste view kısmına bağlanabilir.

            {
                new ContactList
                {
                    Id = 1 ,
                    Name = "Berat",
                    Surname = "Tatli",
                    TelNo = 05352298435,
                },
                new ContactList
                {
                    Id = 2,
                    Name = "Hasan",
                    Surname = "Özdemir",
                    TelNo = 4254106420
                },
                new ContactList
                {
                    Id= 3,
                    Name = "Dilara",
                    Surname = "Çaylan",
                    TelNo = 05421077409
                }
            };


            ViewBag.contactList = contactList;
            return View();
        }
    }
}
