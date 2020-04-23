using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EConfiableBD;
using EConfiablePRC;

namespace EConfiableWEB.Controllers
{
    public class TipoOrganizacionController : Controller
    {
        private TipoorganizacionPRC db = new TipoorganizacionPRC();

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
            List<Tipoorganizacion_List_Result> TTipoSociedad = db.Tipoorganizacion_List(null).ToList();
            return Json(new { data = TTipoSociedad }, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Metodo que permite Insertar o Actualizar datos en la tabla Pais
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public JsonResult PostData(TipoOrganizacion data, int id)
        {
            string Respuesta = string.Empty;
            if (id != 1)
            {
                if (ModelState.IsValid)
                {
                    db.Tipoorganizacion_Insert(data.tor_descripcion);
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
                    db.Tipoorganizacion_Update(data.tor_id, data.tor_descripcion);
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
            db.Tipoorganizacion_Delete(id);
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
            List<Tipoorganizacion_List_Result> TTipoSociedad = db.Tipoorganizacion_List(id).ToList();
            return Json(TTipoSociedad.FirstOrDefault(), JsonRequestBehavior.AllowGet);
        }
    }
}