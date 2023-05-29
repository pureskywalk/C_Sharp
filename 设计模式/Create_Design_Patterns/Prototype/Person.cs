using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();//只对值类型进行复制，对引用类型只复制引用（即改变原值会影响复制的值）
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            //clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.IdInfo = (IdInfo)IdInfo.Clone();
            clone.Name = String.Copy(Name);
            return clone;
        }
    }

}
