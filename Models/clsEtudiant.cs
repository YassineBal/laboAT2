using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace laboAT2.Models
{
    public class clsEtudiant
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public int Neducation { get; set; }
        public string titre { get; set; }
        public bool status { get; set; }
    }
}