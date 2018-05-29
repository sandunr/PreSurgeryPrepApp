using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace presurgeryapp.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_patients",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "firstname",
                table: "patients");

            migrationBuilder.RenameTable(
                name: "patients",
                newName: "Patients");

            migrationBuilder.RenameColumn(
                name: "surgeryDate",
                table: "Patients",
                newName: "SurgeryDate");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Patients",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Patients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "Patients",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "patients");

            migrationBuilder.RenameColumn(
                name: "SurgeryDate",
                table: "patients",
                newName: "surgeryDate");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "patients",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "patients",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "patients",
                newName: "lastname");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "patients",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "firstname",
                table: "patients",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_patients",
                table: "patients",
                column: "id");
        }
    }
}
