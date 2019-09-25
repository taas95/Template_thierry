using System.Collections.Generic;
using System.Linq;
using Gestion_Location.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Utility.Interfaces;

namespace Gestion_Location.Controllers
{
    public class Proprietaire : Controller
    {
        private readonly rentmanagerContext Context;
        private readonly IGenerators Generators;

        public Proprietaire(rentmanagerContext context, IGenerators generators)
        {
            Context = context;
            Generators = generators;
        }
        // GET

        public IActionResult Index()
        {
            IEnumerable<Models.Proprietaire> list = Context.Proprietaires.ToList();
            PropriAll data = new PropriAll()
            {
                ListPropri = list
            };
            return View(data);
        }

        public IActionResult ShowModal()
        {
            return View("_addProprioModal");
        }


        [HttpGet]
        public IActionResult AddProprio()
        {
            return View("_addProprioModal");
        }
        
        [HttpPost]
        public IActionResult Index(PropriAll propriAll)
        {
            if (ModelState.IsValid)
            {
                Models.Proprietaire data = new Models.Proprietaire()
                {
                    id = Generators.PolyIdGenerator(10),
                    adresse = propriAll.Apropri.adresse,
                    nom = propriAll.Apropri.nom,
                    prenom = propriAll.Apropri.prenom,
                    telephone = propriAll.Apropri.telephone
                };
                Context.Proprietaires.Add(data);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}