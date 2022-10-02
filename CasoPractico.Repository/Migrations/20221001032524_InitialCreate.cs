using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasoPractico.Repository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACCOUNT",
                columns: table => new
                {
                    ACC_ID = table.Column<int>(type: "INTEGER", nullable: false, comment: "Id de la cuenta")
                        .Annotation("Sqlite:Autoincrement", true),
                    ACC_NUMBER = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false, comment: "Numero de cuenta"),
                    ACC_TYPE = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false, comment: "Tipo de cuenta"),
                    ACC_INITIAL_BALANCE = table.Column<decimal>(type: "TEXT", nullable: false, comment: "Saldo inicial"),
                    ACC_CREATED_BY = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false, comment: "Usuario que creo el registro"),
                    ACC_CREATED_ON = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "Fecha de creacion del registro"),
                    ACC_UPDATED_BY = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true, comment: "Usuario que actualizo el registro"),
                    ACC_UPDATED_ON = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "Fecha de actualizacion del registro"),
                    ACC_STATUS = table.Column<ushort>(type: "INTEGER", nullable: false, comment: "Estado de la cuenta")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCOUNT", x => x.ACC_ID);
                });

            migrationBuilder.CreateTable(
                name: "CLIENT",
                columns: table => new
                {
                    CLI_ID = table.Column<int>(type: "INTEGER", nullable: false, comment: "Id de Cliente")
                        .Annotation("Sqlite:Autoincrement", true),
                    CLI_PASSWORD = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false, comment: "Contrasenia del cliente"),
                    CLI_CREATED_BY = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false, comment: "Usuario que creo el registro"),
                    CLI_CREATED_ON = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "Fecha de creacion del registro"),
                    CLI_UPDATED_BY = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true, comment: "Usuario que actualizo el registro"),
                    CLI_UPDATED_ON = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "Fecha de actualizacion del registro"),
                    CLI_STATUS = table.Column<ushort>(type: "INTEGER", nullable: false, comment: "Estado del cliente"),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Identification = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<int>(type: "INTEGER", nullable: false),
                    Phone = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT", x => x.CLI_ID);
                });

            migrationBuilder.CreateTable(
                name: "MOVIMENT",
                columns: table => new
                {
                    MOV_ID = table.Column<int>(type: "INTEGER", nullable: false, comment: "Id de movimiento")
                        .Annotation("Sqlite:Autoincrement", true),
                    MOV_DATE = table.Column<DateTime>(type: "TEXT", maxLength: 20, nullable: false, comment: "Fecha de movimiento"),
                    MOV_TYPE = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false, comment: "Tipo de movimiento"),
                    MOV_VALUE = table.Column<decimal>(type: "TEXT", maxLength: 14, nullable: false, comment: "Valor de movimiento"),
                    MOV_BALANCE = table.Column<decimal>(type: "TEXT", maxLength: 14, nullable: false, comment: "Saldo restante"),
                    MOV_CREATED_BY = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false, comment: "Usuario que creo el registro"),
                    MOV_CREATED_ON = table.Column<DateTime>(type: "TEXT", nullable: false, comment: "Fecha de creacion del registro"),
                    MOV_UPDATED_BY = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true, comment: "Usuario que actualizo el registro"),
                    MOV_UPDATED_ON = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "Fecha de actualizacion del registro"),
                    Status = table.Column<ushort>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOVIMENT", x => x.MOV_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCOUNT");

            migrationBuilder.DropTable(
                name: "CLIENT");

            migrationBuilder.DropTable(
                name: "MOVIMENT");
        }
    }
}
