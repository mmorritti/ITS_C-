using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errogazione_Corsi_entityFrameworks_.Model
{
    public class ECContext : DbContext 
    {
        public ECContext() : base(@"Server=localhost\SQLEXPRESS;Database=ErrogazioneCorsi;User ID=sa;Password=Its2020!")
        {

        }

        public DbSet<CorsiAttuali> CorsiAttualis { get; set; }
        public DbSet<CorsiPassati> CorsiPassatis { get; set; }
        public DbSet<Insegnanti> Insegnantis { get; set; }
        public DbSet<LavoratoriStatali> LavoratoriStatalis { get; set; }
        public DbSet<LiberiProfessionisti> liberiProfessionistis { get; set; }
        public DbSet<Partecipanti> Partecipantis { get; set; }
        public DbSet<SocietaAttuale> SocietaAttuales { get; set; }
        public DbSet<SocietaPassata> SocietaPassatas { get; set; }








    }
}
