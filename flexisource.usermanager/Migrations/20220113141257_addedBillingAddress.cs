using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace flexisource.usermanager.Migrations
{
    public partial class addedBillingAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Users",
                newName: "DeliveryAddress");

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingAddress",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "DeliveryAddress",
                table: "Users",
                newName: "Address");
        }
    }
}
