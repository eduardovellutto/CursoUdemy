using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            List<Curso> list = new List<Curso>();
            list.Add(new Curso { IdCurso = 1, NameCurso = "Eletronics" });
            list.Add(new Curso { IdCurso = 1, NameCurso = "Fashion" });

            return View(list);
        }
    }
}