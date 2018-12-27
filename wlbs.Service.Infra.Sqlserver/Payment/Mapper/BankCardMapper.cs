using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using wlbs.Service.Domain.Payment;

namespace wlbs.Service.Infra.Sqlserver.Payment
{
    public class BankCardMapper : IEntityTypeConfiguration<BankCard>
    {


        public void Configure(EntityTypeBuilder<BankCard> builder)
        {

            builder.ToTable("Pay_Cst_Card");

            builder.HasKey(c => new { c.CardNo, c.Status });

            builder.Property(t => t.BankJsonString).HasColumnName("BankCode");
            builder.Property(t => t.Status).HasColumnName("Stt");
            builder.Property(t => t.CardNo).HasColumnName("CardNo");
            builder.Property(t => t.CardName).HasColumnName("CardNm");
            builder.Property(t => t.IdCardNo).HasColumnName("IdCardNo");
            builder.Property(t => t.Mobile).HasColumnName("Mobile");
            builder.Property(t => t.CreatedTime).HasColumnName("SignTime");

            //忽略字段
            builder.Ignore(t => t.Bank);
            builder.Ignore(t => t.UUId);
        }
    }
}
