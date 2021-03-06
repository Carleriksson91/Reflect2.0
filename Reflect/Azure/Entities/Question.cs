﻿using Reflect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflect.Azure.Entities
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid? ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime CreatedDate { get; set; }


        public ICollection<QuestionAlternative> QuestionAlternatives { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
