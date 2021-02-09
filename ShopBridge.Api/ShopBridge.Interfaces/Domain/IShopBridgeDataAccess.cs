using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShopBridge.Models.Domain;
using ShopBridge.Models.ViewModels;

namespace ShopBridge.Interfaces.Domain
{
    public interface IShopBridgeDataAccess
    {
        Task<List<ShopBridgeDM>> GetRecords();
        Task<string> PostRecord(ShopBridgeDM shopBridgeVM);
        Task<string> DeleteRecord(ShopBridgeDM shopBridgeDM);
        Task<string> UpdateRecord(ShopBridgeDM shopBridgeDM);
    }
}
