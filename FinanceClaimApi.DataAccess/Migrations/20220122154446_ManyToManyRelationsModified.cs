using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class ManyToManyRelationsModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalFlow_FundRequest_FundRequestId",
                table: "ApprovalFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Province_ProvinceId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_FundRequest_Funds_FundId",
                table: "FundRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_FundRequest_Users_UserId",
                table: "FundRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Province",
                table: "Province");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FundRequest",
                table: "FundRequest");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "Province",
                newName: "Provinces");

            migrationBuilder.RenameTable(
                name: "FundRequest",
                newName: "FundRequests");

            migrationBuilder.RenameIndex(
                name: "IX_FundRequest_UserId",
                table: "FundRequests",
                newName: "IX_FundRequests_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FundRequest_FundId",
                table: "FundRequests",
                newName: "IX_FundRequests_FundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundRequests",
                table: "FundRequests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalFlow_FundRequests_FundRequestId",
                table: "ApprovalFlow",
                column: "FundRequestId",
                principalTable: "FundRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Provinces_ProvinceId",
                table: "Districts",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FundRequests_Funds_FundId",
                table: "FundRequests",
                column: "FundId",
                principalTable: "Funds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FundRequests_Users_UserId",
                table: "FundRequests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Roles_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalFlow_FundRequests_FundRequestId",
                table: "ApprovalFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Provinces_ProvinceId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_FundRequests_Funds_FundId",
                table: "FundRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_FundRequests_Users_UserId",
                table: "FundRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Roles_RoleId",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FundRequests",
                table: "FundRequests");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "Provinces",
                newName: "Province");

            migrationBuilder.RenameTable(
                name: "FundRequests",
                newName: "FundRequest");

            migrationBuilder.RenameIndex(
                name: "IX_FundRequests_UserId",
                table: "FundRequest",
                newName: "IX_FundRequest_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FundRequests_FundId",
                table: "FundRequest",
                newName: "IX_FundRequest_FundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Province",
                table: "Province",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundRequest",
                table: "FundRequest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalFlow_FundRequest_FundRequestId",
                table: "ApprovalFlow",
                column: "FundRequestId",
                principalTable: "FundRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Province_ProvinceId",
                table: "Districts",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FundRequest_Funds_FundId",
                table: "FundRequest",
                column: "FundId",
                principalTable: "Funds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FundRequest_Users_UserId",
                table: "FundRequest",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
