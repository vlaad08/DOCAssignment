using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBConnection.Migrations
{
    /// <inheritdoc />
    public partial class refactoringtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departmentStory_department_DepartmentId",
                schema: "viatabloid",
                table: "departmentStory");

            migrationBuilder.DropForeignKey(
                name: "FK_departmentStory_story_StoryId",
                schema: "viatabloid",
                table: "departmentStory");

            migrationBuilder.DropForeignKey(
                name: "FK_story_department_DepartmentId",
                schema: "viatabloid",
                table: "story");

            migrationBuilder.DropForeignKey(
                name: "FK_story_story_StoryId",
                schema: "viatabloid",
                table: "story");

            migrationBuilder.DropIndex(
                name: "IX_story_DepartmentId",
                schema: "viatabloid",
                table: "story");

            migrationBuilder.DropIndex(
                name: "IX_story_StoryId",
                schema: "viatabloid",
                table: "story");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                schema: "viatabloid",
                table: "story");

            migrationBuilder.DropColumn(
                name: "StoryId",
                schema: "viatabloid",
                table: "story");

            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "viatabloid",
                table: "story",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Body",
                schema: "viatabloid",
                table: "story",
                newName: "body");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "viatabloid",
                table: "story",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StoryId",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "storyId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "departmentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_departmentStory_StoryId",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "IX_departmentStory_storyId");

            migrationBuilder.RenameIndex(
                name: "IX_departmentStory_DepartmentId",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "IX_departmentStory_departmentId");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "viatabloid",
                table: "department",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                schema: "viatabloid",
                table: "department",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "viatabloid",
                table: "department",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_departmentStory_department_departmentId",
                schema: "viatabloid",
                table: "departmentStory",
                column: "departmentId",
                principalSchema: "viatabloid",
                principalTable: "department",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_departmentStory_story_storyId",
                schema: "viatabloid",
                table: "departmentStory",
                column: "storyId",
                principalSchema: "viatabloid",
                principalTable: "story",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departmentStory_department_departmentId",
                schema: "viatabloid",
                table: "departmentStory");

            migrationBuilder.DropForeignKey(
                name: "FK_departmentStory_story_storyId",
                schema: "viatabloid",
                table: "departmentStory");

            migrationBuilder.RenameColumn(
                name: "title",
                schema: "viatabloid",
                table: "story",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "body",
                schema: "viatabloid",
                table: "story",
                newName: "Body");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "viatabloid",
                table: "story",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "storyId",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "StoryId");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_departmentStory_storyId",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "IX_departmentStory_StoryId");

            migrationBuilder.RenameIndex(
                name: "IX_departmentStory_departmentId",
                schema: "viatabloid",
                table: "departmentStory",
                newName: "IX_departmentStory_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "name",
                schema: "viatabloid",
                table: "department",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                schema: "viatabloid",
                table: "department",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "viatabloid",
                table: "department",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentId",
                schema: "viatabloid",
                table: "story",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoryId",
                schema: "viatabloid",
                table: "story",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_story_DepartmentId",
                schema: "viatabloid",
                table: "story",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_story_StoryId",
                schema: "viatabloid",
                table: "story",
                column: "StoryId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_story_department_DepartmentId",
                schema: "viatabloid",
                table: "story",
                column: "DepartmentId",
                principalSchema: "viatabloid",
                principalTable: "department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_story_story_StoryId",
                schema: "viatabloid",
                table: "story",
                column: "StoryId",
                principalSchema: "viatabloid",
                principalTable: "story",
                principalColumn: "Id");
        }
    }
}
