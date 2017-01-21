using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reflect.Models;

namespace Reflect.Azure.Entities
{
    public class User
    {
        public int Id { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}