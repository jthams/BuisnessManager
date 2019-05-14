using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class added_Organization_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Personnel_PersonnelId",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "Personnel");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_PersonnelId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "PersonnelId",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "Employeess",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Clients",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employeess_EmployerId",
                table: "Employeess",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_OrganizationId",
                table: "Clients",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Organization_OrganizationId",
                table: "Clients",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employeess_Organization_EmployerId",
                table: "Employeess",
                column: "EmployerId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Organization_OrganizationId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Employeess_Organization_EmployerId",
                table: "Employeess");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_Employeess_EmployerId",
                table: "Employeess");

            migrationBuilder.DropIndex(
                name: "IX_Clients_OrganizationId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "Employeess");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "PersonnelId",
                table: "Invoices",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PersonnelId",
                table: "Invoices",
                column: "PersonnelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Personnel_PersonnelId",
                table: "Invoices",
                column: "PersonnelId",
                principalTable: "Personnel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
