namespace Errogazione_Corsi_entityFrameworks_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuintaProva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Corsi Attuali",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titolo = c.String(nullable: false, maxLength: 50),
                        NumeroPartecipanti = c.Int(name: "Numero Partecipanti", nullable: false),
                        DataLezione = c.DateTime(name: "Data Lezione", nullable: false),
                        LuogoLezione = c.String(name: "Luogo Lezione", nullable: false, maxLength: 50),
                        OreLezione = c.Int(name: "Ore Lezione", nullable: false),
                        Insegnanti_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Insegnantis", t => t.Insegnanti_ID)
                .Index(t => t.Insegnanti_ID);
            
            CreateTable(
                "dbo.Partecipantis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodiceFiscale = c.String(name: "Codice Fiscale", nullable: false, maxLength: 20),
                        Cognome = c.String(nullable: false),
                        Eta = c.Int(nullable: false),
                        Sesso = c.String(maxLength: 20),
                        Luogodinascita = c.String(name: "Luogo di nascita", nullable: false, maxLength: 30),
                        CorsiAttuali_ID = c.Int(),
                        CorsiPassati_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Corsi Attuali", t => t.CorsiAttuali_ID)
                .ForeignKey("dbo.Corsi Passati", t => t.CorsiPassati_ID)
                .Index(t => t.CorsiAttuali_ID)
                .Index(t => t.CorsiPassati_ID);
            
            CreateTable(
                "dbo.Lavoratori Statali",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Livello = c.Int(nullable: false),
                        Posizionericoperta = c.String(name: "Posizione ricoperta", nullable: false, maxLength: 50),
                        Partecipanti_ID = c.Int(),
                        SocietaAttuale_ID = c.Int(),
                        SocietaPassata_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Partecipantis", t => t.Partecipanti_ID)
                .ForeignKey("dbo.Società Attuale", t => t.SocietaAttuale_ID)
                .ForeignKey("dbo.Società Passata", t => t.SocietaPassata_ID)
                .Index(t => t.Partecipanti_ID)
                .Index(t => t.SocietaAttuale_ID)
                .Index(t => t.SocietaPassata_ID);
            
            CreateTable(
                "dbo.Liberi Professionisti",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titolo = c.String(nullable: false, maxLength: 50),
                        Partecipanti_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Partecipantis", t => t.Partecipanti_ID)
                .Index(t => t.Partecipanti_ID);
            
            CreateTable(
                "dbo.Corsi Passati",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titolo = c.String(nullable: false, maxLength: 50),
                        NumeroStudenti = c.Int(name: "Numero Studenti", nullable: false),
                        Giudizio = c.Int(nullable: false),
                        Datainizio = c.DateTime(name: "Data inizio", nullable: false),
                        Datafine = c.DateTime(name: "Data fine", nullable: false),
                        Insegnanti_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Insegnantis", t => t.Insegnanti_ID)
                .Index(t => t.Insegnanti_ID);
            
            CreateTable(
                "dbo.Insegnantis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cognome = c.String(nullable: false, maxLength: 20),
                        Età = c.Int(nullable: false),
                        Luogodinascita = c.String(name: "Luogo di nascita", nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Società Attuale",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Datainizio = c.DateTime(name: "Data inizio", nullable: false),
                        DataFine = c.DateTime(name: "Data Fine", nullable: false),
                        Indirizzo = c.String(nullable: false, maxLength: 50),
                        Numeroditelefono = c.String(name: "Numero di telefono", maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Società Passata",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Datainizio = c.DateTime(name: "Data inizio", nullable: false),
                        DataFine = c.DateTime(name: "Data Fine", nullable: false),
                        Indirizzo = c.String(nullable: false, maxLength: 50),
                        Numeroditelefono = c.String(name: "Numero di telefono", maxLength: 15),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lavoratori Statali", "SocietaPassata_ID", "dbo.Società Passata");
            DropForeignKey("dbo.Lavoratori Statali", "SocietaAttuale_ID", "dbo.Società Attuale");
            DropForeignKey("dbo.Corsi Passati", "Insegnanti_ID", "dbo.Insegnantis");
            DropForeignKey("dbo.Corsi Attuali", "Insegnanti_ID", "dbo.Insegnantis");
            DropForeignKey("dbo.Partecipantis", "CorsiPassati_ID", "dbo.Corsi Passati");
            DropForeignKey("dbo.Partecipantis", "CorsiAttuali_ID", "dbo.Corsi Attuali");
            DropForeignKey("dbo.Liberi Professionisti", "Partecipanti_ID", "dbo.Partecipantis");
            DropForeignKey("dbo.Lavoratori Statali", "Partecipanti_ID", "dbo.Partecipantis");
            DropIndex("dbo.Corsi Passati", new[] { "Insegnanti_ID" });
            DropIndex("dbo.Liberi Professionisti", new[] { "Partecipanti_ID" });
            DropIndex("dbo.Lavoratori Statali", new[] { "SocietaPassata_ID" });
            DropIndex("dbo.Lavoratori Statali", new[] { "SocietaAttuale_ID" });
            DropIndex("dbo.Lavoratori Statali", new[] { "Partecipanti_ID" });
            DropIndex("dbo.Partecipantis", new[] { "CorsiPassati_ID" });
            DropIndex("dbo.Partecipantis", new[] { "CorsiAttuali_ID" });
            DropIndex("dbo.Corsi Attuali", new[] { "Insegnanti_ID" });
            DropTable("dbo.Società Passata");
            DropTable("dbo.Società Attuale");
            DropTable("dbo.Insegnantis");
            DropTable("dbo.Corsi Passati");
            DropTable("dbo.Liberi Professionisti");
            DropTable("dbo.Lavoratori Statali");
            DropTable("dbo.Partecipantis");
            DropTable("dbo.Corsi Attuali");
        }
    }
}
