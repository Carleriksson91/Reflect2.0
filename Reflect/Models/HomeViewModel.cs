using Reflect.Azure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflect.Models {
   public class HomeViewModel {
      public IEnumerable<Question> Questions { get; set; }
   }
}
