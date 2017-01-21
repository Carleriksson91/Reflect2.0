using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reflect.Azure.Entities
{
    public class Answer
    {
        public int AnswerId { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }
    }
}