using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBridge.Interfaces.Services;
using ShopBridge.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopBridgeController : ControllerBase
    {
        IShopBridgeServices _shopBridgeServices;
        public ShopBridgeController(IShopBridgeServices shopBridgeServices)
        {
            _shopBridgeServices = shopBridgeServices;
        }

        [HttpGet("get/data")]
        public async Task<IActionResult> GetData()
        {
            try
            {
                var response = await _shopBridgeServices.GetRecords();
                return Ok(response);
            }
            catch
            {
                throw;
            }

        }

        [HttpPost("save/data")]
        public async Task<IActionResult> SaveData([FromBody] ShopBridgeVM shopBridgeVM)
        {
            try
            {
                var response = await _shopBridgeServices.PostRecord(shopBridgeVM);
                return Ok(response);
            }
            catch
            {
                throw;
            }

        }

        [HttpPost("delete/data")]
        public async Task<IActionResult> DeleteData([FromBody] ShopBridgeVM shopBridgeVM)
        {
            try
            {
                var response = await _shopBridgeServices.DeleteRecord(shopBridgeVM);
                return Ok(response);
            }
            catch
            {
                throw;
            }

        }

        [HttpPost("update/data")]
        public async Task<IActionResult> Update([FromBody] ShopBridgeVM shopBridgeVM)
        {
            try
            {
                var response = await _shopBridgeServices.UpdateRecord(shopBridgeVM);
                return Ok(response);
            }
            catch
            {
                throw;
            }

        }

    }
}
