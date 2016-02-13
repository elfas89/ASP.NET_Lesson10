using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson10ASP.Controllers
{
    public class FirstController : Controller
    {
        //Напишите метод действия контроллера, который принимает числовой параметр и возвращает одно из трех представлений:
        //– представление, которое указывает, что параметр равен нулю;
        //– представление, которое указывает, что параметр меньше нуля;
        //– представление, которое указывает, что параметр больше нуля.


        // GET: First
        public ActionResult Index(int param=0)
        {
            if (param == 0)
            {
                return View("~/Views/First/Index1.cshtml");
            }

            else if (param > 0)
            {
                return View("~/Views/First/Index2.cshtml");
            }
            else if (param < 0)
            {
                return View("~/Views/First/Index3.cshtml");
            }
            else return View();
        }



        //Напишите метод действия контроллера, который принимает минимальное и максимальное значения 
        //    целого числового диапазона (по умолчанию оба значения равны 0). 
        //Метод возвращает представление, которое выводит все цифры из этого диапазона.
        //Реализуйте 2 версии текущего задания, используя:
        //1.Не строго типизированное представление;
        //2.Строго типизированное представление.

        //localhost:50676/First/MinMax?min=1&max=56

        public ActionResult MinMax(int min = 0, int max = 0)
        {
            //int[] nums = new int[(max - min) + 1];
            List<int> list = new List<int>();
            for (int i = min; i <= max; i++)
            {
                list.Add(i);
              
            }

            ViewBag.Res = list;

            return View(list);
        }


    }
}