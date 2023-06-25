using Infarstructure.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountsController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountsController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Roles()
        {

            return View(new RolesViewModel
            {
                NewRole = new NewRole(),
                Roles = _roleManager.Roles.OrderBy(x => x.Name).ToList()
            });

           // return View( new RolesViewModel
           // {
           //     NewRole = new NewRole(),
           //     Roles = _roleManager.Roles.OrderBy(x => x.Name).ToList()

           // }

           //);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Roles(RolesViewModel model)
        {
            if(ModelState.IsValid)
            {
                var role = new IdentityRole
                {
                    Id = model.NewRole.RoleId,
                    Name = model.NewRole.RoleName

                };
                //create
                if(role.Id==null)
                {
                    role.Id=Guid.NewGuid().ToString();
                    var result=await _roleManager.CreateAsync(role);
                    if(result.Succeeded)
                    { }
                    else //Not succeded 
                    {

                    }
                }
                //update 
                else
                {

                }
            }
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }
    }
}
