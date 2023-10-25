﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Quiz
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int QuestionCount { get; set; }
        public List<Question> Questions { get; set; }
    }
}
