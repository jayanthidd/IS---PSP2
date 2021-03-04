using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayWpf
{
    class VacationAmendedContext : DbContext
    {
        public DbSet<Vacation> Vacations { get; set; }

    }
}
