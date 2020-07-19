using Microsoft.EntityFrameworkCore.Migrations;

namespace CompraRapida.Repositorio.Migrations
{
    public partial class CargaFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormasPagamento",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 1, "Pagamento no Boleto", "Boleto" });

            migrationBuilder.InsertData(
                table: "FormasPagamento",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 2, "Cartão de Crédito", "CartaoCredito" });

            migrationBuilder.InsertData(
                table: "FormasPagamento",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 3, "Depósito", "Deposito" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormasPagamento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormasPagamento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormasPagamento",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
