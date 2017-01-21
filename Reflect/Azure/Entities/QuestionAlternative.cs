using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reflect.Azure.Entities
{
    public class QuestionAlternative
    {
        public int QuestionAlternativeId { get; set; }

        public string Title { get; set; }

        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}