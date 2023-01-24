 using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDPersonas.Migrations
{
    public partial class SistemaUsuarios : Migration
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

            //migrationBuilder.CreateTable(
            //    name: "categoria",
            //    columns: table => new
            //    {
            //        categoria_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__categori__DB875A4FA9C4CE7B", x => x.categoria_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "estado_horario",
            //    columns: table => new
            //    {
            //        estado_horario_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        tipo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_estado_horario", x => x.estado_horario_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "estado_reserva",
            //    columns: table => new
            //    {
            //        estado_reserva_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        tipo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_estado_reserva", x => x.estado_reserva_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "persona",
            //    columns: table => new
            //    {
            //        persona_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ci_persona = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        nombres = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        apellidos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        genero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        fecha_nacimiento = table.Column<DateTime>(type: "date", nullable: true),
            //        direccion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_persona", x => x.persona_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "proveedor",
            //    columns: table => new
            //    {
            //        proveedor_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        pagina_web = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        direccion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        teñlefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_proveedor", x => x.proveedor_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "rol",
            //    columns: table => new
            //    {
            //        rol_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nombre = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
            //        fecha_registro = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_rol", x => x.rol_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "venta",
            //    columns: table => new
            //    {
            //        venta_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        fecha_date = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
            //        descuento = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
            //        monto_final = table.Column<decimal>(type: "decimal(9,2)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__venta__B135080966F135F5", x => x.venta_id);
            //    });

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

            //migrationBuilder.CreateTable(
            //    name: "reserva",
            //    columns: table => new
            //    {
            //        reserva_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        fecha_reserva = table.Column<DateTime>(type: "date", nullable: true),
            //        duracion = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true),
            //        estado_reserva_id = table.Column<int>(type: "int", nullable: true),
            //        persona_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_reserva", x => x.reserva_id);
            //        table.ForeignKey(
            //            name: "fk_reserva_estado_reserva",
            //            column: x => x.estado_reserva_id,
            //            principalTable: "estado_reserva",
            //            principalColumn: "estado_reserva_id");
            //        table.ForeignKey(
            //            name: "fk_reserva_persona",
            //            column: x => x.persona_id,
            //            principalTable: "persona",
            //            principalColumn: "persona_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "producto",
            //    columns: table => new
            //    {
            //        producto_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        precio = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
            //        fecha = table.Column<DateTime>(type: "date", nullable: true),
            //        stock = table.Column<int>(type: "int", nullable: true),
            //        categoria_id = table.Column<int>(type: "int", nullable: true),
            //        proveedor_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_producto", x => x.producto_id);
            //        table.ForeignKey(
            //            name: "fk_producto_categoria",
            //            column: x => x.categoria_id,
            //            principalTable: "categoria",
            //            principalColumn: "categoria_id");
            //        table.ForeignKey(
            //            name: "fk_producto_proveedor",
            //            column: x => x.proveedor_id,
            //            principalTable: "proveedor",
            //            principalColumn: "proveedor_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "empleado",
            //    columns: table => new
            //    {
            //        empleado_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        clave = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        rol_id = table.Column<int>(type: "int", nullable: true),
            //        persona_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_empleado", x => x.empleado_id);
            //        table.ForeignKey(
            //            name: "FK__empleado__rol_id__5070F446",
            //            column: x => x.rol_id,
            //            principalTable: "rol",
            //            principalColumn: "rol_id");
            //        table.ForeignKey(
            //            name: "fk_empleado_persona",
            //            column: x => x.persona_id,
            //            principalTable: "persona",
            //            principalColumn: "persona_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "cliente",
            //    columns: table => new
            //    {
            //        cliente_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        reserva_id = table.Column<int>(type: "int", nullable: true),
            //        persona_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_cliente", x => x.cliente_id);
            //        table.ForeignKey(
            //            name: "fk_cliente_persona",
            //            column: x => x.persona_id,
            //            principalTable: "persona",
            //            principalColumn: "persona_id");
            //        table.ForeignKey(
            //            name: "fk_cliente_reserva",
            //            column: x => x.reserva_id,
            //            principalTable: "reserva",
            //            principalColumn: "reserva_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "horario",
            //    columns: table => new
            //    {
            //        horario_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        hora_inicio = table.Column<TimeSpan>(type: "time", nullable: true),
            //        hora_fin = table.Column<TimeSpan>(type: "time", nullable: true),
            //        reserva_id = table.Column<int>(type: "int", nullable: true),
            //        estado_horario_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_horario", x => x.horario_id);
            //        table.ForeignKey(
            //            name: "fk_horario_estado_horario",
            //            column: x => x.estado_horario_id,
            //            principalTable: "estado_horario",
            //            principalColumn: "estado_horario_id");
            //        table.ForeignKey(
            //            name: "fk_horario_reserva",
            //            column: x => x.reserva_id,
            //            principalTable: "reserva",
            //            principalColumn: "reserva_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "reserva_venta",
            //    columns: table => new
            //    {
            //        reserva_id = table.Column<int>(type: "int", nullable: true),
            //        venta_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.ForeignKey(
            //            name: "fk_reserva_venta_reserva",
            //            column: x => x.reserva_id,
            //            principalTable: "reserva",
            //            principalColumn: "reserva_id");
            //        table.ForeignKey(
            //            name: "fk_reserva_venta_venta",
            //            column: x => x.venta_id,
            //            principalTable: "venta",
            //            principalColumn: "venta_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "venta_producto",
            //    columns: table => new
            //    {
            //        venta_id = table.Column<int>(type: "int", nullable: true),
            //        producto_id = table.Column<int>(type: "int", nullable: true),
            //        cantidad = table.Column<int>(type: "int", nullable: true),
            //        precio = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
            //        monto_total = table.Column<decimal>(type: "decimal(9,2)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.ForeignKey(
            //            name: "FK__venta_pro__produ__6EF57B66",
            //            column: x => x.producto_id,
            //            principalTable: "producto",
            //            principalColumn: "producto_id");
            //        table.ForeignKey(
            //            name: "FK__venta_pro__venta__6E01572D",
            //            column: x => x.venta_id,
            //            principalTable: "venta",
            //            principalColumn: "venta_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "cancha",
            //    columns: table => new
            //    {
            //        cancha_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        estado_cancha = table.Column<bool>(type: "bit", nullable: true),
            //        horario_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_cancha", x => x.cancha_id);
            //        table.ForeignKey(
            //            name: "fk_cancha_horario",
            //            column: x => x.horario_id,
            //            principalTable: "horario",
            //            principalColumn: "horario_id");
            //    });

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
                name: "IX_cancha_horario_id",
                table: "cancha",
                column: "horario_id");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_persona_id",
                table: "cliente",
                column: "persona_id");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_reserva_id",
                table: "cliente",
                column: "reserva_id");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_persona_id",
                table: "empleado",
                column: "persona_id");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_rol_id",
                table: "empleado",
                column: "rol_id");

            migrationBuilder.CreateIndex(
                name: "IX_horario_estado_horario_id",
                table: "horario",
                column: "estado_horario_id");

            migrationBuilder.CreateIndex(
                name: "IX_horario_reserva_id",
                table: "horario",
                column: "reserva_id");

            migrationBuilder.CreateIndex(
                name: "IX_producto_categoria_id",
                table: "producto",
                column: "categoria_id");

            migrationBuilder.CreateIndex(
                name: "IX_producto_proveedor_id",
                table: "producto",
                column: "proveedor_id");

            migrationBuilder.CreateIndex(
                name: "IX_reserva_estado_reserva_id",
                table: "reserva",
                column: "estado_reserva_id");

            migrationBuilder.CreateIndex(
                name: "IX_reserva_persona_id",
                table: "reserva",
                column: "persona_id");

            migrationBuilder.CreateIndex(
                name: "IX_reserva_venta_reserva_id",
                table: "reserva_venta",
                column: "reserva_id");

            migrationBuilder.CreateIndex(
                name: "IX_reserva_venta_venta_id",
                table: "reserva_venta",
                column: "venta_id");

            migrationBuilder.CreateIndex(
                name: "IX_venta_producto_producto_id",
                table: "venta_producto",
                column: "producto_id");

            migrationBuilder.CreateIndex(
                name: "IX_venta_producto_venta_id",
                table: "venta_producto",
                column: "venta_id");
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

            //migrationBuilder.DropTable(
            //    name: "cancha");

            //migrationBuilder.DropTable(
            //    name: "cliente");

            //migrationBuilder.DropTable(
            //    name: "empleado");

            //migrationBuilder.DropTable(
            //    name: "reserva_venta");

            //migrationBuilder.DropTable(
            //    name: "venta_producto");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            //migrationBuilder.DropTable(
            //    name: "horario");

            //migrationBuilder.DropTable(
            //    name: "rol");

            //migrationBuilder.DropTable(
            //    name: "producto");

            //migrationBuilder.DropTable(
            //    name: "venta");

            //migrationBuilder.DropTable(
            //    name: "estado_horario");

            //migrationBuilder.DropTable(
            //    name: "reserva");

            //migrationBuilder.DropTable(
            //    name: "categoria");

            //migrationBuilder.DropTable(
            //    name: "proveedor");

            //migrationBuilder.DropTable(
            //    name: "estado_reserva");

            //migrationBuilder.DropTable(
            //    name: "persona");
        }
    }
}
