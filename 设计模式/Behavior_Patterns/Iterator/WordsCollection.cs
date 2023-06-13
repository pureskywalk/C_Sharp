using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    //具体集合提供一种或多种方法来检索与集合类兼容的新迭代器实例。
    class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> getItems()
        {
            return _collection;
        }

        public void AddItem(string item)
        {
            this._collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}
