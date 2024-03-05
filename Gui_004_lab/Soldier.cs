﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_004_lab
{
    public class Soldier
    {
        public string Type { get; set; }
        public int Power { get; set; }
        public int Vitality { get; set; }
        public int Value { get; set; }

        public int Cost
        {
            get
            {
                return Vitality * Power * Value;
            }
        }

        public string Print
        {
            get
            {
                return this.ToString();
            }
        }

        public override string ToString()
        {
            return $"{this.Type.ToString()} {this.Power} {this.Vitality} {this.Value}";
        }
    }
}
