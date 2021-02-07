using Microsoft.EntityFrameworkCore;
using ShopBridge.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBridge.DataAccess.Context
{
    public class ShopBridgeContext : DbContext
    {
        public ShopBridgeContext(DbContextOptions options)
         : base(options)
        {
        }

        public DbSet<ShopBridgeDM> ShopBridgeItemList { get; set; }
    }
}
