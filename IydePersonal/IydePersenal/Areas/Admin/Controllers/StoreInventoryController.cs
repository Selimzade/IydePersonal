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

        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet("GetInventories")]
        public async Task<IActionResult> GetInventories(int storeId)
        {
            var inventories = await _inventoryRepository.GetInventoriesByStoreIdAsync(storeId);
            return PartialView("_InventoryList", inventories);
        }

        public async Task <IActionResult> Index(int? storeId)
        {
            if (!storeId.HasValue)
            {
                return BadRequest("İnventar üçün mağaza seçilməyib!");
            }

            ViewBag.StoreId = storeId;
            var inventories = await _inventoryRepository.GetInventoriesByStoreIdAsync(storeId.Value);
            return View(inventories);
        }

        [HttpPost("AddInventory")]
        public async Task<IActionResult> AddInventory([FromBody] Inventory inventory,int? storeId)
        {
            if (!storeId.HasValue)
            {
                return BadRequest("İnventar üçün mağaza seçilməyib!");
            }

            ViewBag.StoreId = storeId;
            var inventories = await _inventoryRepository.GetInventoriesByStoreIdAsync(storeId.Value);
            
            if (!ModelState.IsValid)
            {
                return BadRequest("Düzgün məlumat daxil edilməyib!");
            }

            if (inventory.StoreId == 0)
            {
                return BadRequest("İnventar üçün mağaza seçilməyib!");
            }

            inventory.AddedDate = DateTime.Now;
            inventory.LastUpdated = DateTime.Now;

            await _inventoryRepository.AddInventoryAsync(inventory);
            return RedirectToAction("GetInventories", new { storeId = inventory.StoreId });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInventory(Inventory inventory)
        {
            await _inventoryRepository.UpdateInventoryAsync(inventory);
            return RedirectToAction("GetInventories", new { storeId = inventory.StoreId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteInventory(int id, int storeId)
        {
            await _inventoryRepository.DeleteInventoryAsync(id);
            return RedirectToAction("GetInventories", new { storeId });
        }
    }
}
