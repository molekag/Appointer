using Appointer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointer
{
    public class AppointerContext:DbContext
    {
        public AppointerContext():base("")
        //nie mam webconfig
        { }
        public DbSet<Clinic> Clinics { get; set; }

    }
}
