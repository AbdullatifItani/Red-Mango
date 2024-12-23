using Microsoft.AspNetCore.Identity;

///Add Name Column to Database
namespace RedMango_API 
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}