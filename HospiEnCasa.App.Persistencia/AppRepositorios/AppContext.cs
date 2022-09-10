using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext:DbContext
    {
        //public DbSet<Persona> Personas {get; set; }
        public DbSet<AuxiliarHospital> AuxiliarHospital {get; set; }
        public DbSet<Enfermero> Enfermeros {get; set; }
        public DbSet<Familiar> Familiares {get; set; }
        public DbSet<HistoriaClinica> HistoriasClinicas {get; set; }
        public DbSet<Medico> Medicos {get; set; }
        public DbSet<Paciente> Pacientes {get; set; }
        public DbSet<SignoVital> SignosVitales {get; set; }
        public DbSet<SugerenciaCuidado> SugerenciasCuidados {get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if( !optionsBuilder.IsConfigured )
            {
                //Configueramos la cadena de conexion a la BDs
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = HospiEnCasaData");
            }
        }
            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Medico>()
                .HasMany(u => u.ListaHistorias)
                .WithOne(r => r.Medico)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Paciente>()
                .HasMany(u => u.ListaHistorias)
                .WithOne(r => r.Paciente)
                .HasForeignKey(r => r.PacienteId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<AuxiliarHospital>()
                .HasMany(u => u.ListaPacientes)
                .WithOne(r => r.AuxiliarHospital)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Enfermero>()
                .HasMany(u => u.ListaPacientes)
                .WithOne(r => r.Enfermero)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Medico>()
                .HasMany(u => u.ListaPacientes)
                .WithOne(r => r.Medico)
                .OnDelete(DeleteBehavior.Cascade);
            
            /*base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Paciente>()
                    .HasOne(e => e.Medico)
                    .WithMany(e => e.Pacientes)
                    .HasForeignKey(e => e.MedicoId)
                    .OnDelete(DeleteBehavior.ClientCascade);*/
        }
    }
}
