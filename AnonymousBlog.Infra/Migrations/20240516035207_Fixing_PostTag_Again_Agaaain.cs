using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnonymousBlog.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Fixing_PostTag_Again_Agaaain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostPostTag");

            migrationBuilder.DropTable(
                name: "PostTagTag");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostPostTag",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    PostTagsTagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostPostTag", x => new { x.PostId, x.PostTagsTagId });
                    table.ForeignKey(
                        name: "FK_PostPostTag_PostTag_PostTagsTagId",
                        column: x => x.PostTagsTagId,
                        principalTable: "PostTag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostPostTag_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTagTag",
                columns: table => new
                {
                    PostTagsTagId = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTagTag", x => new { x.PostTagsTagId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTagTag_PostTag_PostTagsTagId",
                        column: x => x.PostTagsTagId,
                        principalTable: "PostTag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTagTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostPostTag_PostTagsTagId",
                table: "PostPostTag",
                column: "PostTagsTagId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTagTag_TagId",
                table: "PostTagTag",
                column: "TagId");
        }
    }
}
