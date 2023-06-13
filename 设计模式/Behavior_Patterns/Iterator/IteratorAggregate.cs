using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class IteratorAggregate : IEnumerable
    {
        //返回实现对象的迭代器或其他迭代器聚合。
        public abstract IEnumerator GetEnumerator();
    }
}
