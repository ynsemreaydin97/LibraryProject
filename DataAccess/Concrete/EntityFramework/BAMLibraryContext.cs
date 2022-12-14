using BAM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAM.DataAccess.Concrete.EntityFramework
{
    public class BAMLibraryContext : IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-09UPACT\\MSSQLSERVERR; Database = BAMLibrary; Trusted_Connection = True; Encrypt = false; TrustServerCertificate = true");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
