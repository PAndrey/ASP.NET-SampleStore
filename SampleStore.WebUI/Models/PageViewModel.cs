using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleStore.Domain.Entities;
using SampleStore.Domain.Entities.Concrete;

namespace SampleStore.WebUI.Models
{
  public class PageViewModel
  {
    // Список отображаемых продуктов
    public IEnumerable<Product> Products { get; private set; }

    // Информация для отображения ссылок на страницы
    public PagingInfo PagingInfo { get; private set; }

    public PageViewModel(IEnumerable<Product> products,
                         PagingInfo pagingInfo)
    {
      this.PagingInfo = pagingInfo;
      this.Products = products;
    }



  }
}