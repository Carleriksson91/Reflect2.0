using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reflect.Azure
{
    public class AzureContext : DbContext
    {

        public AzureContext()
           : base("name=azuredb")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Question>().HasMany<Tag>(x => x.Tags);

        }


        //public virtual DbSet<Question> Questions { get; set; }
        //public virtual DbSet<Tag> Tags { get; set; }


    }
}