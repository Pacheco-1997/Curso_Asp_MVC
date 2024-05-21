using Curso_Asp_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curso_Asp_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                Id = 1,
                Nome = "Vanderlei",
                Tipo = "Adm"
            };

            ViewBag.Idddd = pessoa.Id;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            return View();
        }

        public ActionResult Contatos() 
        {
            return View();
        }

        public ActionResult About() 
        {
            return View();
        }
    }
}