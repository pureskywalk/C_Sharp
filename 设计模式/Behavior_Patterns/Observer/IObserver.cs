using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserver
    {
        //从发布者处接收更新
        void Update(ISubject subject);
    }
}
