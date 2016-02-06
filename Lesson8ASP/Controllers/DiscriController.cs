using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson8ASP.Controllers
{
    public class DiscriController : Controller
    {
        //Напишите метод действия контроллера,который находит корни квадратного уравнения вида: ax2 + bx + c = 0, где a не равно 0.

        // GET: Discri
        [HttpGet]
        public string Index(int a = 0, int b = 0, int c = 0)     // параметры по умолчанию 
        {
            // передача параметров маршрутизация по умолчанию localhost:49836?a=10&b=5&c=0
            // передача параметров  localhost:49836/Discri/Index

            double d = b*b-4*a*c;
            double x1 = (-1 * b + Math.Sqrt(d)) / 2 * a;
            double x2 = (-1 * b - Math.Sqrt(d)) / 2 * a;
            return d.ToString()+" "+ x1.ToString()+" "+x2.ToString();
        }
    }
}