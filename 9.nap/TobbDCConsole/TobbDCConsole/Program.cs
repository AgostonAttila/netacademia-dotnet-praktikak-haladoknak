using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbDCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dc = new Hogyhivjak())
            {
                foreach (var item in dc.Products)
                {
                    Console.WriteLine(item.Nev);
                }
            }

        }
    }

    class  Product
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nev { get; set; }
    }

    class Hogyhivjak :DbContext
    {
        public DbSet<Product> Products { get; set; }


    }
    }
