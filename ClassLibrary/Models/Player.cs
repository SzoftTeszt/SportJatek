﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Result> Result { get; } = new List<Result>();

        public Player()
        {
        }

        public Player( string name)
        {
            Name = name;
        }
    }
}
