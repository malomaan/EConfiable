using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EConfiableBD;
using EConfiablePRC;


namespace EConfiableWEB.Controllers
{
    public class PaisController : Controller
    {

        PaisBD db = new PaisBD();


        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Obtener el listado de la tabla Pais
        /// </summary>
        /// <returns></returns>
        public ActionResult GetData()
        {
            List<Pais_List_Result> TPais = db.Pais_List(null).ToList();
            return Json(new { data = TPais }, JsonRequestBehavior.AllowGet);
        }

    }
}