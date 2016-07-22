namespace LFG.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationApplicationDB : DbMigrationsConfiguration<LFG.Models.ApplicationDbContext>
    {
        public ConfigurationApplicationDB()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LFG.Models.ApplicationDbContext context)
        {
            if (!context.Users.Any(u => u.UserName == "Admin"))
            {
                RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
                RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(roleStore);
                UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
                UserManager<ApplicationUser> userManager = new ApplicationUserManager(userStore);
                ApplicationUser admin = new ApplicationUser { UserName = "Admin" };

                userManager.Create(admin, password: "Password");
                roleManager.Create(new IdentityRole { Name = "admin" });
                userManager.AddToRole(admin.Id, "admin");


            }
        }
    }
}
