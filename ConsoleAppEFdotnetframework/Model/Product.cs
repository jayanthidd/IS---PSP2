using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFdotnetframework
{
    class Product
    {
        [Key]//if the id does not follow the naming convention, this annotation is required
        public int ProductID { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

    }
}
