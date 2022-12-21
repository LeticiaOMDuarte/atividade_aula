using VoeAirlines.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; //Trabalhar com Fluent API


namespace VoeAirlines.EntityConfigurations;

public class LoginConfiguration:IEntityTypeConfiguration<Login>
{
     public void Configure(EntityTypeBuilder<Login> builder)
    {
        //throw new NotImplementedException();

        builder.ToTable("Logins");
        //lambda
        /*

            função
            void somar(int x,int y){
                return x+y;
            }
            esquerda (parâmetros) => direita (regra de negócio)
            s => s.x + s.y;

        */
            builder.HasKey(l=>l.Id); // vai gerar chave primária
        /*
            Para ser chave primária: 
            única - imutável - universal
            1,2,3,4,5,6,7,8....
        */
        // FLUENT API - Encadeamento
            builder.Property(l=>l.Usuario)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(l=>l.Senha)
                   .IsRequired()
                   .HasMaxLength(9);
    }
}
