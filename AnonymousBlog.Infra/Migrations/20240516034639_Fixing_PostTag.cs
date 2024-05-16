using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AnonymousBlog.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Fixing_PostTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostPostTag_PostTag_PostTagsPostId_PostTagsTagId",
                table: "PostPostTag");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTagTag_PostTag_PostTagsPostId_PostTagsTagId",
                table: "PostTagTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTagTag",
                table: "PostTagTag");

            migrationBuilder.DropIndex(
                name: "IX_PostTagTag_PostTagsPostId_PostTagsTagId",
                table: "PostTagTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostPostTag",
                table: "PostPostTag");

            migrationBuilder.DropIndex(
                name: "IX_PostPostTag_PostTagsPostId_PostTagsTagId",
                table: "PostPostTag");

            migrationBuilder.DropColumn(
                name: "PostTagsPostId",
                table: "PostTagTag");

            migrationBuilder.DropColumn(
                name: "PostTagsPostId",
                table: "PostPostTag");

            migrationBuilder.AlterColumn<int>(
                name: "TagId",
                table: "PostTag",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTagTag",
                table: "PostTagTag",
                columns: new[] { "PostTagsTagId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag",
                column: "TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostPostTag",
                table: "PostPostTag",
                columns: new[] { "PostId", "PostTagsTagId" });

            migrationBuilder.CreateIndex(
                name: "IX_PostTagTag_TagId",
                table: "PostTagTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_PostPostTag_PostTagsTagId",
                table: "PostPostTag",
                column: "PostTagsTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostPostTag_PostTag_PostTagsTagId",
                table: "PostPostTag",
                column: "PostTagsTagId",
                principalTable: "PostTag",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTagTag_PostTag_PostTagsTagId",
                table: "PostTagTag",
                column: "PostTagsTagId",
                principalTable: "PostTag",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostPostTag_PostTag_PostTagsTagId",
                table: "PostPostTag");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTagTag_PostTag_PostTagsTagId",
                table: "PostTagTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTagTag",
                table: "PostTagTag");

            migrationBuilder.DropIndex(
                name: "IX_PostTagTag_TagId",
                table: "PostTagTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostPostTag",
                table: "PostPostTag");

            migrationBuilder.DropIndex(
                name: "IX_PostPostTag_PostTagsTagId",
                table: "PostPostTag");

            migrationBuilder.AddColumn<int>(
                name: "PostTagsPostId",
                table: "PostTagTag",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TagId",
                table: "PostTag",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "PostTagsPostId",
                table: "PostPostTag",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTagTag",
                table: "PostTagTag",
                columns: new[] { "TagId", "PostTagsPostId", "PostTagsTagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTag",
                table: "PostTag",
                columns: new[] { "PostId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostPostTag",
                table: "PostPostTag",
                columns: new[] { "PostId", "PostTagsPostId", "PostTagsTagId" });

            migrationBuilder.CreateIndex(
                name: "IX_PostTagTag_PostTagsPostId_PostTagsTagId",
                table: "PostTagTag",
                columns: new[] { "PostTagsPostId", "PostTagsTagId" });

            migrationBuilder.CreateIndex(
                name: "IX_PostPostTag_PostTagsPostId_PostTagsTagId",
                table: "PostPostTag",
                columns: new[] { "PostTagsPostId", "PostTagsTagId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PostPostTag_PostTag_PostTagsPostId_PostTagsTagId",
                table: "PostPostTag",
                columns: new[] { "PostTagsPostId", "PostTagsTagId" },
                principalTable: "PostTag",
                principalColumns: new[] { "PostId", "TagId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTagTag_PostTag_PostTagsPostId_PostTagsTagId",
                table: "PostTagTag",
                columns: new[] { "PostTagsPostId", "PostTagsTagId" },
                principalTable: "PostTag",
                principalColumns: new[] { "PostId", "TagId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
