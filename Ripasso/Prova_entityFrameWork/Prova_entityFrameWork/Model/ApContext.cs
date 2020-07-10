using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_entityFrameWork.Model
{
    public class ApContext : DbContext
    {
        public ApContext() : base(@"Server=localhost\SQLEXPRESS;Database=ClientiDB;User ID=sa;Password=Its2020!")
        {

        }

       public DbSet<Cliente> Clienti { get; set; }
       public DbSet<Indirizzo> Indirizzi { get; set; }




    }
}
