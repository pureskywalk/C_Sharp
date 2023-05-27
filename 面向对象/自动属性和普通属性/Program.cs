﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 自动属性和普通属性
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 自动属性，编译时会自动生成字段
        /// </summary>
        public int Age
        {
            get;
            set;
        }
    }

}
