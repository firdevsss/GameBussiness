﻿using GameBussiness.İnterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBussiness.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string  GameName { get; set; }
        public double Price { get; set; }
    }
}
