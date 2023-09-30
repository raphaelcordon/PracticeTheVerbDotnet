
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeTheVerb.Domain.Entities.Italian;

namespace PracticeTheVerb.Infrastructure.Data.Mappings.Italian;

public class ItalianVerbsMap : IEntityTypeConfiguration<ItalianVerb>
{
	public void Configure(EntityTypeBuilder<ItalianVerb> builder)
	{
		// Tabel
		builder.ToTable("PracticeTheVerb_Italian_Verb");

		// PK
		builder.HasKey(x => x.Id);

		// Identity
		builder.Property(x => x.Id);
				
		// Properties
		builder.Property(x => x.infinitivopresente)
			.HasColumnName("infinitivopresente")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.infinitivopassato)
			.HasColumnName("infinitivopassato")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.participiopresente)
			.HasColumnName("participiopresente")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.participiopassato)
			.HasColumnName("participiopassato")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.gerundiopresente)
			.HasColumnName("gerundiopresente")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.gerundiopassato)
			.HasColumnName("gerundiopassato")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopresenteio)
			.HasColumnName("indicativopresenteio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopresentetu)
			.HasColumnName("indicativopresentetu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopresentelui)
			.HasColumnName("indicativopresentelui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopresentenoi)
			.HasColumnName("indicativopresentenoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopresentevoi)
			.HasColumnName("indicativopresente")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopresenteloro)
			.HasColumnName("indicativopresenteloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoprossimoio)
			.HasColumnName("indicativopassatoprossimoio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoprossimotu)
			.HasColumnName("indicativopassatoprossimotu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoprossimolui)
			.HasColumnName("indicativopassatoprossimolui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoprossimonoi)
			.HasColumnName("indicativopassatoprossimonoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoprossimovoi)
			.HasColumnName("indicativopassatoprossimovoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoprossimoloro)
			.HasColumnName("indicativopassatoprossimoloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativoimperfettoio)
			.HasColumnName("indicativoimperfettoio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativoimperfettotu)
			.HasColumnName("indicativoimperfettotu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativoimperfettolui)
			.HasColumnName("indicativoimperfettolui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativoimperfettonoi)
			.HasColumnName("indicativoimperfettonoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativoimperfettovoi)
			.HasColumnName("indicativoimperfettovoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativoimperfettoloro)
			.HasColumnName("indicativoimperfettoloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoprossimoio)
			.HasColumnName("indicativotrapassatoprossimoio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoprossimotu)
			.HasColumnName("indicativotrapassatoprossimotu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoprossimolui)
			.HasColumnName("indicativotrapassatoprossimolui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoprossimonoi)
			.HasColumnName("indicativotrapassatoprossimonoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoprossimovoi)
			.HasColumnName("indicativotrapassatoprossimovoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoprossimoloro)
			.HasColumnName("indicativotrapassatoprossimoloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoremotoio)
			.HasColumnName("indicativopassatoremotoio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoremototu)
			.HasColumnName("indicativopassatoremototu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoremotolui)
			.HasColumnName("indicativopassatoremotolui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoremotonoi)
			.HasColumnName("indicativopassatoremotonoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoremotovoi)
			.HasColumnName("indicativopassatoremotovoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativopassatoremotoloro)
			.HasColumnName("indicativopassatoremotoloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoremotoio)
			.HasColumnName("indicativotrapassatoremotoio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoremototu)
			.HasColumnName("indicativotrapassatoremototu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoremotolui)
			.HasColumnName("lui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoremotonoi)
			.HasColumnName("indicativotrapassatoremotonoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoremotovoi)
			.HasColumnName("indicativotrapassatoremotovoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativotrapassatoremotoloro)
			.HasColumnName("indicativotrapassatoremotoloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturosempliceio)
			.HasColumnName("indicativofuturosempliceio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturosemplicetu)
			.HasColumnName("indicativofuturosemplicetu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturosemplicelui)
			.HasColumnName("indicativofuturosemplicelui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturosemplicenoi)
			.HasColumnName("indicativofuturosemplicenoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturosemplicevoi)
			.HasColumnName("indicativofuturosemplicevoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturosempliceloro)
			.HasColumnName("indicativofuturosempliceloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturoanterioreio)
			.HasColumnName("indicativofuturoanterioreio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturoanterioretu)
			.HasColumnName("indicativofuturoanterioretu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturoanteriorelui)
			.HasColumnName("indicativofuturoanteriorelui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturoanteriorenoi)
			.HasColumnName("indicativofuturoanteriorenoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturoanteriorevoi)
			.HasColumnName("indicativofuturoanteriorevoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.indicativofuturoanterioreloro)
			.HasColumnName("indicativofuturoanterioreloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopresenteio)
			.HasColumnName("congiuntivopresenteio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopresentetu)
			.HasColumnName("congiuntivopresentetu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopresentelui)
			.HasColumnName("congiuntivopresentelui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopresentenoi)
			.HasColumnName("congiuntivopresentenoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopresentevoi)
			.HasColumnName("congiuntivopresentevoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopresenteloro)
			.HasColumnName("congiuntivopresenteloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopassatoio)
			.HasColumnName("congiuntivopassatoio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopassatotu)
			.HasColumnName("congiuntivopassatotu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopassatolui)
			.HasColumnName("congiuntivopassatolui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopassatonoi)
			.HasColumnName("congiuntivopassatonoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopassatovoi)
			.HasColumnName("congiuntivopassatovoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivopassatoloro)
			.HasColumnName("congiuntivopassatoloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivoimperfettoio)
			.HasColumnName("congiuntivoimperfettoio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivoimperfettotu)
			.HasColumnName("congiuntivoimperfettotu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivoimperfettolui)
			.HasColumnName("congiuntivoimperfettolui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivoimperfettonoi)
			.HasColumnName("congiuntivoimperfettonoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivoimperfettovoi)
			.HasColumnName("congiuntivoimperfettovoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivoimperfettoloro)
			.HasColumnName("congiuntivoimperfettoloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivotrapassatoio)
			.HasColumnName("congiuntivotrapassatoio")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivotrapassatotu)
			.HasColumnName("congiuntivotrapassatotu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivotrapassatolui)
			.HasColumnName("congiuntivotrapassatolui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivotrapassatonoi)
			.HasColumnName("congiuntivotrapassatonoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivotrapassatovoi)
			.HasColumnName("congiuntivotrapassatovoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.congiuntivotrapassatoloro)
			.HasColumnName("congiuntivotrapassatoloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.imperativopresentetu)
			.HasColumnName("imperativopresentetu")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.imperativopresentelui)
			.HasColumnName("imperativopresentelui")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.imperativopresentenoi)
			.HasColumnName("imperativopresentenoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.imperativopresentevoi)
			.HasColumnName("imperativopresentevoi")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);

		builder.Property(x => x.imperativopresenteloro)
			.HasColumnName("imperativopresenteloro")
			.HasColumnType("NVARCHAR")
			.HasMaxLength(60);
	}
}
