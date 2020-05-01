using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EConfiableBD;
using EConfiablePRC;

namespace EConfiableWEB.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            CiudadPRC db3 = new CiudadPRC();
            List<Ciudad_List_Result> LCiudad = new List<Ciudad_List_Result>();                     
            LCiudad = db3.Ciudad_List(null).ToList();
            ViewBag.ciu_codigo = new SelectList(LCiudad, "ciu_codigo", "ciu_nombre");
            return View();
        }
    }
}