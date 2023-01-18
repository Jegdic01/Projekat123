using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Projekat123.Models
{
    public class Forma
    {
        public string Ime { get; set; }
        public string  Prezime { get; set; }
        public string  Email { get; set; }
        public int  OcenaUsluge { get; set; }
        public string  Poruka { get; set; }
    }
}