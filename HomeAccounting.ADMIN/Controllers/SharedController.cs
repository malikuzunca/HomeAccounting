using HomeAccounting.DATA.ORM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeAccounting.ADMIN.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SharedController : Controller
    {
        private readonly IDapper db;
        private readonly IConfiguration configuration;
        private readonly ILogger<SharedController> logger;

        #region Ctor

        public SharedController(IDapper dapper, IConfiguration? configuration, ILogger<SharedController> logger)
        {
            this.db = dapper;
            this.configuration = configuration;
            this.logger = logger;
        }

        #endregion
    }
}
