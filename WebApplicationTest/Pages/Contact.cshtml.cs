using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationTest.Pages
{
    public class ContactModel : PageModel
    {
        public string userID;

        public void OnGet()
        {
            userID = HttpContext.Session.GetString("user_id");
            if (userID == null) Response.Redirect("Login");
        }

        public void OnPostLogout()
        {
            HttpContext.Session.Remove("user_id");
            Response.Redirect("Index");
        }
    }
}
