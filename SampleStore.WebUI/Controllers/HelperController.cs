using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleStore.WebUI.Models;

namespace SampleStore.WebUI.Controllers
{
    // Класс со вспомогательными функциями
    public class HelperController : Controller
    {
      // Метод для отображения списка страниц и текущего выбора
      [ChildActionOnly]
      public ActionResult ShowPageLinks(PagingInfo pagingInfo)
      {
        // Отобразим список
        return PartialView(pagingInfo);
      }

    }
}
