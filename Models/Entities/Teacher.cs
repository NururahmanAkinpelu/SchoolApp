﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models.Entities
{
    public class Teacher : Person
    {
        public string Course { get; set; }
        public List<Level> Levels { get; set; }
    }
}
