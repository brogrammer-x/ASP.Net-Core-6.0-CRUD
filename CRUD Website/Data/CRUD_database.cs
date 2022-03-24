#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Website.Models;

namespace CRUD_Website.Data
{
    public class CRUD_database : DbContext
    {
        public CRUD_database (DbContextOptions<CRUD_database> options)
            : base(options)
        {
        }

        public DbSet<CRUD_Website.Models.Person> Person { get; set; }
    }
}
