﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 超市收银系统
{
    class ProductFather
    {
        public double Price
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string ID
        {
            get;
            set;
        }

        public ProductFather(string id,double price,string name)
        {
            this.ID = id;
            this.Price = price;
            this.Name = name;
        }
    }
}
