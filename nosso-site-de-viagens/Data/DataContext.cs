using Microsoft.EntityFrameworkCore;
using nosso_site_de_viagens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nosso_site_de_viagens.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {

        }
        public DbSet<Pais> Pais { get; set; }
    }
}
