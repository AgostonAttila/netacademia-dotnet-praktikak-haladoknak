using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations01
{
    class MigratingDb :DbContext
    {
        //ide s lehet a db újrakreálást rakni de midnig példányosításakor lefut
        //public MigratingDb()
        //{

        //}

        public DbSet<Product> Products { get; set; }

    }

    //Fluent API mappelésnél hasznos 

    public class Product
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }

    public class MyInitializer : DropCreateDatabaseIfModelChanges<MigratingDb>
    {
        protected override void Seed(MigratingDb context)
        {
            context.Products.Add(new Product { Name = "automata" });
            base.Seed(context);
        }

    }

}
