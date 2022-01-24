using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class TableRelationsModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FundRequest_User_UserId",
                table: "FundRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_GNDivisions_DivisionalSecretariats_DivisionalSecretariatDivId",
                table: "GNDivisions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FundApprovalId",
                table: "ApprovalFlow");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "ApprovalFlow");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "DivisionalSecretariatDivId",
                table: "GNDivisions",
                newName: "DivisionalSecretariatId");

            migrationBuilder.RenameIndex(
                name: "IX_GNDivisions_DivisionalSecretariatDivId",
                table: "GNDivisions",
                newName: "IX_GNDivisions_DivisionalSecretariatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GNDivisionId",
                table: "Users",
                column: "GNDivisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FundRequest_Users_UserId",
                table: "FundRequest",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GNDivisions_DivisionalSecretariats_DivisionalSecretariatId",
                table: "GNDivisions",
                column: "DivisionalSecretariatId",
                principalTable: "DivisionalSecretariats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Users_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_GNDivisions_GNDivisionId",
                table: "Users",
                column: "GNDivisionId",
                principalTable: "GNDivisions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FundRequest_Users_UserId",
                table: "FundRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_GNDivisions_DivisionalSecretariats_DivisionalSecretariatId",
                table: "GNDivisions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Users_UserId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_GNDivisions_GNDivisionId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GNDivisionId",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "DivisionalSecretariatId",
                table: "GNDivisions",
                newName: "DivisionalSecretariatDivId");

            migrationBuilder.RenameIndex(
                name: "IX_GNDivisions_DivisionalSecretariatId",
                table: "GNDivisions",
                newName: "IX_GNDivisions_DivisionalSecretariatDivId");

            migrationBuilder.AddColumn<int>(
                name: "FundApprovalId",
                table: "ApprovalFlow",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "ApprovalFlow",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FundRequest_User_UserId",
                table: "FundRequest",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GNDivisions_DivisionalSecretariats_DivisionalSecretariatDivId",
                table: "GNDivisions",
                column: "DivisionalSecretariatDivId",
                principalTable: "DivisionalSecretariats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
