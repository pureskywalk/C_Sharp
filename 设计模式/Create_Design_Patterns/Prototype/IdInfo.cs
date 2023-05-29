using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class IdInfo : ICloneable//C#自身具有该接口，直接使用即可
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
