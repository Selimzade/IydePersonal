using AutoMapper;
using IydePersonal.Application.Dtos.User;
using IydePersonal.Domain.Entities.Edentity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.WEB.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<AppUser> userManager,IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task <IActionResult> Index()
        {
            var users= await _userManager.Users.ToListAsync();
            var map= _mapper.Map<List<UserListDto>>(users);

            foreach (var item in map)
            {
                var finduser = await _userManager.FindByIdAsync(item.Id.ToString());
                var role = string.Join ( "", await _userManager.GetRolesAsync(finduser));
                item.Role = role;
            }

            return View(map);
        }
    }
}
