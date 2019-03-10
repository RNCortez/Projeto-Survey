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
            string email = "";
            string senha = "";

            email =form["txtEmail"];
            senha = form["txtSenha"];

            if (email == "teste@teste" && senha == "123")
            {
                CookieOptions ck = new CookieOptions();
                ck.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("usuario", "Teste", ck);
                Response.Cookies.Append("email", "teste@teste", ck);
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