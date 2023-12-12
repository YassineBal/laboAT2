using laboAT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace laboAT2.Controllers
{
    public class EnseignantController : Controller
    {
        private enseignantDataContext db;
        
        // GET: Enseignant
        public ActionResult loginEnseignant()
        {
            return View();
        }

        [HttpPost]
        public ActionResult loginEnseignant(enseignant ens)
        {
            string email = ens.email;
            string mdp = ens.mdp;

           db = new enseignantDataContext();

        enseignant res = (from v in db.enseignants
                         where v.email == email && v.mdp == mdp
                         select v).Single<enseignant>();

            if (res == null)
            {
                return View("loginEnseignant");
            }
            else {
                return View("home");

            }

        }
        public ActionResult home()
        {
            return View();
        }
        public ActionResult ajoutCours()
        {
            db = new enseignantDataContext();


            cour res = (from v in db.cours
                        select v).Single<cour>();

            //ajouter les info dans un view bag

            return View();
        }

        public ActionResult ajoutVideo()
        {
            return View();
        }




    }
}