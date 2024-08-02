using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coderoot.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Topic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Problem_Topic_TopicId",
                table: "Problem");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Problem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Problem_Topic_TopicId",
                table: "Problem",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Problem_Topic_TopicId",
                table: "Problem");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Problem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Problem_Topic_TopicId",
                table: "Problem",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id");
        }
    }
}
