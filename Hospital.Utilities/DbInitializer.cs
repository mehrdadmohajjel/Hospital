using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hospital.Models;
using Hospital.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Utilities
{
    public class DbInitializer: IDbInitializer
    {
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private  ApplicationDbContext  _context;

        public DbInitializer(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public void Initialize()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            if (!_roleManager.RoleExistsAsync(WebSiteRoles.WebSite_Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Dcotor)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Patient)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(WebSiteRoles.WebSite_Secretary )).GetAwaiter().GetResult();

                _userManager.CreateAsync(new tbl_User
                {
                    UserName = "l2aiin",
                    Email = "l2aiin@yahoo.com"
                }, "zx7997op??").GetAwaiter().GetResult();
                var appUser = _context.Users.FirstOrDefault(x => x.Email == "l2aiin@yahoo.com");
                if (appUser != null)
                {
                    _userManager.AddToRoleAsync(appUser, WebSiteRoles.WebSite_Admin).GetAwaiter().GetResult();
                }
            }

            var defaultUser = _context.Users.FirstOrDefault(x => x.Email == "l2aiin@yahoo.com");
            if (defaultUser == null)
            {
                var user = new tbl_User()
                {
                    UserName = "l2aiin",
                    Email = "l2aiin@yahoo.com"
                };
                const string defaultPassword = "ZX7997op??";

                var result =   _userManager.CreateAsync(user, defaultPassword);
                if (result.Result.Succeeded)
                {
                     _userManager.AddToRoleAsync(user, WebSiteRoles.WebSite_Admin);

                }
                else
                {
                    throw new Exception($"Error creating default user: {result.Result.Errors.FirstOrDefault()?.Description}");
                }
            }


        }
    } 
}
