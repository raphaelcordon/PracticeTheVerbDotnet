using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeTheVerb.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PracticeTheVerb_Italian_Verb",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    infinitivopresente = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    infinitivopassato = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    participiopresente = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    participiopassato = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    gerundiopresente = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    gerundiopassato = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopresenteio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopresentetu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopresentelui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopresentenoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopresente = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopresenteloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoprossimoio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoprossimotu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoprossimolui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoprossimonoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoprossimovoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoprossimoloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativoimperfettoio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativoimperfettotu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativoimperfettolui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativoimperfettonoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativoimperfettovoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativoimperfettoloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoprossimoio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoprossimotu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoprossimolui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoprossimonoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoprossimovoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoprossimoloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoremotoio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoremototu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoremotolui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoremotonoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoremotovoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativopassatoremotoloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoremotoio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoremototu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    lui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoremotonoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoremotovoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativotrapassatoremotoloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturosempliceio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturosemplicetu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturosemplicelui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturosemplicenoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturosemplicevoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturosempliceloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturoanterioreio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturoanterioretu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturoanteriorelui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturoanteriorenoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturoanteriorevoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    indicativofuturoanterioreloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopresenteio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopresentetu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopresentelui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopresentenoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopresentevoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopresenteloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopassatoio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopassatotu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopassatolui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopassatonoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopassatovoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivopassatoloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivoimperfettoio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivoimperfettotu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivoimperfettolui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivoimperfettonoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivoimperfettovoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivoimperfettoloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivotrapassatoio = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivotrapassatotu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivotrapassatolui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivotrapassatonoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivotrapassatovoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    congiuntivotrapassatoloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    imperativopresentetu = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    imperativopresentelui = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    imperativopresentenoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    imperativopresentevoi = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true),
                    imperativopresenteloro = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticeTheVerb_Italian_Verb", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PracticeTheVerb_Italian_Verb");
        }
    }
}
