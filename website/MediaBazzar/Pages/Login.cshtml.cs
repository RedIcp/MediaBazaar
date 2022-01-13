using ClassLibrary1;
using ClassLibraryProject.Class;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MediaBazzar.Pages
{

    public class LoginModel : PageModel
    {
        [BindProperty]
        public ClassLibrary1.Login Login { get; set; }
        private DBLogin dbLogin = new DBLogin();

        public static string EmployeeID;

        public void OnGet(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
        }

        public async Task<IActionResult> OnPost(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                var user = dbLogin.CheckLogin(Login.Username , Login.Password);
                EmployeeID = user.EmployeeID.ToString();
                if (user != null)
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim("username", user.Username));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, user.EmployeeID.ToString()));
                    claims.Add(new Claim(ClaimTypes.Name, user.Username));
                    //claims.Add(new Claim(ClaimTypes.Email, user.Email));
                    //claims.Add(new Claim(ClaimTypes.GivenName, user.FirstName));
                    //claims.Add(new Claim(ClaimTypes.Surname, user.LastName));

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    
                    await HttpContext.SignInAsync(claimsPrincipal);

                    return Redirect(returnUrl);
                }
            }

            TempData["Error"] = "Error: Incorrect Username or Password";
            return RedirectToPage("/Profile");
        }
    }
}
    