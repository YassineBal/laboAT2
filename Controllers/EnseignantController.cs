using laboAT2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
                TempData["idEnseignant"] = res.id;
                return View("home");

            }

        }
        public ActionResult home()
        {
            return View();
        }
       


        public List<NiveauEducation> GetNiveauEtudes()
        {


            enseignantDataContext db = new enseignantDataContext();

            List<NiveauEducation> lstn = new List<NiveauEducation>();
                try
                {
                   lstn = db.NiveauEducations.ToList();
                    return lstn;
                }
                catch (Exception ex)
                {
                    ViewBag.errmsg = ex.Message;
                }

                return lstn;
            
        }
        public ActionResult ajoutCours()
        {

           // enseignantDataContext db = new enseignantDataContext();
            List<NiveauEducation> lstn = GetNiveauEtudes();
            ViewBag.courses = lstn;
            return View();
        }
        [HttpPost]
        public ActionResult ajoutCours(cour cours, int Id, HttpPostedFileBase img)
        {
            enseignantDataContext db = new enseignantDataContext();
           
                int niveauEducation = Id;   //id niveau education
            int idEnseignant = 0;
                idEnseignant = Convert.ToInt16(TempData["idEnseignant"]);
            if (idEnseignant > 0)
            {
                string titre = cours.titre;
                double prix = Convert.ToDouble(cours.prix);
                string desc = cours.description;
                var path = Path.Combine(Server.MapPath("~/img"), img.FileName);
                img.SaveAs(path);
                string image = path;
                var cs = new cour
                {
                    titre = titre,
                    niveauEducation = niveauEducation,
                    description = desc,
                    img = image,
                    idEnseignant = idEnseignant,
                    prix = prix


                };

                db.cours.InsertOnSubmit(cs);
                db.SubmitChanges();


                return View("home");
            }

            else
            {

                return View();
            }
            
        }

        public ActionResult ajoutVideo()
        {
            List<NiveauEducation> lstn = GetNiveauEtudes();
            ViewBag.courses = lstn;
            
            return View();
        }
        [HttpPost]
        public ActionResult ajoutVideo(video Video, HttpPostedFileBase vid,int Id)
        {
            enseignantDataContext db = new enseignantDataContext();
            
           
                int niveauEducation = Id;   //id niveau education

                string titre = Video.titre;
                var path = Path.Combine(Server.MapPath("~/img"), vid.FileName);
                vid.SaveAs(path);
                string videoPath = path;
                Int32 duree = vid.ContentLength;
                string desc = Video.description;

                var vd = new video
                {
                    titre = titre,
                    niveauEducation = niveauEducation,
                    description = desc,
                    lien = videoPath,
                    dure = duree
                };

                db.videos.InsertOnSubmit(vd);
                db.SubmitChanges();

                return View("home");

            
           
               
            
        }
        public ActionResult ajoutVideo_Cours()
        {
            enseignantDataContext db = new enseignantDataContext();
            int id_enseignant = 0;
            id_enseignant= Convert.ToInt32(TempData["idEnseignant"]);
            if (id_enseignant != 0)
            {
                
                var vids = db.videos.ToList();
                var cours = (from c in db.cours
                             where c.idEnseignant == id_enseignant
                             select c).ToList();
                ViewBag.cours = cours;
                ViewBag.videos = vids;
            }
            return View();
        }
        [HttpPost]
        public ActionResult ajoutVideo_Cours(int idVideo, int idCours)
        {
            enseignantDataContext db = new enseignantDataContext();
            videoCour videoCours = new videoCour();
            videoCours.idCours = idCours;
            videoCours.idVideo = idVideo;
            db.videoCours.InsertOnSubmit(videoCours);
            db.SubmitChanges();
            return View("home");
        }


    }
}