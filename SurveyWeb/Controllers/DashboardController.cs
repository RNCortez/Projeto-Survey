using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyWeb.Filters;

namespace SurveyWeb.Controllers
{
    public class DashboardController : Controller
    {

        [ValidarAcesso]
        public IActionResult Index()
        {
            return View();
        }
    }
}