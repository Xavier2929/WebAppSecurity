using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty] //helps bind data from the backend to the frontend
        public Credential Credential { get; set; } = new Credential();

        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }

    public class Credential
    {
        [Required]
        [Display(Name = "User name")]
        public string Username { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}