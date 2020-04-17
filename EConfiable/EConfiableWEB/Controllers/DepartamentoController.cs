using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EConfiableBD;
using EConfiablePRC;


namespace EConfiableWEB.Controllers
{
    public class DepartamentoController : Controller
    {

        DepartamentoPRC db = new DepartamentoPRC();

        private EConfiableEntities Bd = new EConfiableEntities();
        public ActionResult Index()
        {
            ViewBag.pai_codigo = new SelectList(Bd.Pais, "pai_codigo", "pai_nombre");
            return View();
        }


        /// <summary>
        /// Metodos que permite obtener el listado de la tabla Pais
        /// </summary>
        /// <returns></returns>
        public ActionResult GetData()
        {
            List<Departamento_List_Result> TDepartamento = db.Departamento_List(null).ToList();
            return Json(new { data = TDepartamento }, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Metodo que permite Insertar o Actualizar datos en la tabla Pais
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public JsonResult PostData(Departamento data, int id)
        {
            string Respuesta = string.Empty;
            if (id != 1)
            {
                if (ModelState.IsValid)
                {
                    db.Departamento_Insert(data.dep_codigo, data.dep_nombre, data.pai_codigo);
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
                    db.Departamento_Update(data.dep_codigo, data.dep_nombre, data.pai_codigo);
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
            db.Departamento_Delete(id);
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
            List<Departamento_List_Result> tDepartamento = db.Departamento_List(id).ToList();
            return Json(tDepartamento.FirstOrDefault(), JsonRequestBehavior.AllowGet);
        }



    }
}