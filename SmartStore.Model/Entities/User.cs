using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleStore.Domain.Entities
{
    public class User
    {
      // Описатель с возможными правами
      public enum USER_PERMISSION { NO_ACCESS = 0, CAN_READ = 1, CAN_WRITE = 2 };

      // Идентификатор пользователя
      public int             UserId { get; set; }
      // Имя пользователя
      public string          Name { get; set; }
      // Права
      public USER_PERMISSION Permission { get; set; }
    }
}
