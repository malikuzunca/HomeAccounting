using HomeAccounting.DATA.Identity;
using HomeAccounting.DATA.ORM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HomeAccounting.ADMIN.Controllers
{
    public class LoginController : Controller
    {
        private readonly IDapper db;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        #region Ctor

        public LoginController(IDapper dapper, UserManager<AppUser> userManager, SignInManager<AppUser> singInManager, RoleManager<AppRole> roleManager)
        {
            this.db = dapper;
            this._userManager = userManager;
            this._signInManager = singInManager;
            this._roleManager = roleManager;
        }

        #endregion

        #region Kullanıcı Girişi
        [Route("app-login")]
        public IActionResult AdminLogin()
        {
            return View();
        }

        #endregion
    }
}
