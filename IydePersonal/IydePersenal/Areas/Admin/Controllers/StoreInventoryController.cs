using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities;
using IydePersonal.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]  // Əgər Admin sahəsindədirsə
    [Route("Admin/StoreInventory")]
    public class StoreInventoryController : Controller
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly AppDbContext _appDbContext;

        public StoreInventoryController(IInventoryRepository inventoryRepository, AppDbContext appDbContext)
        {
            _inventoryRepository = inventoryRepository;
            _appDbContext = appDbContext;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var stores = await _appDbContext.Stores.ToListAsync();
            return View(stores);
        }

        [HttpGet("GetInventories")]
        public async Task<IActionResult> GetInventories(int storeId)
        {
            var inventories = await _inventoryRepository.GetInventoriesByStoreIdAsync(storeId);
            return Json(inventories);
        }
       
        //public async Task<IActionResult> Index(int? storeId)
        //{
        //    if (!storeId.HasValue)
        //    {
        //        return BadRequest("İnventar üçün mağaza seçilməyib!");
        //    }

        //    ViewBag.StoreId = storeId.Value;
        //    var inventories = await _inventoryRepository.GetInventoriesByStoreIdAsync(storeId.Value);
        //    return View(inventories);
        //}

       
        [HttpPost("AddInventory")]
        public async Task<IActionResult> AddInventory([FromBody] Inventory inventory)
        {
            if (inventory.StoreId == 0)
            {
                return BadRequest("Xəta: Mağaza seçilməyib!");
            }

            inventory.AddedDate = DateTime.Now;
            inventory.LastUpdated = DateTime.Now;

            await _inventoryRepository.AddInventoryAsync(inventory);
            return Ok("İnventar uğurla əlavə edildi!");
        }

        [HttpPost("UpdateInventory")]
        public async Task<IActionResult> UpdateInventory([FromBody] Inventory inventory)
        {
            if (inventory == null || inventory.Id == 0)
            {
                return BadRequest("Xəta: İnventar tapılmadı!");
            }
            inventory.LastUpdated = DateTime.Now;
            await _inventoryRepository.UpdateInventoryAsync(inventory);
            return RedirectToAction("GetInventories", new { storeId = inventory.StoreId });
        }

        [HttpPost("DeleteInventory")]
        public async Task<IActionResult> DeleteInventory(int id, int storeId)
        {
            if (id == 0)
            {
                return BadRequest("Xəta: İnventar tapılmadı!");
            }
            await _inventoryRepository.DeleteInventoryAsync(id);
            return RedirectToAction("GetInventories", new { storeId });
        }
    }
}
