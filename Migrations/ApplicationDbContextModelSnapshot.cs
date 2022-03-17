﻿// <auto-generated />
using System;
using JavierSanchezProyectoCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JavierSanchezProyectoCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "8bf3a85d-4967-448a-897f-0ac92e3c0a33",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a687d2ce-8df2-45b0-95e1-c1dff2dfae35",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEK1/MKRdSCGN6SnZ7Wl47MMlqSSM90dBnodwh/wXE6Bu7LKAkqaMkDHgJsAweZwtYA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "476fd0b2-ed39-4d8e-9056-74ce26aeb5de",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "9ff82e24-7219-424c-9f85-f58270518167",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "26091f49-0955-4ba2-9127-a8b73cf7d68a",
                            Email = "bandai@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BANDAI@GMAIL.COM",
                            NormalizedUserName = "BANDAI@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHzACA9+k5n20T/6j7JwyyxMjGMLWRsqFVAK0O0qfJ+3UM9zyvgTAvgHdvLxoJDqlQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aaaa5af7-9fe5-4078-8ce3-c60eb930802d",
                            TwoFactorEnabled = false,
                            UserName = "bandai@gmail.com"
                        },
                        new
                        {
                            Id = "cab909df-9dec-4ca4-98b2-6695cf6badc7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fb8fcd14-92d2-4f2f-a5f5-77a586314362",
                            Email = "cliente@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENTE@GMAIL.COM",
                            NormalizedUserName = "CLIENTE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELjzUlnn6xjydF+Qmua3ErszOixbdwphLn40gglg1gba0jOI3645+BJa+OieXea5+Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0a6ec95e-a0c8-4dc3-a35d-4ffcc1cb9fac",
                            TwoFactorEnabled = false,
                            UserName = "cliente@gmail.com"
                        });
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ClienteId");

                    b.HasIndex("UserId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Apellidos = "ClienteApellidos",
                            Nickname = "Cliente",
                            Nombre = "ClienteNombre",
                            UserId = "cab909df-9dec-4ca4-98b2-6695cf6badc7"
                        });
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.Desarrolladora", b =>
                {
                    b.Property<int>("DesarrolladoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pagina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DesarrolladoraId");

                    b.HasIndex("UserId");

                    b.ToTable("Desarrolladoras");

                    b.HasData(
                        new
                        {
                            DesarrolladoraId = 1,
                            Logo = "Bandai.jpg",
                            Nombre = "Bandai",
                            Pagina = "es.bandainamcoent.eu/",
                            UserId = "9ff82e24-7219-424c-9f85-f58270518167"
                        });
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.DetalleVenta", b =>
                {
                    b.Property<int>("DetalleVentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JuegoId")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("DetalleVentaId");

                    b.HasIndex("JuegoId");

                    b.HasIndex("VentaId");

                    b.ToTable("DetalleVentas");
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeneroId");

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            GeneroId = 1,
                            Nombre = "Acción"
                        },
                        new
                        {
                            GeneroId = 2,
                            Nombre = "RPG"
                        },
                        new
                        {
                            GeneroId = 3,
                            Nombre = "Mundo Abierto"
                        },
                        new
                        {
                            GeneroId = 4,
                            Nombre = "Indie"
                        },
                        new
                        {
                            GeneroId = 5,
                            Nombre = "Estrategia"
                        },
                        new
                        {
                            GeneroId = 6,
                            Nombre = "Disparos"
                        },
                        new
                        {
                            GeneroId = 7,
                            Nombre = "Supervivencia"
                        },
                        new
                        {
                            GeneroId = 8,
                            Nombre = "Plataformas"
                        },
                        new
                        {
                            GeneroId = 9,
                            Nombre = "Lucha"
                        },
                        new
                        {
                            GeneroId = 10,
                            Nombre = "Aventura"
                        });
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.GeneroJuego", b =>
                {
                    b.Property<int>("GeneroJuegoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int>("JuegoId")
                        .HasColumnType("int");

                    b.HasKey("GeneroJuegoId");

                    b.HasIndex("GeneroId");

                    b.HasIndex("JuegoId");

                    b.ToTable("GenerosJuegos");

                    b.HasData(
                        new
                        {
                            GeneroJuegoId = 1,
                            GeneroId = 1,
                            JuegoId = 1
                        },
                        new
                        {
                            GeneroJuegoId = 2,
                            GeneroId = 3,
                            JuegoId = 1
                        },
                        new
                        {
                            GeneroJuegoId = 3,
                            GeneroId = 2,
                            JuegoId = 2
                        },
                        new
                        {
                            GeneroJuegoId = 4,
                            GeneroId = 1,
                            JuegoId = 2
                        },
                        new
                        {
                            GeneroJuegoId = 5,
                            GeneroId = 1,
                            JuegoId = 3
                        },
                        new
                        {
                            GeneroJuegoId = 6,
                            GeneroId = 10,
                            JuegoId = 3
                        },
                        new
                        {
                            GeneroJuegoId = 7,
                            GeneroId = 3,
                            JuegoId = 3
                        },
                        new
                        {
                            GeneroJuegoId = 8,
                            GeneroId = 10,
                            JuegoId = 3
                        });
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.Juego", b =>
                {
                    b.Property<int>("JuegoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caratula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DesarrolladoraId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Descuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Salida")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailerURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JuegoId");

                    b.HasIndex("DesarrolladoraId");

                    b.ToTable("Juegos");

                    b.HasData(
                        new
                        {
                            JuegoId = 1,
                            Caratula = "Elden Ring.jpg",
                            DesarrolladoraId = 1,
                            Descripcion = "El Círculo de Elden ha sido destruido y sus fragmentos se han esparcido por las tierras, formando las Grandes Runas. Algunos de estos fragmentos han caído en manos de los hijos de la reina Márika la Eterna, y la promesa de aún más poder ha corrompido a cada uno de los seis semidioses.  Las personas que viven en la tierra, solían disfrutar de la Gracia del Círculo, otorgada por el Erdtree, que se mostraba con una especie de brillo dorado en los ojos: este brillo se ha desvanecido, lo que indica la pérdida de la Gracia, y los que quedan son ahora llamados 'Sinluz'. Eres uno de ellos, un exiliado de las Tierras Intermedias, debido a la pérdida de Gracia, y ahora es tu trabajo encontrar los fragmentos, restaurar el Círculo y convertirte en el Señor del Círculo, regresando el bien a la tierra.  Las Tierras Intermedias son un vasto sistema de mundo abierto en el que puedes pasear por las seis regiones (una por jefe / semidiós):  explorando castillos, fortalezas, catacumbas, cuevas, llanuras cubiertas de hierba, pan",
                            Descuento = 5.0m,
                            Precio = 59.99m,
                            Salida = new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Elden Ring",
                            TrailerURL = "CptaXqVY6-E"
                        },
                        new
                        {
                            JuegoId = 2,
                            Caratula = "Dark Souls III.jpg",
                            DesarrolladoraId = 1,
                            Descripcion = "Adéntrate en un universo lleno de enemigos y entornos descomunales, un mundo en ruinas en el que las llamas se están apagando. Los jugadores se sumergirán en la atmósfera épica de un mundo de oscuridad gracias a un juego más rápido y una intensidad de combate ampliada. Tanto fans como recién llegados disfrutarán de una acción gratificante y gráficos absorbentes.Solo quedan las ascuas... ¡Prepárate una vez más para sumergirte en la oscuridad!",
                            Descuento = 75.0m,
                            Precio = 59.99m,
                            Salida = new DateTime(2016, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Dark Souls III",
                            TrailerURL = "_zDZYrIUgKE"
                        },
                        new
                        {
                            JuegoId = 3,
                            Caratula = "Tales of Arise.jpg",
                            DesarrolladoraId = 1,
                            Descripcion = "Se cree que uno de los juegos anteriores, Tales of the Graces, ha sido una gran inspiración y esto ha infundido a este juego un énfasis en la evasión y el contraataque, lo que significa que, en combate, la delicadeza tiene prioridad sobre la fuerza bruta.  En el juego, dos planetas vecinos están atrapados en un período de siglos de explotación desigual. El único planeta: Dahna, es medieval y simple, con poca tecnología y un énfasis en lo rural y natural.  Pero la espina clavada en el costado de Dahna es Rena, un planeta que rebosa de superioridad tecnológica, que la gente de Rena no ha perdido el tiempo en utilizar para su propio beneficio. Unos 300 años antes del comienzo del juego, Rena ha esclavizado a la gente de Dahna y también ha comenzado a aprovecharse libremente de los recursos de la región. El juego comienza en el ritmo más lento de Dahna, pero se traslada a Rena, brindándote muchas oportunidades para explorar los mundos.",
                            Descuento = 0.0m,
                            Precio = 59.99m,
                            Salida = new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Tales of Arise",
                            TrailerURL = "GlxLfb5RihU"
                        },
                        new
                        {
                            JuegoId = 4,
                            Caratula = "Code Vein.jpg",
                            DesarrolladoraId = 1,
                            Descripcion = "La historia del juego se sitúa en un futuro post apocalíptico, donde un enorme cataclismo, conocido como las Púas de la Justicia, ha arrasado las grandes urbes que han quedado totalmente desoladas y diezmando a gran parte de la población. Alrededor de una de estas urbes, rodeada por una barrera de sangre, viven los resucitados, humanos que han sido convertidos en inmortales que tratan de sobrevivir buscando fuentes donde conseguir Perlas de Sangre para saciar su sed, la cual si se prolonga en exceso puede hacer entrar en estado de frenesí y convertirlos en perdidos, los cuales son engendros que han perdido la cordura y atacan indiscriminadamente a todo aquello que se pone a su paso. Es un proceso irreversible, con lo cual los resucitados que se convierten en perdidos están condenados a esa existencia hasta que alguien acabe con ellos.",
                            Descuento = 0.0m,
                            Precio = 59.99m,
                            Salida = new DateTime(2019, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Code Vein",
                            TrailerURL = "Ik-QCjY_sd8"
                        });
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.Venta", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<double>("PrecioTotal")
                        .HasColumnType("float");

                    b.HasKey("VentaId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "59e7f06b-3619-4c1a-8a61-ca9ae72c7137",
                            ConcurrencyStamp = "d0509952-8948-49d2-aec6-256aa48b3c6e",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "70636bd0-eae7-41d6-a264-f1dfafa5c6bc",
                            ConcurrencyStamp = "b90a4b0f-9b7e-4694-9796-b15079844e22",
                            Name = "Desarrolladora",
                            NormalizedName = "DESARROLLADORA"
                        },
                        new
                        {
                            Id = "4eb85671-7bf3-43bf-9af8-ef86aa9b39ac",
                            ConcurrencyStamp = "d69fcf15-887c-423a-b96e-c1cc899bfe35",
                            Name = "Cliente",
                            NormalizedName = "Cliente"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "8bf3a85d-4967-448a-897f-0ac92e3c0a33",
                            RoleId = "59e7f06b-3619-4c1a-8a61-ca9ae72c7137"
                        },
                        new
                        {
                            UserId = "9ff82e24-7219-424c-9f85-f58270518167",
                            RoleId = "70636bd0-eae7-41d6-a264-f1dfafa5c6bc"
                        },
                        new
                        {
                            UserId = "cab909df-9dec-4ca4-98b2-6695cf6badc7",
                            RoleId = "4eb85671-7bf3-43bf-9af8-ef86aa9b39ac"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.Cliente", b =>
                {
                    b.HasOne("JavierSanchezProyectoCore.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.Desarrolladora", b =>
                {
                    b.HasOne("JavierSanchezProyectoCore.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.DetalleVenta", b =>
                {
                    b.HasOne("JavierSanchezProyectoCore.Models.Juego", "Juego")
                        .WithMany()
                        .HasForeignKey("JuegoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JavierSanchezProyectoCore.Models.Venta", "Venta")
                        .WithMany()
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Juego");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.GeneroJuego", b =>
                {
                    b.HasOne("JavierSanchezProyectoCore.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JavierSanchezProyectoCore.Models.Juego", "Juego")
                        .WithMany("GenerosJuego")
                        .HasForeignKey("JuegoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Juego");
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.Juego", b =>
                {
                    b.HasOne("JavierSanchezProyectoCore.Models.Desarrolladora", "Desarrolladora")
                        .WithMany()
                        .HasForeignKey("DesarrolladoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desarrolladora");
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.Venta", b =>
                {
                    b.HasOne("JavierSanchezProyectoCore.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("JavierSanchezProyectoCore.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("JavierSanchezProyectoCore.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JavierSanchezProyectoCore.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("JavierSanchezProyectoCore.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JavierSanchezProyectoCore.Models.Juego", b =>
                {
                    b.Navigation("GenerosJuego");
                });
#pragma warning restore 612, 618
        }
    }
}
