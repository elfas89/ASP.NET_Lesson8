using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson8ASP.Controllers
{
    public class SecondController : Controller
    {
        //Напишите результат действий, который принимает массив строк, генерирует HTML-код
        //, в теле которого должны быть размещены все строки массива и возвращает пользователю.

        // GET: Second
        [HttpGet]
        public ActionResult GetHtml(string[] a)
        {

        //передача параметров в массив localhost:49836/Second/GetHtml?a=10&a=5&a=-1

            string text="<ol>";
            foreach (string item in a)
            {
                text += "<li>" + item + "</li>";
            }
            text += "</ol>";
            return new HtmlResult(text);    
         
            
        }
    }
}