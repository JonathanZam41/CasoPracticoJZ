using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasoPractico.Repository.Migrations
{
    public partial class v3_1_10_2022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MOV_ACCOUNT_ID",
                table: "MOVIMENT",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                comment: "Id de cuenta")
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<string>(
                name: "CLI_PHONE",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 15,
                nullable: true,
                comment: "Telefono del cliente",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 15,
                oldComment: "Telefono del cliente");

            migrationBuilder.AlterColumn<int>(
                name: "CLI_GENDER",
                table: "CLIENT",
                type: "INTEGER",
                nullable: true,
                comment: "Genero de Cliente",
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldComment: "Genero de Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "CLI_ADDRESS",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 50,
                nullable: true,
                comment: "Direccion de Cliente",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50,
                oldComment: "Direccion de Cliente");

            migrationBuilder.AddColumn<int>(
                name: "ACC_CLIENT_ID",
                table: "ACCOUNT",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                comment: "Id de cliente")
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.CreateIndex(
                name: "IDX_UNIQUE_TIP_ID_CLI_ID_NUMBER",
                table: "MOVIMENT",
                column: "MOV_ACCOUNT_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ACCOUNT_ACC_CLIENT_ID",
                table: "ACCOUNT",
                column: "ACC_CLIENT_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ACC_CLIENT_ID",
                table: "ACCOUNT",
                column: "ACC_CLIENT_ID",
                principalTable: "CLIENT",
                principalColumn: "CLI_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MOV_ACCOUNT_ID",
                table: "MOVIMENT",
                column: "MOV_ACCOUNT_ID",
                principalTable: "ACCOUNT",
                principalColumn: "ACC_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ACC_CLIENT_ID",
                table: "ACCOUNT");

            migrationBuilder.DropForeignKey(
                name: "FK_MOV_ACCOUNT_ID",
                table: "MOVIMENT");

            migrationBuilder.DropIndex(
                name: "IDX_UNIQUE_TIP_ID_CLI_ID_NUMBER",
                table: "MOVIMENT");

            migrationBuilder.DropIndex(
                name: "IX_ACCOUNT_ACC_CLIENT_ID",
                table: "ACCOUNT");

            migrationBuilder.DropColumn(
                name: "MOV_ACCOUNT_ID",
                table: "MOVIMENT");

            migrationBuilder.DropColumn(
                name: "ACC_CLIENT_ID",
                table: "ACCOUNT");

            migrationBuilder.AlterColumn<string>(
                name: "CLI_PHONE",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                comment: "Telefono del cliente",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 15,
                oldNullable: true,
                oldComment: "Telefono del cliente");

            migrationBuilder.AlterColumn<int>(
                name: "CLI_GENDER",
                table: "CLIENT",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                comment: "Genero de Cliente",
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true,
                oldComment: "Genero de Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "CLI_ADDRESS",
                table: "CLIENT",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Direccion de Cliente",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "Direccion de Cliente");
        }
    }
}
