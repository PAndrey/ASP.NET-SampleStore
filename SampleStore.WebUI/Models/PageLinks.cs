using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleStore.Domain.Entities;

namespace SampleStore.WebUI.Models
{
  public class PageLinks
  {
    // Всего страниц
    public int TotalPages { get; set; }

    // Выбранная страница
    public int SelectedPage { get; set; }

    public PageLinks(IEnumerable<Product> products)
    {

    }

  }
}