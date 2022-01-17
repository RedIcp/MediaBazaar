using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryProject;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MediaBazzar.Pages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MediaBazaarWebsite.Pages
{
    [Authorize]
    public class PreferedtimeModel : PageModel
    {


        [BindProperty]
        [Required]
        public bool Prefered { get; set; }
        

        [BindProperty]
        public string WeekDay { get; set; }
        [BindProperty]
        public string Morning { get; set; }
        [BindProperty]
        public string Afternoon { get; set; }
        [BindProperty]
        public string Evening { get; set; }
        [BindProperty]
        public string Preferred { get; set; }
        [BindProperty]
        public string LeastPreferred { get; set; }


        [BindProperty]
        [Required]
        public string Shift { get; set; }

        public SelectList Prefereds { get; set; }

        public SelectList Shifts { get; set; }

        public List<PreferedWorkTime> pwt { get; set; }

        private CookieOptions cookieOptions = new CookieOptions
        {
            Expires = DateTime.Now.AddMinutes(5)
        };

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("User");
            return new RedirectToPageResult("Login");
        }

        public void OnGet()
        {

            PreferedWorkTimeManagement workTimeManagement = new PreferedWorkTimeManagement();
            //pwt = workTimeManagement.GetPreferedWorkTimeForEmployee(LoginModel.employeeID.ToString());
            //this.Prefereds = new SelectList(pwt, "Day", "Shift");

        }

   
        public void OnPostSubmit()
        {
            PreferedWorkTimeManagement preferedWorkTime = new PreferedWorkTimeManagement();
            //foreach (PreferedWorkTime p in pwt)
            //{
            //    preferedWorkTime.EditPreferedWorkTimeForEmployee(LoginModel.employeeID, p.Day, p.Shift, p.Prefered);
            //}
        }

    }
}
