using AlmoxarifadoMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlmoxarifadoMVC.Controllers
{
    public class ColaboradorController : Controller
    {

        BDAlmoxarifado bd = new BDAlmoxarifado();

        // GET: Colaborador
        public ActionResult Index()
        {
            return View(bd.Colaborador.ToList());
        }

       





        [HttpGet]

        public ActionResult Criar()
        {
            ViewBag.listaArea = bd.Area.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Criar(string nome, string cargo, int area)
        {
            Colaborador novoColaborador = new Colaborador();

            
            novoColaborador.ColNome = nome;
            novoColaborador.ColCargo = cargo;
            novoColaborador.AreaID = area;
            bd.Colaborador.Add(novoColaborador);
            bd.SaveChanges();

            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Colaborador Colatualizar = bd.Colaborador.ToList().Where(x => x.ColID == id).First();
            return View(Colatualizar);
        }

        [HttpPost]
        public ActionResult Edit(int? id, string nome, string cargo, int area)
        {
            Colaborador Colatualizar = bd.Colaborador.ToList().Where(x => x.ColID == id).First();
            Colatualizar.ColNome = nome;
            Colatualizar.ColCargo = cargo;
            Colatualizar.AreaID = area;


            bd.Entry(Colatualizar).State = EntityState.Modified;

            bd.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Deletar(int? id)
        {
            Colaborador ColDeletar = bd.Colaborador.ToList().Where(x => x.ColID == id).First();
            return View(ColDeletar);
        }

        [HttpPost]
        public ActionResult ConfirmeDelete(int? id)
        {
            Colaborador ColDeletar = bd.Colaborador.ToList().Where(x => x.ColID == id).First();
            bd.Colaborador.Remove(ColDeletar);
            try
            {
                bd.SaveChanges();
            }
            catch
            {
                return RedirectToAction("Erro");
            }





            return RedirectToAction("Index");
        }
        public ActionResult Exibir(int? id)
        {

            Colaborador ColExibir = bd.Colaborador.ToList().Where(x => x.ColID == id).First();
            return View(ColExibir);
        }
    }
}