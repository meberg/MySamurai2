﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MySamurai2.Domain
{
    public class SamuraiBattle
    {
        public int BattleId { get; set; }
        public Battle Battle { get; set; }

        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
    }
}
