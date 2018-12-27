using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using wlbs.Service.Domain.Payment;
using wlbs.Service.Infra.Sqlserver.Payment;
using wlbs.Service.Infra.Sqlserver.Payment.Mapper;

namespace wlbs.Service.Infra.Sqlserver
{
    public class WriteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.168.2.10;Initial Catalog=LogisticsApp;User ID=test3;Password=345678;Max Pool Size=200;MultipleActiveResultSets=true;"
, b => b.UseRowNumberForPaging());
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TransactionFlowMapper());
            modelBuilder.ApplyConfiguration(new BankCardMapper());
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<TransactionFlow> TransactionFlows { get; set; }
        public DbSet<BankCard> BankCards { get; set; }
    }
}
