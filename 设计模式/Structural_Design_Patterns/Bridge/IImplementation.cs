using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //实现定义所有实现类的接口。它不必与抽象的接口匹配。
    //事实上，这两个接口可能完全不同。通常，实现接口仅
    //提供基元操作，而抽象基于这些基元定义更高级别的操作。
    public interface IImplementation
    {
        string OperationImplementation();
    }
}
