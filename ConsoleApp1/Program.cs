using System;
using wlbs.Service.Domain.Payment;
using wlbs.Service.Infra.Sqlserver;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var transflow = new TransactionFlow()
            {
                CreateTime = DateTime.Now,
                FeeAmt = 0,
                PayerName = "Test",
                ReceiverName = "Test",
                Rem = "",
                Status = TransStatus.Process,
                TranId = "Fsdf4231512341234",
                TransAmount = 0.31M,
                Channel = "N",
                PayerWalletNo = "A234235",
                ReceiverWalletNo = "B234124"
            };


            using (var db = new WriteDbContext())
            {
                db.TransactionFlows.AddAsync(transflow);
                db.SaveChangesAsync();
            }
        }
    }
}
