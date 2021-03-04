using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleAppEFdotnetframework
{
    //1. COnsole App .NET Framework (not core)
    //2. Create the folder Model
    //3. Create the product class
    //4. Make sure it is inheriting from the DbContext class
    class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
