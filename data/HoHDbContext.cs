using System;
using System.Linq;
using hohsys.API.helpers;
using hohsys.API.models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace hohsys.API.data
{
    public class HoHDbContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        private readonly IGetCurrentUserService gcu;
        public HoHDbContext(DbContextOptions options, IGetCurrentUserService _gcu) : base(options)
        {
            gcu = _gcu;
        }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<PacientComentary> PatientComentaries { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MedicalIndication> MedicalIndications { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<MediaCategory> MediaCategories { get; set; }
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<WorkRoute> WorkRoutes { get; set; }
        public DbSet<WorkRouteComentary> WorkRouteComentaries { get; set; }
        public DbSet<WorkRouteMedia> WorkRouteMedia { get; set; }

        // Enabling Lazy Loading on data models
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        // Applaying relationship and property values on models
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // new ApplicationUserConfiguration(builder.Entity<MyEntity>());
            // Identity Section
            builder.Entity<Destination>(dest => {
                dest.Property(c => c.DestinationName).HasComment("Titulo o nombre del destino");
                dest.Property(c => c.Description).HasComment("Descrición general del destino");
                dest.Property(c => c.Picture).HasComment("Imagen principal del registro");
                dest.Property(c => c.GoogleMapEmbedUrl).HasComment("Url de google Maps de la localización geográfica del destino.");
                // dest.Property(c => c.WorkRoute).HasComment("Elemento de relacion con la entidad WorRoute");

                dest.Property(c => c.Id).HasComment("Llave primaria de la entidad");
                dest.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico");
                dest.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro");
                dest.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro");
                dest.Property(c => c.UserAdded).HasComment("Usuario que creó el registro");
                dest.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización");
                
            });
            builder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                        .HasForeignKey(ur => ur.RoleId).IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                        .HasForeignKey(ur => ur.UserId).IsRequired();
            });
            // comentaries relation
            builder.Entity<User>(user => {
                user.HasMany(u => u.PacientComentaries)
                    .WithOne(c => c.User);
                user.HasMany(u => u.WorkRouteComentaries)
                    .WithOne(c => c.User);
                user.Ignore(u => u.FullName);
                // Comments
                user.Property(c => c.Id).HasComment("Llave primaria de la entidad");
                user.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico");
                user.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro");
                user.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro");
                user.Property(c => c.Name).HasComment("Nombre de usuario. En este caso solo se guarda el primer nombre de un usuario.");
                user.Property(c => c.Lastname).HasComment("Apellido de un usuario. para este registro solo se almacena un apellido de usuario");
                
            });
            // relationship of Clinics | Employees and Clinics | Pacients
            builder.Entity<Clinic>(clinic =>
            {
                clinic.HasMany(e => e.Employees)
                    .WithOne(c => c.Clinic).IsRequired();

                clinic.HasMany(e => e.Pacients)
                    .WithOne(c => c.Clinic);
                // defining properties
                // clinic.Property(c => c.Pacient).HasComment("Campo relacional donde una clinica atiende a uno o muchos pacientes");
                clinic.Property(e => e.Address).HasComment("Propiedad de borrado lógico");
                clinic.Property(c => c.PhoneNumber).HasComment("Número de teléfono de la clínica");
                clinic.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización");
                clinic.Property(c => c.Name).HasMaxLength(60).HasComment("Nombre de la clinica en el registro");
                clinic.Property(c => c.Description).HasMaxLength(500).HasComment("Descripción general de la clínica");
                clinic.Property(c => c.Address).HasMaxLength(500).HasComment("Propiedad de borrado lógico");
                clinic.Property(c => c.City).HasMaxLength(100).HasComment("Ciudad donde se ubica la clínica");
                clinic.Property(c => c.PhoneNumber).HasMaxLength(100);
                clinic.Property(c => c.Id).HasComment("Llave primaria de la entidad");
                clinic.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico");
                clinic.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro");
                clinic.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro");
                clinic.Property(c => c.UserAdded).HasComment("Usuario que creó el registro");
                clinic.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización");
            });
            // relationship of Employees with Emails | Positions | PhoneNumbers
            builder.Entity<Employee>(employee =>
            {
                employee.HasMany(e => e.Emails)
                    .WithOne(em => em.Employee);
                employee.HasMany(e => e.Positions)
                    .WithOne(em => em.Employee);
                employee.HasMany(e => e.PhoneNumbers)
                    .WithOne(em => em.Employee);

                // defining properties
               employee.Property(e => e.FirstName1).HasMaxLength(100).HasComment("Primer nombre del empleado.");
                employee.Property(e => e.FirstName2).HasMaxLength(100).HasComment("Segundo nombre del empleado.");
                employee.Property(e => e.LastName1).HasMaxLength(100).HasComment("Primer apellido del empleado.");
                employee.Property(e => e.LastName2).HasMaxLength(100).HasComment("Segundo apellido del empleado.");
                employee.Property(e => e.Address).HasMaxLength(400).HasComment("Dirección domiciliar del empleado.");
                employee.Ignore(e => e.FullName);
                // employee.Property(c => c.Positions).HasComment("Campo relacional que describe que un empleado puede tener uno o varios cargos dentro de una clínica.");
                employee.Property(c => c.ProfilePicture).HasComment("Foto de perdil de empleado.");
                employee.Property(c => c.Id).HasComment("Llave primaria de la entidad.");
                employee.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico.");
                employee.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro.");
                employee.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro.");
                employee.Property(c => c.UserAdded).HasComment("Usuario que creó el registro.");
                employee.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización.");
            });
            // positions
            builder.Entity<Position>(position => {
                position.Property(c => c.PositionName).HasComment("Nombre del cargo o posición que se ejerce en una clínica.");
                position.Property(c => c.Description).HasComment("Descripción del cargo.");
                // position.Property(c => c.Employee).HasComment("Campo relacional en donde una posición corresponde a un empleado.");
                position.Property(c => c.Id).HasComment("Llave primaria de la entidad.");
                position.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico.");
                position.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro.");
                position.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro.");
                position.Property(c => c.UserAdded).HasComment("Usuario que creó el registro.");
                position.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización.");
            });
            // relationship of Pacients with Comentaries
            builder.Entity<Pacient>(pacient =>
            {
                pacient.HasMany(p => p.PacientComentaries)
                    .WithOne(c => c.Pacient);
                pacient.HasMany(p => p.PacientMedia)
                    .WithOne(c => c.Pacient);
                pacient.HasMany(p => p.MedicalRecords)
                    .WithOne(c => c.Pacient);

                // defining properties
                pacient.Property(e => e.FirstName1).HasMaxLength(100).HasComment("Primer nombre del paciente");
                pacient.Property(e => e.FirstName2).HasMaxLength(100).HasComment("Segundo nombre del paciente");
                pacient.Property(e => e.LastName1).HasMaxLength(100).HasComment("Primer apellido del paciente");
                pacient.Property(e => e.LastName2).HasMaxLength(100).HasComment("Segundo apellido del paciente");
                pacient.Property(e => e.Address).HasMaxLength(400).HasComment("Dirección domiciliar del paciente");
                pacient.Ignore(e => e.FullName);
                pacient.Ignore(e => e.StringGender);
                pacient.Property(c => c.Id).HasComment("Llave primaria de la entidad");
                pacient.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico");
                pacient.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro");
                pacient.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro");
                pacient.Property(c => c.UserAdded).HasComment("Usuario que creó el registro");
                pacient.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización");
            });
            // Relationship between Medical records and medical indications
            builder.Entity<MedicalRecord>().HasMany(m => m.MedicalIndications).WithOne(me => me.MedicalRecord);
            builder.Entity<MedicalRecord>(med => {
                med.Property(c => c.Id).HasComment("Llave primaria de la entidad");
                med.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico");
                med.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro");
                med.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro");
                med.Property(c => c.UserAdded).HasComment("Usuario que creó el registro");
                med.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización");
            });
            // relationship of WorkRoutes with Comentaries | Employees | Pacients | Schedules | 
            builder.Entity<WorkRoute>(route =>
            {
                route.HasMany(wr => wr.WorkRouteComentaries)
                    .WithOne(wc => wc.WorkRoute);
                route.HasMany(wr => wr.Employees)
                    .WithOne(e => e.WorkRoute);
                route.HasMany(wr => wr.Pacients)
                    .WithOne(p => p.WorkRoute);
                route.HasMany(wr => wr.Schedules)
                    .WithOne(s => s.WorkRoute);
                route.HasMany(wr => wr.Destinations)
                    .WithOne(d => d.WorkRoute);
                route.HasMany(wr => wr.WorkRouteMedia)
                    .WithOne(wrp => wrp.WorkRoute);    
                // defining properties
                // route.Property(c => c.WorkRouteComentaries).HasComment("Entidad de relación que describe que una ruta puede tener uno o varios comentarios relacionados");
                // route.Property(c => c.Pacients).HasComment("Campo de relación con entidad Pacients donde una ruta tiene uno o varios pacientes a ser visitados");
                // route.Property(c => c.Employees).HasComment("Campo de relación con la entidad Employees donde una ruta de trabajo tiene uno o varios miembros empleados para ejecutar dicha ruta");
                // route.Property(c => c.Schedules).HasComment("Campo de relación con la entidad Schedule el cual indica que una ruta tiene dias de ejecucion en calendario");
                // route.Property(c => c.Destinations).HasComment("Campo de relación con la entidad Destination en donde una ruta tiene un destino o punto de llegada");
                // route.Property(c => c.WorkRouteMedia).HasComment("Campo de relación 1 a muchos con la entidad WorkRouteMedia en donde u registro de rutas puede contener  una o varias imagenes");
                // route.Property(c => c.Clinic).HasComment("Campo de relación con la entidad Clínica, en donde una ruta o varias rutas  estan relacionadas a una clínica.");
                route.Property(c => c.FeaturedImage).HasComment("Imagen titular del registro de ruta.");
                route.Property(r => r.RouteName).HasMaxLength(200).HasComment("Título que corresponde al registro de rutas de trabajo.");
                route.Property(r => r.Description).HasMaxLength(500).HasComment("Descripción general de la ruta de trabajo.");
                route.Property(c => c.Id).HasComment("Llave primaria de la entidad.");
                route.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico.");
                route.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro.");
                route.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro.");
                route.Property(c => c.UserAdded).HasComment("Usuario que creó el registro.");
                route.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización.");
            });
            // alter table name of media tables
            builder.Entity<WorkRouteMedia>(wmedia => {
                wmedia.ToTable("WorkRouteMedia");
                wmedia.Property(c => c.Url).HasComment("dirección de ubicación del archivo al que refiere el registro");
                wmedia.Property(c => c.Id).HasComment("Llave primaria de la entidad");
                wmedia.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico");
                wmedia.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro");
                wmedia.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro");
                wmedia.Property(c => c.UserAdded).HasComment("Usuario que creó el registro");
                wmedia.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización");
            });
            builder.Entity<PacientMedia>(pmedia => {
                pmedia.ToTable("PacientMedia");
                pmedia.Property(c => c.Url).HasComment("dirección de ubicación del archivo al que refiere el registro");
                pmedia.Property(c => c.Id).HasComment("Llave primaria de la entidad");
                pmedia.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico");
                pmedia.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro");
                pmedia.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro");
                pmedia.Property(c => c.UserAdded).HasComment("Usuario que creó el registro");
                pmedia.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización");
            });
            // Schedule 
            builder.Entity<Schedule>(sch => {
                // comentarios
                sch.Property(c => c.State).HasComment("Estado actual de un horario (Pendiente, ejecutado, cancelado).");
                sch.Property(c => c.Day).HasComment("Nombre del dia que corresponda al registro de horario creado.");
                sch.Property(c => c.Id).HasComment("Llave primaria de la entidad.");
                sch.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico.");
                sch.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro.");
                sch.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro.");
                sch.Property(c => c.UserAdded).HasComment("Usuario que creó el registro.");
                sch.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización.");
            });
            // media relationship
            builder.Entity<MediaCategory>(media => {
                media.HasMany(m => m.WorkRouteMedia)
                    .WithOne(mc => mc.MediaCategory);
                media.HasMany(m => m.PacientMedia)
                    .WithOne(mc => mc.MediaCategory);

                // comentarios
                media.Property(c => c.CategoryName).HasComment("Nombre de la categoría");
                media.Property(c => c.Id).HasComment("Llave primaria de la entidad");
                media.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico");
                media.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro");
                media.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro");
                media.Property(c => c.UserAdded).HasComment("Usuario que creó el registro");
                media.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización");
            });
            builder.Entity<Email>( email => {
                 email.Property(c => c.EmailAddress).HasComment("Corresponde a la dirección de correo electrónico.");
                // email.Property(c => c.Employee).HasComment("Campo relacional que refiere uno o varios correos por emplpeado.");
                email.Property(c => c.Id).HasComment("Llave primaria de la entidad.");
                email.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico.");
                email.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro.");
                email.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro.");
                email.Property(c => c.UserAdded).HasComment("Usuario que creó el registro.");
                email.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización.");
            });
            builder.Entity<PhoneNumber>( phone => {
                phone.Property(c => c.number).HasComment("Corresponde al registro número de teléfono.");
                phone.Property(c => c.Extention).HasComment("Número de extensión del número.");
                // phone.Property(c => c.Employee).HasComment("Campo relacional que refiere uno o varios números por emplpeado.");
                phone.Property(c => c.Id).HasComment("Llave primaria de la entidad.");
                phone.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico.");
                phone.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro.");
                phone.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro.");
                phone.Property(c => c.UserAdded).HasComment("Usuario que creó el registro.");
                phone.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización.");
            });


            builder.Entity<MediaCategory>( mcateg => {
                mcateg.Property(c => c.CategoryName).HasComment("Nombre de la categoría.");
                // mcateg.Property(c => c.WorkRouteMedia).HasComment("Campo relacional que refiere a la categoria de un registro de WorkRouteMedia.");
                // mcateg.Property(c => c.PacientMedia).HasComment("Campo relacional que refiere a la categoria de un registro de PacientMedia.");
                mcateg.Property(c => c.Id).HasComment("Llave primaria de la entidad.");
                mcateg.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico.");
                mcateg.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro.");
                mcateg.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro.");
                mcateg.Property(c => c.UserAdded).HasComment("Usuario que creó el registro.");
                mcateg.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización.");
            });

            builder.Entity<WorkRouteComentary>(rcoment => {
                // rcoment.Property(c => c.WorkRoute).HasComment("Campo relacional referido a un registro de ruta WorkRoute.");
                rcoment.Property(c => c.Body).HasComment("Cuerpo del comentario.");
                // rcoment.Property(c => c.User).HasComment("Campo relacional que refiere al usuario que emite el comentario.");
              rcoment.Property(c => c.Id).HasComment("Llave primaria de la entidad.");
                rcoment.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico.");
                rcoment.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro.");
                rcoment.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro.");
                rcoment.Property(c => c.UserAdded).HasComment("Usuario que creó el registro.");
                rcoment.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización.");
            });

            builder.Entity<PacientComentary>(rcoment => {
                // rcoment.Property(c => c.Pacient).HasComment("Campo relacional referido a un registro de ruta WorkRoute.");
                rcoment.Property(c => c.Body).HasComment("Cuerpo del comentario.");
                // rcoment.Property(c => c.User).HasComment("Campo relacional que refiere al usuario que emite el comentario.");
                rcoment.Property(c => c.Id).HasComment("Llave primaria de la entidad.");
                rcoment.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico.");
                rcoment.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro.");
                rcoment.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro.");
                rcoment.Property(c => c.UserAdded).HasComment("Usuario que creó el registro.");
                rcoment.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización.");
            });

            builder.Entity<MedicalIndication>(medin => {
                medin.Property(c => c.Body).HasComment("Cuerpo o descripción de registro de indicación.");
                medin.Property(c => c.Id).HasComment("Llave primaria de la entidad.");
                medin.Property(e => e.IsActive).HasComment("Propiedad de borrado lógico.");
                medin.Property(c => c.DateAdded).HasComment("Fecha en la que se agregó el registro.");
                medin.Property(c => c.DateUpdated).HasComment("Fecha de última actualización del registro.");
                medin.Property(c => c.UserAdded).HasComment("Usuario que creó el registro.");
                medin.Property(c => c.UserUpdated).HasComment("Usuario que realizó la última actualización.");
            });
        }

        // Autid Function configuration
        private void AuditDataBeforeSaving()
        {
            var currentTime = DateTimeOffset.UtcNow;
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added && e.Entity is MyEntity))
            {
                var entity = item.Entity as MyEntity;
                entity.IsActive = true;
                entity.DateAdded = currentTime;
                entity.UserAdded = gcu.GetCurrentUserName();
                entity.DateUpdated = currentTime;
                entity.UserUpdated = gcu.GetCurrentUserName();
            }

            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified && e.Entity is MyEntity))
            {
                var entity = item.Entity as MyEntity;
                entity.DateUpdated = currentTime;
                entity.UserUpdated = gcu.GetCurrentUserName();
                item.Property(nameof(entity.DateAdded)).IsModified = false;
                item.Property(nameof(entity.UserAdded)).IsModified = false;
            }
        }
    }
}