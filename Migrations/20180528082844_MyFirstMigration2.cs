using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace presurgeryapp.Migrations
{
    public partial class MyFirstMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PatientResponse",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurgeryType",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextMessage1",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TextSent",
                table: "Patients",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientResponse",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SurgeryType",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "TextMessage1",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "TextSent",
                table: "Patients");
        }
    }
}
