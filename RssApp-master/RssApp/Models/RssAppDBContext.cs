using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssApp.Models
{
    public class RssAppDBContext : DbContext
    {

        public RssAppDBContext()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=RssAppDB;uid=sa;pwd=1234;MultipleActiveResultSets=true");


            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<RssInfo> RssInfo { get; set; }



    }
}
