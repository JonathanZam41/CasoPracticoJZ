using CasoPractico.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasoPractico.Repository.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("CLIENT");

            builder.Property(e => e.Id)
                .HasColumnOrder(0)
                .IsRequired()
                .HasColumnName("CLI_ID")
                .HasComment("Id de Cliente");
            
            builder.Property(e => e.Name)
                .HasColumnOrder(1)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("CLI_NAME")
                .HasComment("Nombre de Cliente");
            
            builder.Property(e => e.Gender)
                .HasColumnOrder(2)
                .IsRequired(false)
                .HasColumnName("CLI_GENDER")
                .HasComment("Genero de Cliente");

            builder.Property(e => e.Age)
                .HasColumnOrder(3)
                .IsRequired()
                .HasColumnName("CLI_AGE")
                .HasComment("Edad de Cliente");

            builder.Property(e => e.Identification)
                .HasColumnOrder(4)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("CLI_IDENTIFICATION")
                .HasComment("Identificacion de Cliente");

            builder.Property(e => e.Address)
                .HasColumnOrder(5)
                .IsRequired(false)
                .HasMaxLength(50)
                .HasColumnName("CLI_ADDRESS")
                .HasComment("Direccion de Cliente");

            builder.Property(e => e.Phone)
                .HasColumnOrder(6)
                .IsRequired(false)
                .HasMaxLength(15)
                .HasColumnName("CLI_PHONE")
                .HasComment("Telefono del cliente");

            builder.Property(e => e.CreatedBy)
                .HasColumnOrder(7)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("CLI_CREATED_BY")
                .HasComment("Usuario que creo el registro");

            builder.Property(e => e.CreatedOn)
                .HasColumnOrder(8)
                .IsRequired()
                .HasColumnName("CLI_CREATED_ON")
                .HasComment("Fecha de creacion del registro");

            builder.Property(e => e.UpdatedBy)
                .HasColumnOrder(9)
                .HasMaxLength(100)
                .IsRequired(false)
                .HasColumnName("CLI_UPDATED_BY")
                .HasComment("Usuario que actualizo el registro");

            builder.Property(e => e.UpdatedOn)
                .HasColumnOrder(10)
                .IsRequired(false)
                .HasColumnName("CLI_UPDATED_ON")
                .HasComment("Fecha de actualizacion del registro");

            builder.Property(e => e.Status)
                .HasColumnOrder(11)
                .IsRequired()
                .HasColumnName("CLI_STATUS")
                .HasComment("Estado del cliente");

        }
    }
}
