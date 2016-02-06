using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson8ASP
{
    public class ThirdController : Controller
    {
        //Напишите перегруженный метод действий котроллера, одна версия для метода GET, другая для метода POST. 
        //К данному методу действий написать представление 


        //при первом запуске - GET
        [HttpGet]
        public ViewResult Ind()
        {
            //ViewBag.Res = "Имя не указано";
            ViewBag.Method = Request.HttpMethod;
            return View();
        }

        [HttpPost]
        public ViewResult Ind(string field)
        {
            if (field != "")
            {
                ViewBag.Res = "Привет, " + field;
            }
            else
            {
                ViewBag.Res = "Укажите имя.";
            }
            ViewBag.Method = Request.HttpMethod;
            return View();
        }

    }
}