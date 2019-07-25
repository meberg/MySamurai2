﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySamurai2.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public HairStyle? HairStyle { get; set; }

        public List<Quote> Quotes { get; set; }
    }
}
