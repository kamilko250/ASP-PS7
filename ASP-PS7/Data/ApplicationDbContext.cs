using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PS3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP_PS7.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public  DbSet<FizzBuzz> FizzBuzzes{ get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 

        }

    }
}
