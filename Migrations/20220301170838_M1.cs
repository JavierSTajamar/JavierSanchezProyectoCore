using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JavierSanchezProyectoCore.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.GeneroId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Desarrolladoras",
                columns: table => new
                {
                    DesarrolladoraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pagina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desarrolladoras", x => x.DesarrolladoraId);
                    table.ForeignKey(
                        name: "FK_Desarrolladoras_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrecioTotal = table.Column<double>(type: "float", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Juegos",
                columns: table => new
                {
                    JuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Caratula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descuento = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrailerURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesarrolladoraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.JuegoId);
                    table.ForeignKey(
                        name: "FK_Juegos_Desarrolladoras_DesarrolladoraId",
                        column: x => x.DesarrolladoraId,
                        principalTable: "Desarrolladoras",
                        principalColumn: "DesarrolladoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVentas",
                columns: table => new
                {
                    DetalleVentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    JuegoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVentas", x => x.DetalleVentaId);
                    table.ForeignKey(
                        name: "FK_DetalleVentas_Juegos_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juegos",
                        principalColumn: "JuegoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVentas_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerosJuegos",
                columns: table => new
                {
                    GeneroJuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    JuegoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerosJuegos", x => x.GeneroJuegoId);
                    table.ForeignKey(
                        name: "FK_GenerosJuegos_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerosJuegos_Juegos_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juegos",
                        principalColumn: "JuegoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59e7f06b-3619-4c1a-8a61-ca9ae72c7137", "d0509952-8948-49d2-aec6-256aa48b3c6e", "Admin", "ADMIN" },
                    { "70636bd0-eae7-41d6-a264-f1dfafa5c6bc", "b90a4b0f-9b7e-4694-9796-b15079844e22", "Desarrolladora", "DESARROLLADORA" },
                    { "4eb85671-7bf3-43bf-9af8-ef86aa9b39ac", "d69fcf15-887c-423a-b96e-c1cc899bfe35", "Cliente", "Cliente" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8bf3a85d-4967-448a-897f-0ac92e3c0a33", 0, "a687d2ce-8df2-45b0-95e1-c1dff2dfae35", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK1/MKRdSCGN6SnZ7Wl47MMlqSSM90dBnodwh/wXE6Bu7LKAkqaMkDHgJsAweZwtYA==", null, false, "476fd0b2-ed39-4d8e-9056-74ce26aeb5de", false, "admin@gmail.com" },
                    { "9ff82e24-7219-424c-9f85-f58270518167", 0, "26091f49-0955-4ba2-9127-a8b73cf7d68a", "bandai@gmail.com", false, false, null, "BANDAI@GMAIL.COM", "BANDAI@GMAIL.COM", "AQAAAAEAACcQAAAAEHzACA9+k5n20T/6j7JwyyxMjGMLWRsqFVAK0O0qfJ+3UM9zyvgTAvgHdvLxoJDqlQ==", null, false, "aaaa5af7-9fe5-4078-8ce3-c60eb930802d", false, "bandai@gmail.com" },
                    { "cab909df-9dec-4ca4-98b2-6695cf6badc7", 0, "fb8fcd14-92d2-4f2f-a5f5-77a586314362", "cliente@gmail.com", false, false, null, "CLIENTE@GMAIL.COM", "CLIENTE@GMAIL.COM", "AQAAAAEAACcQAAAAELjzUlnn6xjydF+Qmua3ErszOixbdwphLn40gglg1gba0jOI3645+BJa+OieXea5+Q==", null, false, "0a6ec95e-a0c8-4dc3-a35d-4ffcc1cb9fac", false, "cliente@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "GeneroId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Acción" },
                    { 2, "RPG" },
                    { 3, "Mundo Abierto" },
                    { 4, "Indie" },
                    { 5, "Estrategia" },
                    { 6, "Disparos" },
                    { 7, "Supervivencia" },
                    { 8, "Plataformas" },
                    { 9, "Lucha" },
                    { 10, "Aventura" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "59e7f06b-3619-4c1a-8a61-ca9ae72c7137", "8bf3a85d-4967-448a-897f-0ac92e3c0a33" },
                    { "70636bd0-eae7-41d6-a264-f1dfafa5c6bc", "9ff82e24-7219-424c-9f85-f58270518167" },
                    { "4eb85671-7bf3-43bf-9af8-ef86aa9b39ac", "cab909df-9dec-4ca4-98b2-6695cf6badc7" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Apellidos", "Nickname", "Nombre", "UserId" },
                values: new object[] { 1, "ClienteApellidos", "Cliente", "ClienteNombre", "cab909df-9dec-4ca4-98b2-6695cf6badc7" });

            migrationBuilder.InsertData(
                table: "Desarrolladoras",
                columns: new[] { "DesarrolladoraId", "Logo", "Nombre", "Pagina", "UserId" },
                values: new object[] { 1, "Bandai.jpg", "Bandai", "es.bandainamcoent.eu/", "9ff82e24-7219-424c-9f85-f58270518167" });

            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "JuegoId", "Caratula", "DesarrolladoraId", "Descripcion", "Descuento", "Precio", "Salida", "Titulo", "TrailerURL" },
                values: new object[,]
                {
                    { 1, "Elden Ring.jpg", 1, "El Círculo de Elden ha sido destruido y sus fragmentos se han esparcido por las tierras, formando las Grandes Runas. Algunos de estos fragmentos han caído en manos de los hijos de la reina Márika la Eterna, y la promesa de aún más poder ha corrompido a cada uno de los seis semidioses.  Las personas que viven en la tierra, solían disfrutar de la Gracia del Círculo, otorgada por el Erdtree, que se mostraba con una especie de brillo dorado en los ojos: este brillo se ha desvanecido, lo que indica la pérdida de la Gracia, y los que quedan son ahora llamados 'Sinluz'. Eres uno de ellos, un exiliado de las Tierras Intermedias, debido a la pérdida de Gracia, y ahora es tu trabajo encontrar los fragmentos, restaurar el Círculo y convertirte en el Señor del Círculo, regresando el bien a la tierra.  Las Tierras Intermedias son un vasto sistema de mundo abierto en el que puedes pasear por las seis regiones (una por jefe / semidiós):  explorando castillos, fortalezas, catacumbas, cuevas, llanuras cubiertas de hierba, pan", 5.0m, 59.99m, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elden Ring", "CptaXqVY6-E" },
                    { 2, "Dark Souls III.jpg", 1, "Adéntrate en un universo lleno de enemigos y entornos descomunales, un mundo en ruinas en el que las llamas se están apagando. Los jugadores se sumergirán en la atmósfera épica de un mundo de oscuridad gracias a un juego más rápido y una intensidad de combate ampliada. Tanto fans como recién llegados disfrutarán de una acción gratificante y gráficos absorbentes.Solo quedan las ascuas... ¡Prepárate una vez más para sumergirte en la oscuridad!", 75.0m, 59.99m, new DateTime(2016, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Souls III", "_zDZYrIUgKE" },
                    { 3, "Tales of Arise.jpg", 1, "Se cree que uno de los juegos anteriores, Tales of the Graces, ha sido una gran inspiración y esto ha infundido a este juego un énfasis en la evasión y el contraataque, lo que significa que, en combate, la delicadeza tiene prioridad sobre la fuerza bruta.  En el juego, dos planetas vecinos están atrapados en un período de siglos de explotación desigual. El único planeta: Dahna, es medieval y simple, con poca tecnología y un énfasis en lo rural y natural.  Pero la espina clavada en el costado de Dahna es Rena, un planeta que rebosa de superioridad tecnológica, que la gente de Rena no ha perdido el tiempo en utilizar para su propio beneficio. Unos 300 años antes del comienzo del juego, Rena ha esclavizado a la gente de Dahna y también ha comenzado a aprovecharse libremente de los recursos de la región. El juego comienza en el ritmo más lento de Dahna, pero se traslada a Rena, brindándote muchas oportunidades para explorar los mundos.", 0.0m, 59.99m, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tales of Arise", "GlxLfb5RihU" },
                    { 4, "Code Vein.jpg", 1, "La historia del juego se sitúa en un futuro post apocalíptico, donde un enorme cataclismo, conocido como las Púas de la Justicia, ha arrasado las grandes urbes que han quedado totalmente desoladas y diezmando a gran parte de la población. Alrededor de una de estas urbes, rodeada por una barrera de sangre, viven los resucitados, humanos que han sido convertidos en inmortales que tratan de sobrevivir buscando fuentes donde conseguir Perlas de Sangre para saciar su sed, la cual si se prolonga en exceso puede hacer entrar en estado de frenesí y convertirlos en perdidos, los cuales son engendros que han perdido la cordura y atacan indiscriminadamente a todo aquello que se pone a su paso. Es un proceso irreversible, con lo cual los resucitados que se convierten en perdidos están condenados a esa existencia hasta que alguien acabe con ellos.", 0.0m, 59.99m, new DateTime(2019, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Code Vein", "Ik-QCjY_sd8" }
                });

            migrationBuilder.InsertData(
                table: "GenerosJuegos",
                columns: new[] { "GeneroJuegoId", "GeneroId", "JuegoId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 2, 2 },
                    { 4, 1, 2 },
                    { 5, 1, 3 },
                    { 6, 10, 3 },
                    { 7, 3, 3 },
                    { 8, 10, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_UserId",
                table: "Clientes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Desarrolladoras_UserId",
                table: "Desarrolladoras",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_JuegoId",
                table: "DetalleVentas",
                column: "JuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_VentaId",
                table: "DetalleVentas",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerosJuegos_GeneroId",
                table: "GenerosJuegos",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerosJuegos_JuegoId",
                table: "GenerosJuegos",
                column: "JuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_DesarrolladoraId",
                table: "Juegos",
                column: "DesarrolladoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DetalleVentas");

            migrationBuilder.DropTable(
                name: "GenerosJuegos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Juegos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Desarrolladoras");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
