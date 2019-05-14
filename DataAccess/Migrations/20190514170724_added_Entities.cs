using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class added_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Organization_OrganizationId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Employeess_Organization_EmployerId",
                table: "Employeess");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Organization_OrganizationId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_Invoices_InvoiceId",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkDay_Employeess_EmployeeId",
                table: "WorkDay");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkDay_Organization_OrganizationId",
                table: "WorkDay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkDay",
                table: "WorkDay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resource",
                table: "Resource");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organization",
                table: "Organization");

            migrationBuilder.RenameTable(
                name: "WorkDay",
                newName: "Workdays");

            migrationBuilder.RenameTable(
                name: "Resource",
                newName: "Resources");

            migrationBuilder.RenameTable(
                name: "Organization",
                newName: "Organizations");

            migrationBuilder.RenameIndex(
                name: "IX_WorkDay_OrganizationId",
                table: "Workdays",
                newName: "IX_Workdays_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkDay_EmployeeId",
                table: "Workdays",
                newName: "IX_Workdays_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Resource_InvoiceId",
                table: "Resources",
                newName: "IX_Resources_InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workdays",
                table: "Workdays",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resources",
                table: "Resources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Organizations_OrganizationId",
                table: "Clients",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employeess_Organizations_EmployerId",
                table: "Employeess",
                column: "EmployerId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Organizations_OrganizationId",
                table: "Projects",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Invoices_InvoiceId",
                table: "Resources",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workdays_Employeess_EmployeeId",
                table: "Workdays",
                column: "EmployeeId",
                principalTable: "Employeess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workdays_Organizations_OrganizationId",
                table: "Workdays",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Organizations_OrganizationId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Employeess_Organizations_EmployerId",
                table: "Employeess");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Organizations_OrganizationId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Invoices_InvoiceId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Workdays_Employeess_EmployeeId",
                table: "Workdays");

            migrationBuilder.DropForeignKey(
                name: "FK_Workdays_Organizations_OrganizationId",
                table: "Workdays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workdays",
                table: "Workdays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resources",
                table: "Resources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations");

            migrationBuilder.RenameTable(
                name: "Workdays",
                newName: "WorkDay");

            migrationBuilder.RenameTable(
                name: "Resources",
                newName: "Resource");

            migrationBuilder.RenameTable(
                name: "Organizations",
                newName: "Organization");

            migrationBuilder.RenameIndex(
                name: "IX_Workdays_OrganizationId",
                table: "WorkDay",
                newName: "IX_WorkDay_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_Workdays_EmployeeId",
                table: "WorkDay",
                newName: "IX_WorkDay_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Resources_InvoiceId",
                table: "Resource",
                newName: "IX_Resource_InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkDay",
                table: "WorkDay",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resource",
                table: "Resource",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organization",
                table: "Organization",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Organization_OrganizationId",
                table: "Projects",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_Invoices_InvoiceId",
                table: "Resource",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkDay_Employeess_EmployeeId",
                table: "WorkDay",
                column: "EmployeeId",
                principalTable: "Employeess",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkDay_Organization_OrganizationId",
                table: "WorkDay",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
