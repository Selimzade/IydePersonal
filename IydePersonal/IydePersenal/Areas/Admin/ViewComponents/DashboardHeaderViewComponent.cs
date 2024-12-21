using AutoMapper;
using IydePersonal.Application.Dtos.User;
using IydePersonal.Domain.Entities.Edentity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IydePersonal.WEB.Areas.Admin.ViewComponents
{
    public class DashboardHeaderViewComponent:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public DashboardHeaderViewComponent(UserManager<AppUser> userManager,IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var logger = await _userManager.GetUserAsync(HttpContext.User);
            var map = _mapper.Map<UserListDto>(logger);

            var findrole = string.Join("", await _userManager.GetRolesAsync(logger));

            map.Role=findrole;

            return View(map);
        }
    }
}
