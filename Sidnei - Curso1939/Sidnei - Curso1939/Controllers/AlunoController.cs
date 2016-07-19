using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sidnei___Curso1939.Models;

namespace Sidnei___Curso1939.Controllers
{
    [RoutePrefix("alunos")]
    public class AlunoController : Controller
    {
        // GET: Aluno
        [Route("listar")]
        public ActionResult Index()
        {
            Aluno sidnei = new Aluno
            {
                AlunoId = 1,
                CPF = "383",
                Email = "sidneipsj@gmail.com",
                Nome = "Sidnei Sanches"
            };
            IList<Aluno> alunos = new List<Aluno>();
            alunos.Add(sidnei);
           
            

            return View(alunos);
        }

        [Route("criar")]
        public ActionResult Create()
        {
            ModelState.AddModelError("Mensagem", "Algum erro ocorreu");
            return View();
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(Aluno aluno)
        {
            return RedirectToAction("Index");
        }
    }
}