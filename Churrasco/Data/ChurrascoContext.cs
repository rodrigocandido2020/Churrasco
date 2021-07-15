using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Churrasco.Models;

namespace Churrasco.Data
{
    public class ChurrascoContext : DbContext
    {
        public ChurrascoContext (DbContextOptions<ChurrascoContext> options)
            : base(options)
        {
        }

        public DbSet<Churrasco.Models.Evento> Evento { get; set; }
    }
}
