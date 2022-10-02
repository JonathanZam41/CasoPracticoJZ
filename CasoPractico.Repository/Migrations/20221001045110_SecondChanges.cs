using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasoPractico.Repository.Migrations
{
    public partial class SecondChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "CLIENT",
                newName: "CLI_PHONE");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CLIENT",
                newName: "CLI_NAME");

            migrationBuilder.RenameColumn(
                name: "Identification",
                table: "CLIENT",
                newName: "CLI_IDENTIFICATION");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "CLIENT",
                newName: "CLI_GENDER");

            migrationBuilder.RenameColumn(
                name: "CLI_PASSWORD",
                table: "CLIENT",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "CLIENT",
                newName: "CLI_AGE");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "CLIENT",
                newName: "CLI_ADDRESS");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CLI_UPDATED_ON",
                table: "CLIENT",
                type: "TEXT",
                nullable: true,
                comment: "Fecha de actualizacion del registro",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldComment: "Fecha de actualizacion del registro")
                .Annotation("Relational:ColumnOrder", 10)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "CLI_UPDATED_BY",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                comment: "Usuario que actualizo el registro",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Usuario que actualizo el registro")
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<ushort>(
                name: "CLI_STATUS",
                table: "CLIENT",
                type: "INTEGER",
                nullable: false,
                comment: "Estado del cliente",
                oldClrType: typeof(ushort),
                oldType: "INTEGER",
                oldComment: "Estado del cliente")
                .Annotation("Relational:ColumnOrder", 11)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CLI_CREATED_ON",
                table: "CLIENT",
                type: "TEXT",
                nullable: false,
                comment: "Fecha de creacion del registro",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldComment: "Fecha de creacion del registro")
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "CLI_CREATED_BY",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                comment: "Usuario que creo el registro",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldComment: "Usuario que creo el registro")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "CLI_PHONE",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 15,
                nullable: false,
                comment: "Telefono del cliente",
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "CLI_NAME",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                comment: "Nombre de Cliente",
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "CLI_IDENTIFICATION",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 15,
                nullable: false,
                comment: "Identificacion de Cliente",
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "CLI_GENDER",
                table: "CLIENT",
                type: "INTEGER",
                nullable: false,
                comment: "Genero de Cliente",
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "CLIENT",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 20,
                oldComment: "Contrasenia del cliente")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "CLI_AGE",
                table: "CLIENT",
                type: "INTEGER",
                nullable: false,
                comment: "Edad de Cliente",
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "CLI_ADDRESS",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                comment: "Direccion de Cliente",
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "CLIENT",
                newName: "CLI_PASSWORD");

            migrationBuilder.RenameColumn(
                name: "CLI_PHONE",
                table: "CLIENT",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "CLI_NAME",
                table: "CLIENT",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CLI_IDENTIFICATION",
                table: "CLIENT",
                newName: "Identification");

            migrationBuilder.RenameColumn(
                name: "CLI_GENDER",
                table: "CLIENT",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "CLI_AGE",
                table: "CLIENT",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "CLI_ADDRESS",
                table: "CLIENT",
                newName: "Address");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CLI_UPDATED_ON",
                table: "CLIENT",
                type: "TEXT",
                nullable: true,
                comment: "Fecha de actualizacion del registro",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldComment: "Fecha de actualizacion del registro")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "CLI_UPDATED_BY",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                comment: "Usuario que actualizo el registro",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Usuario que actualizo el registro")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<ushort>(
                name: "CLI_STATUS",
                table: "CLIENT",
                type: "INTEGER",
                nullable: false,
                comment: "Estado del cliente",
                oldClrType: typeof(ushort),
                oldType: "INTEGER",
                oldComment: "Estado del cliente")
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CLI_CREATED_ON",
                table: "CLIENT",
                type: "TEXT",
                nullable: false,
                comment: "Fecha de creacion del registro",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldComment: "Fecha de creacion del registro")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "CLI_CREATED_BY",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                comment: "Usuario que creo el registro",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldComment: "Usuario que creo el registro")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<string>(
                name: "CLI_PASSWORD",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                comment: "Contrasenia del cliente",
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "CLIENT",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 15,
                oldComment: "Telefono del cliente")
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CLIENT",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 20,
                oldComment: "Nombre de Cliente")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Identification",
                table: "CLIENT",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 15,
                oldComment: "Identificacion de Cliente")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "CLIENT",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldComment: "Genero de Cliente")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "CLIENT",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldComment: "Edad de Cliente")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "Address",
                table: "CLIENT",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50,
                oldComment: "Direccion de Cliente")
                .OldAnnotation("Relational:ColumnOrder", 5);
        }
    }
}
