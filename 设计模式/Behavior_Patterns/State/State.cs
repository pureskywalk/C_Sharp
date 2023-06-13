using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //状态基类声明所有具体状态都应实现的方法，
    //并提供对与状态关联的上下文对象的反向引用。
    //该状态可以使用此反向引用将上下文 转移 为另一个状态。
    abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }
}
