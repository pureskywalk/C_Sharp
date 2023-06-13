using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    //具体迭代器实现各种遍历算法。这些类始终存储当前遍历位置。
    class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;

        //存储当前遍历位置。迭代器可能还有许多其他字段用于存储迭代状态，
        //尤其是当它应该处理特定类型的集合时。
        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.getItems().Count;
            }
        }

        public override object Current()
        {
            return this._collection.getItems()[_position];
        }

        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.getItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this._position = this._reverse ? this._collection.getItems().Count - 1 : 0;
        }
    }
}
