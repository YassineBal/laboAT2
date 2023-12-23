using laboAT2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace laboAT2.Controllers
{
    public class InscriptionController : Controller
    {
        static int id_etudiant;
        // GET: Inscription
        public ActionResult Inscription()
        {
            //List<clsNiveauEducation> lst = new List<clsNiveauEducation>();

            //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\DEC\\AUTOMN2023\\AT2\\LABOAT2\\APP_DATA\\DBEDUCATIONAT2.MDF;Integrated Security=True");
            //con.Open();
            //string sql = "SELECT * FROM NiveauEducation";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //SqlDataReader myrder = cmd.ExecuteReader();

            //while (myrder.Read())
            //{
            //    lst.Add(new clsNiveauEducation() {  titre = myrder["titre"].ToString(), id = Convert.ToInt32(myrder["Id"]) });


            //}
            //myrder.Close();
            //con.Close();
            //ViewBag.nvEducation = lst;
            return View();
        }
        private bool sendEmail(string email, string message)
        {
            try
            {
                string MailSender = System.Configuration.ConfigurationManager.AppSettings["MailSender"].ToString();
                string MailPw = System.Configuration.ConfigurationManager.AppSettings["MailPw"].ToString();


                SmtpClient smtpClient = new SmtpClient("smtp.office365.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 100000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(MailSender, MailPw);


                MailMessage mailMessage = new MailMessage(MailSender, email.ToString(), "Authentification", message);

                mailMessage.BodyEncoding = System.Text.Encoding.UTF8;

                smtpClient.Send(mailMessage);

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }


        }

        [HttpPost]
        public ActionResult Inscription(clsEtudiant etudiant)
        {
            string nom = etudiant.nom.ToString().Trim();
            string prenom = etudiant.prenom.ToString().Trim();
            string email = etudiant.email.ToString().Trim();
            int Neducation = etudiant.Neducation;
            int idEtudiant=0;
            bool status = false;

            //insertion info etudiant dans la base de donnes 
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\DEC\\AUTOMN2023\\AT2\\LABOAT2\\APP_DATA\\DBEDUCATIONAT2.MDF;Integrated Security=True");
            con.Open();
            string sql = "insert into Etudiant (nom,prenom,email,Neducation,Status) values ('" + nom + "','" + prenom + "','" + email + "'," + Neducation + ",'"+ (status ? 1 : 0) + "')";
            SqlCommand mycmd = new SqlCommand(sql, con);
            mycmd.ExecuteNonQuery();
            con.Close();
            //extraction de idEtudiant 
            con.Open();
            string sqlID = "SELECT MAX(Id) AS Id from Etudiant";
            SqlCommand cmd = new SqlCommand(sqlID, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                idEtudiant = Convert.ToInt32(rdr["Id"]);
            }
            rdr.Close();
            con.Close();
           // generation du user et mdp et insertion dans la table Login


            string user = (nom + prenom).Substring(2);
            string password = (email.Substring(1, 3) + prenom.ToUpper()+"#"+nom+"#");
            con.Open();
            string sql2 = "INSERT INTO Login (us,mdp,id_Etudiant) VALUES ('" + user + "','" + password + "',"+idEtudiant+")";
            SqlCommand mycmd2 = new SqlCommand(sql2, con);
            mycmd2.ExecuteNonQuery();
            con.Close();
            
            //envoie de email 
            string message = "votre UserCode Est : " + user + "\n";
            message += "votre MotdePasse est : " + password;
            if (sendEmail(email, message))
            {

                ViewBag.mailStatus = "message sent";
                return View("login");

            }
            else
            {
                ViewBag.mailStatus = "message not sent";
                return View();
            }

            return View();
        }
        public bool savoirStatus(int idEtudiant)
        {
            bool status = false;
            SqlConnection mycon = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\DEC\\AUTOMN2023\\AT2\\LABOAT2\\APP_DATA\\DBEDUCATIONAT2.MDF;Integrated Security=True");
            mycon.Open();
           
            string sqlStatus = "SELECT Status FROM Etudiant where Id=" +idEtudiant;
            SqlCommand mycmd = new SqlCommand(sqlStatus, mycon );
            SqlDataReader myReader = mycmd.ExecuteReader();
            if (myReader.Read())
            {
                status =(Convert.ToInt32(myReader["Status"])==0)?  true :  false; // si 1ere fois c'est status true else false 
            }
            myReader.Close();
            mycon.Close();
            return status;

        }
        
        public int trouverIdEtudiant(string user, string password)
        {
            string us =user;
            string pd = password;

            int id_etudiant = 0;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\DEC\\AUTOMN2023\\AT2\\LABOAT2\\APP_DATA\\DBEDUCATIONAT2.MDF;Integrated Security=True");
            con.Open();
            string sql = "select * from Login where us='" + us + "' and mdp='" + pd + "'";
            SqlCommand mycd = new SqlCommand(sql, con);
            SqlDataReader myr = mycd.ExecuteReader();
            if (myr.Read())
            {
                 id_etudiant = Convert.ToInt32(myr["id_Etudiant"]);
                 TempData["idEtudiant"] = id_etudiant;

            }

            myr.Close();
            con.Close();
            return id_etudiant;
        }    

        [HttpPost]
        public ActionResult Login(clsLogin login)
        {
            //recuperation des donnes entree
            string us = login.user;
            string pd = login.password;
            TempData["user"] = us;
            TempData["password"] = pd;
            

            int id_etudiant=trouverIdEtudiant(us, pd);
           


                if (savoirStatus(id_etudiant) == true)
                {
                    return View ("renitialisation");

                }
                else
                {
                    return  View ("acceuil");
                }
                //myr.Close();
                //con.Close();
                
            //}

            return View();
            
          

        }
        public ActionResult Login()
        {
           
            return View();


        }
        public ActionResult renitialisation()
        {
            
            return View();
        }

        public void resetLogin(int idEtudiant,string newUser,string newPwd)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\DEC\\AUTOMN2023\\AT2\\LABOAT2\\APP_DATA\\DBEDUCATIONAT2.MDF;Integrated Security=True");
            con.Open();
            string sql = "update Login SET us='" + newUser + "', mdp='" + newPwd + "' WHERE id_Etudiant=" + idEtudiant;
            SqlCommand command= new SqlCommand(sql, con);
            command.ExecuteNonQuery();

        }
        public void setStatusTrue(int idEtudiant)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\DEC\\AUTOMN2023\\AT2\\LABOAT2\\APP_DATA\\DBEDUCATIONAT2.MDF;Integrated Security=True");
            con.Open();
            string sql = "update Etudiant SET Status=" + 1 + " WHERE Id=" + idEtudiant;
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();

        }
        public string getEmail(int idEtudiant)
        {
            string emailTo="";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\DEC\\AUTOMN2023\\AT2\\LABOAT2\\APP_DATA\\DBEDUCATIONAT2.MDF;Integrated Security=True");
            con.Open();
            string sql = "SELECT email From Etudiant WHERE Id=" + idEtudiant;
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                emailTo = reader["email"].ToString();
               
            }
            reader.Close();
            con.Close();
            return emailTo;
            
            
        }
        

        [HttpPost]
        public ActionResult renitialisation(clsLogin reset)
        {
            string newUs = reset.user;
            string newPwd = reset.password;

            int idEtudiant = Convert.ToInt32(TempData["idEtudiant"]);

            resetLogin(idEtudiant,newUs, newPwd);
            setStatusTrue(idEtudiant);

            string message = "votre UserCode Est : " + newUs + "\n";
            message += "votre MotdePasse est : " + newPwd;
            string emailTo = getEmail(idEtudiant);
            sendEmail(emailTo,message);



            return View("login");
        }

        
        public ActionResult acceuil()
        {
            
            List<Cours> lstCours = ListCours();

            return View(lstCours);
            

        }

        private List<Cours> ListCours(string us , string pd)
        {
            us = TempData["user"].ToString();
            us = TempData["password"].ToString();
            int idEtudiant = trouverIdEtudiant(us,pd);
            //int idEtudiant =Convert.ToInt32( TempData["idEtudiant"]);
            List<Cours> lstCours = new List<Cours>();
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\DEC\\AUTOMN2023\\AT2\\LABOAT2\\APP_DATA\\DBEDUCATIONAT2.MDF;Integrated Security=True");
            con.Open();
            try
            {
                string sql = "SELECT  Neducation from  Etudiant where Id=" + idEtudiant;
                SqlCommand cmd =new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                int nEducation= 0;
                while (reader.Read())
                {
                    nEducation = Convert.ToInt32(reader["Neducation"]);
                }
                reader.Close();
                cmd = new SqlCommand("Select * from Cours where niveauEducation=@nEducation", con);
                cmd.Parameters.AddWithValue("@nEducation", nEducation);
                SqlDataReader reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    lstCours.Add(new Cours
                    {
                        titre = reader2["titre"].ToString(),
                        prix =Convert.ToInt32( reader2["prix"]),
                        desc = reader2["desc"].ToString(),
                        img = reader2["img"].ToString()
                    });

                }
                reader2.Close();
            }
            catch (Exception ex)
            {
                ViewBag.errmsg = ex.Message;
            }
            finally
            {
                con.Close();
            }

            return lstCours;
        }
    }
}