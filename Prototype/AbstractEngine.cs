﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class AbstractEngine :IEngine
    {
        private int size;
        private bool turbo;

        public AbstractEngine(int size, bool turbo) {
            this.size = size;
            this.turbo = turbo;
        }

        public virtual int Size {
            get {
                return size;
            }
        }

        public virtual bool Turbo {
            get {
                return turbo;
            }
        }

        public override string ToString()
        {
            return this.GetType().Name + "(" + size + ")";
        }


    }
}
