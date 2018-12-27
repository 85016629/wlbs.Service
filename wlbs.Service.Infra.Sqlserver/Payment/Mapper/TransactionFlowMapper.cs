namespace wlbs.Service.Infra.Sqlserver.Payment.Mapper
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using wlbs.Service.Domain.Payment;
    public class TransactionFlowMapper : IEntityTypeConfiguration<TransactionFlow>
    {
        public void Configure(EntityTypeBuilder<TransactionFlow> builder)
        {
            builder.ToTable("Pay_Tran_Flow");
            builder.HasKey(t => t.TranId);

            builder.Property(t => t.Rem).HasColumnName("Rem");
            builder.Property(t => t.Status).HasColumnName("Stt");
            builder.Property(t => t.ResultMsg).HasColumnName("RstMsg");
            builder.Property(t => t.TranType).HasColumnName("TranType");
            //付款人
            builder.Property(t => t.PayerName).HasColumnName("PayAccNm");
            builder.Property(t => t.PayerWalletNo).HasColumnName("PayAcc");
            //收款人
            builder.Property(t => t.ReceiverName).HasColumnName("RcvAccNm");
            builder.Property(t => t.ReceiverWalletNo).HasColumnName("RcvAcc");

            builder.Property(t => t.TransAmount).HasColumnName("TranAmt");
            builder.Property(t => t.CreatedTime).HasColumnName("TranTime");

            builder.Property(t => t.OriTransactionFlowId).HasColumnName("ReqTranId");
            builder.Property(t => t.PaymentMode)
                .HasColumnName("TranPath")
                .HasColumnType("tinyint");

            builder.HasOne(t=>t.OriTransactionFlow)
                .WithOne()
                .HasForeignKey<TransactionFlow>(f => f.OriTransactionFlowId);

            builder.Ignore(t => t.UUId);
            builder.Ignore(t => t.Channel);
        }
    }
}
