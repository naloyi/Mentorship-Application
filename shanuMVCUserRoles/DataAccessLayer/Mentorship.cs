using shanuMVCUserRoles.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace shanuMVCUserRoles.DataAccessLayer
{
    public class Mentorship: DbContext

    {
        public Mentorship()
            : base("Mentorship")
        {
    }

    public DbSet<Administrator> Administrator { get; set; }
    public DbSet<Mentee> Mentee { get; set; }
    public DbSet<Mentor> Mentor { get; set; }
    public DbSet<Pair> Pair { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        // 
        modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
    }

}
    
}