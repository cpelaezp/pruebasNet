using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using WebAppPrueba.Models;

namespace WebAppPrueba.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["tramites"] = getJsonData<Tramites>("tramites.json");
            ViewData["opiniones"] = getJsonData<Opiniones>("opiniones.json");
            ViewData["informate"] = getJsonData<Informate>("informate.json");
            ViewData["temasinteres"] = getJsonData<TemasInteres>("temasinteres.json");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public List<T> getJsonData<T>(string _url)
        {
            List<T> _return = new List<T>();

            var dataFile = Server.MapPath("~/App_Data/" + _url);
            string _Json = System.IO.File.ReadAllText(dataFile);
            _return = JsonConvert.DeserializeObject<List<T>>(_Json);

            return _return;
        }
    }
}