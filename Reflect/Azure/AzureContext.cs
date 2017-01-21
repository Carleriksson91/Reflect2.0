using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using Reflect.Azure.Entities;
using Reflect.Models;

namespace Reflect.Azure
{
    public class AzureContext : IdentityDbContext<ApplicationUser>
    {
        public AzureContext()
            : base("azuredb", throwIfV1Schema: false) { }

        public static AzureContext Create()
        {
            return new AzureContext();
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<QuestionAlternative> QuestionAlternatives { get; set; }
        public DbSet<Tag> Tags { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
        //    modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
        //    modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        //}
    }
}