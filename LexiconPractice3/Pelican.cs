﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPractice3
{
    class Pelican : Bird
    {
        public bool LiveAntarctica { get; set; }
        public Pelican(string name, double weight, int age) : base(name, weight, age)
        {
            LiveAntarctica = false;
        }

        public override void DoSound()
        {
            base.DoSound();
        }
        public override string Stat()
        {
            return $"{base.Stat()}\nLives in Antarctica: {this.LiveAntarctica}";
        }
    }
}
