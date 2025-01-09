using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoWebsiteProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CryptoWebsiteProject.DataAccessLayer.Concrete
{
    public class Context: IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GFB6GKM\\SQLEXPRESS;initial catalog=CryptoWebsiteDb;integrated security=true");
        }
        public DbSet<CustomerAccount> CustomerAccounts  { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountProcesses  { get; set; }

    }
}
