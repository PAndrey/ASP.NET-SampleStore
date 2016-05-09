using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleStore.Domain.Entities;

namespace SampleStore.WebUI.Models
{
  public class PagingInfo
  {
    // Выбранная страница
    public int SelectedPage { get; set; }

    // Число записей на странице
    public int RecordsPerPage { get; set; }

    // Общее число записей
    public int TotalRecords { get; set; }


    // Всего страниц
    public int TotalPages
    {
      get
      {
        return TotalRecords / RecordsPerPage;
      }
    }
  }
}