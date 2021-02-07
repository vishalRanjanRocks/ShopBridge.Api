using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShopBridge.Models.ViewModels;

namespace ShopBridge.Interfaces.Services
{
   public interface IShopBridgeServices
    {
        Task<List<ShopBridgeVM>> GetRecords();
        Task<string> PostRecord(ShopBridgeVM shopBridgeVM);
        Task<string> DeleteRecord(ShopBridgeVM shopBridgeVM);
        Task<string> UpdateRecord(ShopBridgeVM shopBridgeVM);
    }
}
