using AutoMapper;
using IydePersonal.Application.Dtos.Shop;
using IydePersonal.Application.Dtos.Store;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class StoreController : Controller
    {
        private readonly IStoryService _storyService;
        private readonly IMapper _mapper;

        public StoreController(IStoryService storyService,IMapper mapper)
        {
            _storyService = storyService;
            _mapper = mapper;
        }

        public async Task <IActionResult> Index()
        {
            var store=await _storyService.AllStoreDtos();
            return View(store);
        }


        [HttpGet]
        public async Task<IActionResult> Add() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(StoreCreateDto storeCreateDto) 
        {
            //var map=  _mapper.Map<Store>(storeCreateDto);
             await _storyService.AddStore(storeCreateDto);
            return RedirectToAction("Index", "Store", new { Area= "Admin"});
        }
        [HttpGet]
        public async Task<IActionResult> Update(int StoreId) 
        {
            var store=await _storyService.GetStoreByIdAsync(StoreId);
            var map=_mapper.Map<StoreUpdateDto>(store);
            return View(map);
        }
        [HttpPost]
        public async Task<IActionResult> Update(StoreUpdateDto storeUpdateDto) 
        {
            await _storyService.UpdateStoreAsync(storeUpdateDto);
            return RedirectToAction("Index", "Store", new { Area = "Admin" });
        }

        [HttpPost]
        [Route("Admin/Store/Delete/{PunktId}")]
        public async Task <IActionResult> Delete (int PunktId) 
        {
            await _storyService.DeleteStoreAsync(PunktId);
            return RedirectToAction("Index", "Store", new { Area = "Admin" });
        }

    }
}
