using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ErogazioneCorsi.Models
{
    public class MyContext : DbContext
    {
        public MyContext()
        {
            new MyContext(Properties.Settings.Default.MyConnection);

        }

        public MyContext(string connectionString) : base(connectionString) { }

        public DbSet<Azienda> Aziendas { get; set; }
        public DbSet<Corsi>Corsis { get; set; }
        public DbSet<Docenti>Docentis { get; set; }
        public DbSet<Partecipanti>Partecipantis { get; set; }
        public DbSet<Sedi>sedis { get; set; } 



    }
}