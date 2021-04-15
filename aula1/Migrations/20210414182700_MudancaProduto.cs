using Microsoft.EntityFrameworkCore.Migrations;

namespace aula1.Migrations
{
    public partial class MudancaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categorias_CategoriaId",
                table: "Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produto",
                table: "Produto");

            migrationBuilder.RenameTable(
                name: "Produto",
                newName: "Produtos Mislaine");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produtos Mislaine",
                newName: "IX_Produtos Mislaine_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos Mislaine",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos Mislaine",
                table: "Produtos Mislaine",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos Mislaine_Categorias_CategoriaId",
                table: "Produtos Mislaine",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos Mislaine_Categorias_CategoriaId",
                table: "Produtos Mislaine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos Mislaine",
                table: "Produtos Mislaine");

            migrationBuilder.RenameTable(
                name: "Produtos Mislaine",
                newName: "Produto");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos Mislaine_CategoriaId",
                table: "Produto",
                newName: "IX_Produto_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produto",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produto",
                table: "Produto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categorias_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
