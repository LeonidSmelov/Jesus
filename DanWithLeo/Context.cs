using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanWithLeo
{
    class Context : DbContext
    {
        public DbSet<OnlineStore> OnlineStore { get; set; }
        public DbSet<MusicRec> MusucRec { get; set; }
    }
}
