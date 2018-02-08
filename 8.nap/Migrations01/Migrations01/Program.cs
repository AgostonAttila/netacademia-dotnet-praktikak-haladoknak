using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Automata config
            var config = new Configuration();
            var migration = DbMigration(config);

            migration.Update();

            //MigrationScriptDecorator script

            // Install-Package entityframework
            using (var dc = new MigratingDb())
            {

                //Migration ha van változás,ha van változás a db ben
                //Main ,global asax ...
                //  Database.SetInitializer(new MyInitializer()); // CreateDatabaseIfNotExists,DropCreateDatabaseAlways ,DropCreateDatabaseIfModelChanges

                //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MigratingDb,migráció konfigurációját tartalmazó objektum>);

                //Enable-Migrations

                foreach (var item in dc.Products)
                {
                    Console.WriteLine(item.Name);
                }
            }

        }
    }
}
