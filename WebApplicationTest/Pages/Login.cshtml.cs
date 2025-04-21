using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationTest.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "ID can not be empty!")]
        [Display(Name = "ID:")]
        public string inputID { set; get; }

        [BindProperty]
        [Required(ErrorMessage = "Password can not be empty!")]
        [MinLength(8, ErrorMessage = "Password must be at lesat 8 characters!")]
        public string inputPassword { set; get; }

        public string message;

        public void OnGet()
        {
             
        }

        public void OnPostLogin()
        {
            if(inputID == "laoshi" && inputPassword == "iamlaoshi")
            {
                HttpContext.Session.SetString("user_id", "Laoshi");
                Response.Redirect("Home");
            }
            else
            {
                message = "ID or Password error.";
            }
        }
    }
}
