using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBConnection.Migrations
{
    /// <inheritdoc />
    public partial class addedmissingtables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentStory_department_DepartmentId",
                schema: "viatabloid",
                table: "DepartmentStory");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentStory_story_StoryId",
                schema: "viatabloid",
                table: "DepartmentStory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentStory",
                schema: "viatabloid",
                table: "DepartmentStory");

            migrationBuilder.RenameTable(
                name: "DepartmentStory",
                schema: "viatabloid",
                newName: "departmentStory",
                newSchema: "viatabloid");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentStory_StoryId",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "IX_departmentStory_StoryId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentStory_DepartmentId",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "IX_departmentStory_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departmentStory",
                schema: "viatabloid",
                table: "departmentStory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_departmentStory_department_DepartmentId",
                schema: "viatabloid",
                table: "departmentStory",
                column: "DepartmentId",
                principalSchema: "viatabloid",
                principalTable: "department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_departmentStory_story_StoryId",
                schema: "viatabloid",
                table: "departmentStory",
                column: "StoryId",
                principalSchema: "viatabloid",
                principalTable: "story",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departmentStory_department_DepartmentId",
                schema: "viatabloid",
                table: "departmentStory");

            migrationBuilder.DropForeignKey(
                name: "FK_departmentStory_story_StoryId",
                schema: "viatabloid",
                table: "departmentStory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departmentStory",
                schema: "viatabloid",
                table: "departmentStory");

            migrationBuilder.RenameTable(
                name: "departmentStory",
                schema: "viatabloid",
                newName: "DepartmentStory",
                newSchema: "viatabloid");

            migrationBuilder.RenameIndex(
                name: "IX_departmentStory_StoryId",
                schema: "viatabloid",
                table: "DepartmentStory",
                newName: "IX_DepartmentStory_StoryId");

            migrationBuilder.RenameIndex(
                name: "IX_departmentStory_DepartmentId",
                schema: "viatabloid",
                table: "DepartmentStory",
                newName: "IX_DepartmentStory_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentStory",
                schema: "viatabloid",
                table: "DepartmentStory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentStory_department_DepartmentId",
                schema: "viatabloid",
                table: "DepartmentStory",
                column: "DepartmentId",
                principalSchema: "viatabloid",
                principalTable: "department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentStory_story_StoryId",
                schema: "viatabloid",
                table: "DepartmentStory",
                column: "StoryId",
                principalSchema: "viatabloid",
                principalTable: "story",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
