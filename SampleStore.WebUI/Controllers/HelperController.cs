using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleStore.WebUI.Models;

namespace SampleStore.WebUI.Controllers
{
  // Класс со вспомогатльными функциями
    public class HelperController : Controller
    {
      // Метод для отображения списка страниц и текущего выбора
      [ChildActionOnly]
      public ActionResult ShowPageLinks()
      {
        // Получим информацию из сессии 
        PageLinks links = (PageLinks)Session["PageLinks"];
        if (links == null)
        {
          links = new PageLinks();
        }

        // Отобразим список
        return PartialView(links);
      }

    }
}
