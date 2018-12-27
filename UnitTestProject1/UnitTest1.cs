using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using wlbs.Service.Domain.Payment;
using wlbs.Service.Infra.Sqlserver;
using wlbs.Service.Infra.Sqlserver.Payment;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var transflow = new TransactionFlow()
            {
                CreatedTime = DateTime.Now,
                FeeAmt = 0,
                PayerName = "Test",
                ReceiverName = "Test",
                Rem = "",
                Status = TransStatus.Process,
                TranId = "Fsdf4231512341234",
                TransAmount = 0.31M,
                Channel = "N",
                PayerWalletNo = "A234235",
                ReceiverWalletNo = "B234124",
                TranType = "02",
                PaymentMode = PaymentMode.Alipay
            };


            using(var db=new WriteDbContext())
            {
                await db.TransactionFlows.AddAsync(transflow);
                var r = await db.SaveChangesAsync();
                
                //Console.ReadLine();
                Assert.IsTrue(r > 0);
            }
        }

        [TestMethod]
        public async Task TestMethod2()
        {
            using (var db = new WriteDbContext())
            {
                var transflow = await db.TransactionFlows
                    .Where(trans => trans.TranId == "Fsdf4231512341234")                    
                    .Include(trans=>trans.OriTransactionFlow)
                    .FirstOrDefaultAsync();
                
                Assert.IsTrue(transflow.OriTransactionFlow != null);
            }
        }

        [TestMethod]
        public void TestBankCardPage()
        {
            using (var db = new WriteDbContext())
            {
                var banks = db.BankCards
                    .Where(c => c.CardNo != string.Empty)
                    .Skip(0)
                    .Take(10)
                    .Select(_ => _)
                    .ToList();
                Console.Write(JsonConvert.SerializeObject(banks));
                Assert.IsTrue(banks.Count > 0);
            }
        }
    }
}
