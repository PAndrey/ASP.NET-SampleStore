using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleStore.Domain.Entities
{
    public class Product
    {
      // Идентификатор продукта
      public int     ProductId { get; set; }
      // Название
      public string  Name { get; set; }
      // Категория
      public string  Category { get; set; }
      // Описание
      public string  Description { get; set; }
      // Цена
      public decimal Price { get; set; }
    }
}
