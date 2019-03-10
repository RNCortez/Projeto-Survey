using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyWeb.Filters;
using SurveyWeb.Models;

namespace SurveyWeb.Controllers
{
    public class QuestionariosController : Controller
    {
        [ValidarAcesso]
        public IActionResult Index()
        {
            return View();
        }

        



    }
}