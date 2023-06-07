using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //目标 定义了 客户端代码使用的特定域的接口。
    //需要被适配器继承，所以写成接口形式，虚方法与抽象类也可以
    public interface ITarget
    {
        string GetRequest();
    }
}
