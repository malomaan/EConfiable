using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EConfiableBD;
using EConfiablePRC;


namespace EConfiableWEB.Controllers
{
    public class CiudadController : Controller
    {


        private EConfiableEntities db2 = new EConfiableEntities();
        private CiudadPRC db = new CiudadPRC();


        public ActionResult Index()
        {
            ViewBag.pai_codigo = new SelectList(db2.Departamento, "dep_codigo", "dep_nombre");
            return View();
        }


        /// <summary>
        /// Metodos que permite obtener el listado de la tabla Pais
        /// </summary>
        /// <returns></returns>
        public ActionResult GetData()
        {
            List<Ciudad_List_Result> TCiudad = db.Ciudad_List(null).ToList();
            return Json(new { data = TCiudad }, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Metodo que permite Insertar o Actualizar datos en la tabla Pais
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public JsonResult PostData(Ciudad data, int id)
        {
            string Respuesta = string.Empty;
            if (id != 1)
            {
                if (ModelState.IsValid)
                {
                    db.Ciudad_Insert(data.ciu_codigo, data.ciu_nombre, data.ciu_predeterminado, data.ciu_latitud, data.ciu_latitud, data.dep_codigo);
                    Respuesta = "success";
                }
                else
                {
                    Respuesta = "Debe registrar información";
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    db.Ciudad_Update(data.ciu_codigo, data.ciu_nombre, data.ciu_predeterminado, data.ciu_latitud, data.ciu_latitud, data.dep_codigo); ;
                    Respuesta = "success";
                }
                else
                {
                    Respuesta = "Debe registrar información";
                }

            }
            return Json(Respuesta, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Metodo que permite Eliminar registos de la tabla Paise
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult DeleteRow(string id)
        {
            db.Ciudad_Delete(id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Metodo que permite obtener un registro de la tabla Pais
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet]
        public ActionResult GetEdit(string id)
        {
            List<Ciudad_List_Result> TCiudad = db.Ciudad_List(id).ToList();
            return Json(TCiudad.FirstOrDefault(), JsonRequestBehavior.AllowGet);
        }



    }
}