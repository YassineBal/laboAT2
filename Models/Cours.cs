using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laboAT2.Models
{
    public class Cours
    {
        public string titre { get; set; }
        public string desc { get; set; }
        public string img { get; set; }
        public double prix { get; set; }
        public string niveauEducation { get; set; }
    }
}