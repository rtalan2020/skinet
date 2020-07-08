using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Rodolfo",
                    Email = "rodolfo@test.com",
                    UserName = "rodolfo@test.com",
                    Address = new Address
                    {
                        FirstName = "Rodolfo",
                        Lastname = "Talan",
                        Street = "777 Street",
                        City = "Edmonton",
                        State = "Alberta",
                        Zipcode = "10101"
                    }
                };
                await userManager.CreateAsync(user,"!R0d0lf0!");
            }
        }
    }
}