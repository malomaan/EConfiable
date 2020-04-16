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

        PaisPRC db = new PaisPRC();


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
            List<Pais_List_Result> TPais = db.Pais_List(null).ToList();
            return Json(new { data = TPais }, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Metodo que permite Insertar o Actualizar datos en la tabla Pais
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public JsonResult PostData(Pais data,int id)
        {
            string Respuesta = string.Empty;
            if (id != 1)
            {
                if (ModelState.IsValid)
                {
                    db.Pais_Insert(data.pai_codigo, data.pai_nombre, data.pai_codigointernacional, data.pai_predeterminado);
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
                    db.Pais_Update(data.pai_codigo, data.pai_nombre, data.pai_codigointernacional, data.pai_predeterminado);
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
            db.Pais_Delete(id);
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
            EConfiableEntities bd = new EConfiableEntities();
            //List<Pais_List_Result> TPais = db.Pais_List(id).ToList();
            Pais tPais = bd.Pais.Find(id);
            return Json(tPais, JsonRequestBehavior.AllowGet);
        }


    }
}