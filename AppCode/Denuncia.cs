using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesTest.AppData
{
    public class Denuncia
    {
        public string fecha_suceso { get; set; }
        public string lugar { get; set; }
        public string involucrado { get; set; }
        public bool trabaja_dt { get; set; }
        public string prioridad { get; set; }
        public string tipo { get; set; }
        public string hechos { get; set; }
        public string token { get; set; }
    }
}