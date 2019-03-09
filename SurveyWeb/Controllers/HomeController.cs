using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SurveyWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validar(IFormCollection form)
        {
            int usuario = 0;
            string senha = "";

            int.TryParse(form["txtEmail"], out usuario);
            senha = form["txtSenha"];

            if (usuario == 1000 && senha == "123")
            {
                CookieOptions ck = new CookieOptions();
                ck.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("usuario", usuario.ToString(), ck);
                Response.Cookies.Append("nivel", "A", ck);

                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.Erro = "Usuário inválido.";
                return View("Index");
            }
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("usuario");
            Response.Cookies.Delete("nivel");

            return RedirectToAction("Index", "Home");
        }
    }
}