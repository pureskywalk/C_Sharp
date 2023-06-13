using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //上下文定义客户端感兴趣的接口。它还维护对 State 子类
    //实例的引用，该实例表示上下文的当前状态。
    class Context
    {
        //对上下文当前状态的引用。
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        //上下文允许在运行时更改 State 对象。
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        //上下文将其部分行为委托给当前 State 对象。
        public void Request1()
        {
            this._state.Handle1();
        }

        public void Request2()
        {
            this._state.Handle2();
        }
    }
}
