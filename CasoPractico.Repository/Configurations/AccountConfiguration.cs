using CasoPractico.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasoPractico.Repository.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("ACCOUNT");

            builder.Property(e => e.Id)
                .HasColumnOrder(0)
                .IsRequired()
                .HasColumnName("ACC_ID")
                .HasComment("Id de la cuenta");

            builder.Property(e => e.Number)
                .HasColumnOrder(1)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("ACC_NUMBER")
                .HasComment("Numero de cuenta");

            builder.Property(e => e.Type)
                .HasColumnOrder(2)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("ACC_TYPE")
                .HasComment("Tipo de cuenta");

            builder.Property(e => e.InitialBalance)
                .HasColumnOrder(3)
                .IsRequired()
                .HasColumnName("ACC_INITIAL_BALANCE")
                .HasComment("Saldo inicial");

            builder.Property(e => e.CreatedBy)
                .HasColumnOrder(4)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("ACC_CREATED_BY")
                .HasComment("Usuario que creo el registro");

            builder.Property(e => e.CreatedOn)
                .HasColumnOrder(5)
                .IsRequired()
                .HasColumnName("ACC_CREATED_ON")
                .HasComment("Fecha de creacion del registro");

            builder.Property(e => e.UpdatedBy)
                .HasColumnOrder(6)
                .HasMaxLength(100)
                .IsRequired(false)
                .HasColumnName("ACC_UPDATED_BY")
                .HasComment("Usuario que actualizo el registro");

            builder.Property(e => e.UpdatedOn)
                .HasColumnOrder(7)
                .IsRequired(false)
                .HasColumnName("ACC_UPDATED_ON")
                .HasComment("Fecha de actualizacion del registro");

            builder.Property(e => e.Status)
                .HasColumnOrder(8)
                .IsRequired()
                .HasColumnName("ACC_STATUS")
                .HasComment("Estado de la cuenta");

            builder.Property(e => e.IdClient)
                .HasColumnOrder(9)
                .IsRequired()
                .HasColumnName("ACC_CLIENT_ID")
                .HasComment("Id de cliente");

            builder.HasOne(d => d.Client)
                   .WithMany(p => p.Accounts)
                   .HasForeignKey(d => d.IdClient)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_ACC_CLIENT_ID");
        }
    }
}
