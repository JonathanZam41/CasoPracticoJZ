using CasoPractico.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasoPractico.Repository.Configurations
{
    public class MovimentConfiguration : IEntityTypeConfiguration<Moviment>
    {
        public void Configure(EntityTypeBuilder<Moviment> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("MOVIMENT");

            builder.HasIndex(e => new { e.IdAccount }, "IDX_UNIQUE_TIP_ID_CLI_ID_NUMBER")
                .IsUnique();

            builder.Property(e => e.Id)
                .HasColumnOrder(0)
                .IsRequired()
                .HasColumnName("MOV_ID")
                .HasComment("Id de movimiento");

            builder.Property(e => e.Date)
                .HasColumnOrder(1)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("MOV_DATE")
                .HasComment("Fecha de movimiento");

            builder.Property(e => e.Type)
                .HasColumnOrder(2)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("MOV_TYPE")
                .HasComment("Tipo de movimiento");

            builder.Property(e => e.Value)
                .HasColumnOrder(3)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("MOV_VALUE")
                .HasComment("Valor de movimiento");

            builder.Property(e => e.Balance)
                .HasColumnOrder(4)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("MOV_BALANCE")
                .HasComment("Saldo restante");

            builder.Property(e => e.CreatedBy)
                .HasColumnOrder(5)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("MOV_CREATED_BY")
                .HasComment("Usuario que creo el registro");

            builder.Property(e => e.CreatedOn)
                .HasColumnOrder(6)
                .IsRequired()
                .HasColumnName("MOV_CREATED_ON")
                .HasComment("Fecha de creacion del registro");

            builder.Property(e => e.UpdatedBy)
                .HasColumnOrder(7)
                .HasMaxLength(100)
                .IsRequired(false)
                .HasColumnName("MOV_UPDATED_BY")
                .HasComment("Usuario que actualizo el registro");

            builder.Property(e => e.UpdatedOn)
                .HasColumnOrder(8)
                .IsRequired(false)
                .HasColumnName("MOV_UPDATED_ON")
                .HasComment("Fecha de actualizacion del registro");
            
            builder.Property(e => e.IdAccount)
                .HasColumnOrder(9)
                .IsRequired()
                .HasColumnName("MOV_ACCOUNT_ID")
                .HasComment("Id de cuenta");

            builder.HasOne(d => d.Account)
                   .WithMany(p => p.Moviments)
                   .HasForeignKey(d => d.IdAccount)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_MOV_ACCOUNT_ID");
        }
    }
}
