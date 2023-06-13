using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    //具体备忘录包含用于存储发起方状态的基础结构。
    class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        //发起方在还原其状态时使用此方法。
        public string GetState()
        {
            return this._state;
        }

        //其余方法由管理员用于显示元数据。
        public string GetName()
        {
            return $"{this._date} / ({this._state.Substring(0, 9)})...";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }
}
