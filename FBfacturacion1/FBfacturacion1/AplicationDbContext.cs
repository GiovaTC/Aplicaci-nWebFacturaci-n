using FBfacturacion1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBfacturacion1
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<CFacturacion> facturacion { set; get; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options): base(options)
        {

        }
    }
}
