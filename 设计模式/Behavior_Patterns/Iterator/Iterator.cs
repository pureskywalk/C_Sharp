using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        //返回当前元素的键
        public abstract int Key();

        //返回集合中的当前元素。
        public abstract object Current();

        //向前移动到下一个元素
        public abstract bool MoveNext();

        //将迭代器退回到第一个元素
        public abstract void Reset();
    }
}
