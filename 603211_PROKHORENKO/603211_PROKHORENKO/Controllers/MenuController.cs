﻿using _603211_PROKHORENKO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _603211_PROKHORENKO.Controllers
{

    public class MenuController : Controller
    {
        


        //коллекцию исходных данных меню:
        List<MenuItem> items;

        // конструктор класса MenuController и заполните коллекцию items:
        public MenuController()
        {
            items = new List<MenuItem>
            {
                new MenuItem { Name = "Домой", Controller = "Home", Action = "Index", Active = string.Empty },
                new MenuItem { Name = "Каталог", Controller = "Product", Action = "List", Active = string.Empty },
                new MenuItem { Name = "Администрирование", Controller = "Admin", Action = "Index", Active = string.Empty }
            };
        }

        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        // «заглушки» методов:
        /*
public string Main()
        {
            return "<span>Главное меню</span>";
        }
        */
        /*
        public PartialViewResult Main()
        {
            return PartialView();
        }
        */
        /*
          Измените метод Main контроллера Menu:
       Параметр “с” (Controller) автоматически передаются методу из запроса.
       Для элемента списка меню, у которого совпадают параметр Controller с
       полученным параметром, устанавливается свойство Active.
         */
        
        public PartialViewResult Main(string a = "Index", string c = "Home")
        {
            items.First(m => m.Controller == c).Active = "active";
            return PartialView(items);
        }


        /*
        public string UserInfo()
        {
            return "<span>Меню пользователя </ span > ";
        }
        */
        public PartialViewResult UserInfo()
        {
            return PartialView();
        }


        public PartialViewResult Side()
        {
            return PartialView();
        }
  
        
    
        public PartialViewResult Map()
        {
            return PartialView(items);
        }

    }

    }
