using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using pryecto_nicol.Models;
using pryecto_nicol.Services;

namespace pryecto_nicol.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {

        private readonly IUserinterface usuarioService;

        public UserController(IUserinterface usuarioService)
        {
            this.usuarioService = usuarioService;
        }


        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(usuarioModel1 usuario)
        {
            if (ModelState.IsValid)
            {
                await usuarioService.crearUsuario(usuario);
                return RedirectToAction("Index", "Home");
            }
         return View(usuario);
        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }
          
    }
}