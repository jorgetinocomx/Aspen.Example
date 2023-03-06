using Aspen.Example.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aspen.Example.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserData _data;


        /// <summary>
        /// Injects the dependencies.
        /// </summary>
        /// <param name="logger">MS logger.</param>
        public UserController(ILogger<UserController> logger, IUserData data)
        {
            _logger = logger;
            _data = data;
        }

        /// <summary>
        /// Prints all the users.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var allUsers = _data
                            .Get()
                            .ToList();

            return View(allUsers);
        }
    }
}
