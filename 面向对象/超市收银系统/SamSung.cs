﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 超市收银系统
{
    class SamSung:ProductFather
    {
        public SamSung(string id, double price, string name)
            : base(id, price, name)
        {
            
        }
    }
}
