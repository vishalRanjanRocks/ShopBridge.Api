using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ShopBridge.DataAccess.Context;
using ShopBridge.Interfaces.Domain;
using ShopBridge.Models.Domain;
using ShopBridge.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ShopBridge.DataAccess.Repository
{
    public class ShopBridgeDataAccess : IShopBridgeDataAccess
    {

        readonly ShopBridgeContext _shopBridgeContext;
        public ShopBridgeDataAccess(ShopBridgeContext shopBridgeContext)
        {
            _shopBridgeContext = shopBridgeContext;
        }

        public async Task<string> DeleteRecord(ShopBridgeDM shopBridgeDM)
        {
            try
            {
                _shopBridgeContext.ShopBridgeItemList.Remove(shopBridgeDM);
                await _shopBridgeContext.SaveChangesAsync();
                return "DeleteSuccedded";
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<string> UpdateRecord(ShopBridgeDM shopBridgeDM)
        {
            try
            {
                _shopBridgeContext.ShopBridgeItemList.Update(shopBridgeDM);
                await _shopBridgeContext.SaveChangesAsync();
                return "DeleteSuccedded";
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<List<ShopBridgeDM>> GetRecords()
        {
            try
            {
                var records = await _shopBridgeContext.ShopBridgeItemList.ToListAsync();
                return records;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<string> PostRecord(ShopBridgeDM shopBridgeDM)
        {
            try
            {
                await _shopBridgeContext.ShopBridgeItemList.AddAsync(shopBridgeDM);
                await _shopBridgeContext.SaveChangesAsync();
                return "Sucess";
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
