using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using kpo.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace kpo.EntitiesContext
{
    public class AppContext : DbContext
    {
        public AppContext() : base("AppContext") { }


        public DbSet<User> Users { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Timetable> Timetables { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}