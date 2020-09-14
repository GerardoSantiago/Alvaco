namespace DatabaseLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Telefono> Telefono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.Empleado)
                .WithRequired(e => e.Departamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Telefono>()
                .Property(e => e.Lada)
                .IsUnicode(false);

            modelBuilder.Entity<Telefono>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Telefono>()
                .Property(e => e.Extension)
                .IsUnicode(false);
        }
    }
}
