using ServicesTest.AppCode;
using ServicesTest.AppData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace ServicesTest
{
    /// <summary>
    /// Descripción breve de DenunciaALV
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class DenunciaALV : ServicioBase
    {

        [SoapHeader("Credenciales")]
        [WebMethod]
        public Respuesta GenerarDenuncia(Denuncia denuncia)
        {
            Respuesta respuesta = new Respuesta();
            if (Credenciales.IsValid())
            {
                DenunciaDAO db = new DenunciaDAO(ConfigurationManager.ConnectionStrings["ConnStr"]);
                DataSet resultado = db.InsertarDenuncia(denuncia);
                respuesta.Codigo = 0;
                respuesta.Descripcion = "Exito";
            }
            else
            {
                respuesta.Codigo = 404;
                respuesta.Descripcion = "Error";
            }
            return respuesta;
        }
    }
}
