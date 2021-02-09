using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ShopBridge.Interfaces.Domain;
using ShopBridge.Interfaces.Services;
using ShopBridge.Models.Domain;
using ShopBridge.Models.ViewModels;

namespace ShopBridge.Services
{
    public class ShopBrideService : IShopBridgeServices
    {
        IShopBridgeDataAccess _shopBridgeDataAccess;
        public ShopBrideService(IShopBridgeDataAccess shopBridgeDataAccess)
        {
            _shopBridgeDataAccess = shopBridgeDataAccess;
        }
        public async Task<string> DeleteRecord(ShopBridgeVM shopBridgeVM)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(shopBridgeVM.Id))
                {
                    var shopBridgeItemDM = new ShopBridgeDM();
                    shopBridgeItemDM.Id = Guid.Parse(shopBridgeVM.Id);
                    shopBridgeItemDM.Name = shopBridgeVM.Name;
                    shopBridgeItemDM.Price = shopBridgeVM.Price;
                    shopBridgeItemDM.Description = shopBridgeVM.Description;

                    return await _shopBridgeDataAccess.DeleteRecord(shopBridgeItemDM);
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<ShopBridgeVM>> GetRecords()
        {
            try
            {
                var shopBridgeVMList = new List<ShopBridgeVM>();
                var response = await _shopBridgeDataAccess.GetRecords();

                foreach (var shopBridgeItem in response)
                {
                    var sbI = new ShopBridgeVM();
                    sbI.Id = shopBridgeItem.Id.ToString();
                    sbI.Price = shopBridgeItem.Price;
                    sbI.Name = shopBridgeItem.Name;
                    sbI.Description = shopBridgeItem.Description;
                    shopBridgeVMList.Add(sbI);
                }
                return shopBridgeVMList;
            }
            catch
            {
                throw;
            }
        }

        public async Task<string> PostRecord(ShopBridgeVM shopBridgeVM)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(shopBridgeVM.Id))
                {
                    var shopBridgeItemDM = new ShopBridgeDM();
                    shopBridgeItemDM.Id = new Guid();
                    shopBridgeItemDM.Name = shopBridgeVM.Name;
                    shopBridgeItemDM.Price = shopBridgeVM.Price;
                    shopBridgeItemDM.Description = shopBridgeVM.Description;

                    return await _shopBridgeDataAccess.PostRecord(shopBridgeItemDM);
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<string> UpdateRecord(ShopBridgeVM shopBridgeVM)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(shopBridgeVM.Id))
                {
                    var shopBridgeItemDM = new ShopBridgeDM();
                    shopBridgeItemDM.Id = Guid.Parse(shopBridgeVM.Id);
                    shopBridgeItemDM.Name = shopBridgeVM.Name;
                    shopBridgeItemDM.Price = shopBridgeVM.Price;
                    shopBridgeItemDM.Description = shopBridgeVM.Description;

                    return await _shopBridgeDataAccess.UpdateRecord(shopBridgeItemDM);
                }
                return null;
            }
            catch
            {
                throw;
            }
        }
    }
}