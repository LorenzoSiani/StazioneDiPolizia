using StazioneDiPolizia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StazioneDiPolizia.Controllers
{
    public class AnagraficaController : Controller
    {
        // GET: Anagrafica
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Anagrafica a) 
        {
            if(ModelState.IsValid)
            {
                DataBase.AddAnagrafica(a.Cognome, a.Nome, a.Indirizzo, a.Città, a.CAP, a.Cod_Fis);
                return RedirectToAction("Index", "Home");

            }else return View();
        }

        
    }
}