using AlmoxarifadoMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlmoxarifadoMVC.Controllers
{
    public class AreaController : Controller
    {

        BDAlmoxarifado bd = new BDAlmoxarifado();
        // GET: Area
        public ActionResult Index()
        {
            return View(bd.Area.ToList());
        }

        // GET: Criar
        public ActionResult Criar()
        {
            return View();
        }

        public ActionResult Erro()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Criar(string descricao)
        {
            Area novaArea = new Area();

            novaArea.AreaDescricao = descricao;
            

            bd.Area.Add(novaArea);
            bd.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Area Areaatualizar = bd.Area.ToList().Where(x => x.AreaID == id).First();
            return View(Areaatualizar);
        }

        [HttpPost]
        public ActionResult Edit(int? id, string descricao)
        {
            Area Areaatualizar = bd.Area.ToList().Where(x => x.AreaID == id).First();
            Areaatualizar.AreaDescricao = descricao;


            bd.Entry(Areaatualizar).State = EntityState.Modified;

            bd.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Deletar(int? id)
        {
            Area AreDeletar = bd.Area.ToList().Where(x => x.AreaID == id).First();
            return View(AreDeletar);
        }

        [HttpPost]
        public ActionResult ConfirmeDelete(int? id)
        {
            Area AreDeletar = bd.Area.ToList().Where(x => x.AreaID == id).First();
            bd.Area.Remove(AreDeletar);
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

            Area AreExibir = bd.Area.ToList().Where(x => x.AreaID == id).First();
            return View(AreExibir);
        }
    }
}