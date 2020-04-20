using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EConfiablePRC;
using EConfiableBD;


namespace EConfiableWEB.Controllers
{
    public class TipoSociedadController : Controller
    {

        private TiposociedadPRC db = new TiposociedadPRC();

        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Metodos que permite obtener el listado de la tabla Pais
        /// </summary>
        /// <returns></returns>
        public ActionResult GetData()
        {
            List<Tiposociedad_List_Result> TTipoSociedad = db.Tiposociedad_List(null).ToList();
            return Json(new { data = TTipoSociedad }, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Metodo que permite Insertar o Actualizar datos en la tabla Pais
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public JsonResult PostData(TipoSociedad data, int id)
        {
            string Respuesta = string.Empty;
            if (id != 1)
            {
                if (ModelState.IsValid)
                {
                    db.Tiposociedad_Insert(data.tso_descripcion);
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
                    db.Tiposociedad_Update(data.tso_id,data.tso_descripcion);
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
        public JsonResult DeleteRow(int id)
        {
            db.Tiposociedad_Delete(id);
            return Json("success", JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Metodo que permite obtener un registro de la tabla Pais
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet]
        public ActionResult GetEdit(int id)
        {
            List<Tiposociedad_List_Result> TTipoSociedad = db.Tiposociedad_List(id).ToList();
            return Json(TTipoSociedad.FirstOrDefault(), JsonRequestBehavior.AllowGet);
        }

    }
}