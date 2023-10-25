﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Variants { get; set; }
        public int CorrectVariant { get; set; }
    }
}
