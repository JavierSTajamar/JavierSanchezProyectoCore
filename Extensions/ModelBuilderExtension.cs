using JavierSanchezProyectoCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            // Crear roles
            List<IdentityRole> roles = new List<IdentityRole>() {
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Desarrolladora", NormalizedName = "DESARROLLADORA" },
                new IdentityRole { Name = "Cliente", NormalizedName = "Cliente" }
            };
            builder.Entity<IdentityRole>().HasData(roles);
            // Crear usuarios
            List<ApplicationUser> users = new List<ApplicationUser>() {
                new ApplicationUser { UserName = "admin@gmail.com", NormalizedUserName = "ADMIN@GMAIL.COM", Email = "admin@gmail.com", NormalizedEmail = "ADMIN@GMAIL.COM" },
                new ApplicationUser { UserName = "bandai@gmail.com", NormalizedUserName = "BANDAI@GMAIL.COM", Email = "bandai@gmail.com", NormalizedEmail = "BANDAI@GMAIL.COM" },
                new ApplicationUser { UserName = "cliente@gmail.com", NormalizedUserName = "CLIENTE@GMAIL.COM", Email = "cliente@gmail.com", NormalizedEmail = "CLIENTE@GMAIL.COM" },
            };
            builder.Entity<ApplicationUser>().HasData(users);
            // Agregar contraseña a los usuarios
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "admin");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "1234qwertY!");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "1234qwertY!");
            // Agregar roles a usuario
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
            userRoles.Add(new IdentityUserRole<string> { UserId = users[0].Id, RoleId = roles.First(q => q.Name == "Admin").Id });
            userRoles.Add(new IdentityUserRole<string> { UserId = users[1].Id, RoleId = roles.First(q => q.Name == "Desarrolladora").Id });
            userRoles.Add(new IdentityUserRole<string> { UserId = users[2].Id, RoleId = roles.First(q => q.Name == "Cliente").Id });
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            // Crear registro tabla desarrolladoras
            List<Desarrolladora> desarrolladoras = new List<Desarrolladora>() {
                new Desarrolladora() { DesarrolladoraId=1,Nombre="Bandai",Logo="Bandai.jpg",Pagina="es.bandainamcoent.eu/",UserId=users[1].Id},
               
            };
            builder.Entity<Desarrolladora>().HasData(desarrolladoras);
            //Crear registro tabla Clientes
            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente(){ ClienteId=1,Nickname="Cliente",Nombre="ClienteNombre",Apellidos="ClienteApellidos",UserId=users[2].Id}
            };
            builder.Entity<Cliente>().HasData(clientes);
            // Crear Generos
            List<Genero> generos = new List<Genero>() {
                new Genero() { GeneroId = 1 , Nombre = "Acción"},
                new Genero() { GeneroId = 2 , Nombre = "RPG"},
                new Genero() { GeneroId = 3 , Nombre = "Mundo Abierto"},
                new Genero() { GeneroId = 4 , Nombre = "Indie"},
                new Genero() { GeneroId = 5 , Nombre = "Estrategia"},
                new Genero() { GeneroId = 6 , Nombre = "Disparos"},
                new Genero() { GeneroId = 7 , Nombre = "Supervivencia"},
                new Genero() { GeneroId = 8 , Nombre = "Plataformas"},
                new Genero() { GeneroId = 9 , Nombre = "Lucha"},
                new Genero() { GeneroId = 10, Nombre = "Aventura"},
            };
            builder.Entity<Genero>().HasData(generos);
            // Crear Juegos
            List<Juego> juegos = new List<Juego>() {
                new Juego(){ JuegoId=1,Titulo="Elden Ring", Caratula="Elden Ring.jpg",Precio=59.99M,Salida=new System.DateTime(2022,02,25),Descuento=5.0M,TrailerURL="CptaXqVY6-E",DesarrolladoraId=desarrolladoras[0].DesarrolladoraId,Descripcion="El Círculo de Elden ha sido destruido y sus fragmentos se han esparcido por las tierras, formando las Grandes Runas. Algunos de estos fragmentos han caído en manos de los hijos de la reina Márika la Eterna, y la promesa de aún más poder ha corrompido a cada uno de los seis semidioses.  Las personas que viven en la tierra, solían disfrutar de la Gracia del Círculo, otorgada por el Erdtree, que se mostraba con una especie de brillo dorado en los ojos: este brillo se ha desvanecido, lo que indica la pérdida de la Gracia, y los que quedan son ahora llamados 'Sinluz'. Eres uno de ellos, un exiliado de las Tierras Intermedias, debido a la pérdida de Gracia, y ahora es tu trabajo encontrar los fragmentos, restaurar el Círculo y convertirte en el Señor del Círculo, regresando el bien a la tierra.  Las Tierras Intermedias son un vasto sistema de mundo abierto en el que puedes pasear por las seis regiones (una por jefe / semidiós):  explorando castillos, fortalezas, catacumbas, cuevas, llanuras cubiertas de hierba, pan"},
                new Juego(){ JuegoId=2,Titulo="Dark Souls III", Caratula="Dark Souls III.jpg",Precio=59.99M,Salida=new System.DateTime(2016,04,11),Descuento=75.0M,TrailerURL="_zDZYrIUgKE",DesarrolladoraId=desarrolladoras[0].DesarrolladoraId,Descripcion="Adéntrate en un universo lleno de enemigos y entornos descomunales, un mundo en ruinas en el que las llamas se están apagando. Los jugadores se sumergirán en la atmósfera épica de un mundo de oscuridad gracias a un juego más rápido y una intensidad de combate ampliada. Tanto fans como recién llegados disfrutarán de una acción gratificante y gráficos absorbentes.Solo quedan las ascuas... ¡Prepárate una vez más para sumergirte en la oscuridad!"},
                new Juego(){ JuegoId=3,Titulo="Tales of Arise", Caratula="Tales of Arise.jpg",Precio=59.99M,Salida=new System.DateTime(2021,09,10),Descuento=0.0M,TrailerURL="GlxLfb5RihU",DesarrolladoraId=desarrolladoras[0].DesarrolladoraId,Descripcion="Se cree que uno de los juegos anteriores, Tales of the Graces, ha sido una gran inspiración y esto ha infundido a este juego un énfasis en la evasión y el contraataque, lo que significa que, en combate, la delicadeza tiene prioridad sobre la fuerza bruta.  En el juego, dos planetas vecinos están atrapados en un período de siglos de explotación desigual. El único planeta: Dahna, es medieval y simple, con poca tecnología y un énfasis en lo rural y natural.  Pero la espina clavada en el costado de Dahna es Rena, un planeta que rebosa de superioridad tecnológica, que la gente de Rena no ha perdido el tiempo en utilizar para su propio beneficio. Unos 300 años antes del comienzo del juego, Rena ha esclavizado a la gente de Dahna y también ha comenzado a aprovecharse libremente de los recursos de la región. El juego comienza en el ritmo más lento de Dahna, pero se traslada a Rena, brindándote muchas oportunidades para explorar los mundos."},
                new Juego(){ JuegoId=4,Titulo="Code Vein", Caratula="Code Vein.jpg",Precio=59.99M,Salida=new System.DateTime(2019,09,27),Descuento=0.0M,TrailerURL="Ik-QCjY_sd8",DesarrolladoraId=desarrolladoras[0].DesarrolladoraId,Descripcion="La historia del juego se sitúa en un futuro post apocalíptico, donde un enorme cataclismo, conocido como las Púas de la Justicia, ha arrasado las grandes urbes que han quedado totalmente desoladas y diezmando a gran parte de la población. Alrededor de una de estas urbes, rodeada por una barrera de sangre, viven los resucitados, humanos que han sido convertidos en inmortales que tratan de sobrevivir buscando fuentes donde conseguir Perlas de Sangre para saciar su sed, la cual si se prolonga en exceso puede hacer entrar en estado de frenesí y convertirlos en perdidos, los cuales son engendros que han perdido la cordura y atacan indiscriminadamente a todo aquello que se pone a su paso. Es un proceso irreversible, con lo cual los resucitados que se convierten en perdidos están condenados a esa existencia hasta que alguien acabe con ellos." },
            };
            builder.Entity<Juego>().HasData(juegos);
            // Crear GeneroJuego
            List<GeneroJuego> generoJuegos = new List<GeneroJuego>() {
                new GeneroJuego()  { GeneroJuegoId = 1 , JuegoId = juegos[0].JuegoId, GeneroId = generos[0].GeneroId },
                new GeneroJuego()  { GeneroJuegoId = 2 , JuegoId = juegos[0].JuegoId, GeneroId = generos[2].GeneroId },
                new GeneroJuego()  { GeneroJuegoId = 3 , JuegoId = juegos[1].JuegoId, GeneroId = generos[1].GeneroId },
                new GeneroJuego()  { GeneroJuegoId = 4 , JuegoId = juegos[1].JuegoId, GeneroId = generos[0].GeneroId },
                new GeneroJuego()  { GeneroJuegoId = 5 , JuegoId = juegos[2].JuegoId, GeneroId = generos[0].GeneroId },
                new GeneroJuego()  { GeneroJuegoId = 6 , JuegoId = juegos[2].JuegoId, GeneroId = generos[9].GeneroId },
                new GeneroJuego()  { GeneroJuegoId = 7 , JuegoId = juegos[2].JuegoId, GeneroId = generos[2].GeneroId },
                new GeneroJuego()  { GeneroJuegoId = 8 , JuegoId = juegos[2].JuegoId, GeneroId = generos[9].GeneroId },

                };
            builder.Entity<GeneroJuego>().HasData(generoJuegos);


        }
    }
}

