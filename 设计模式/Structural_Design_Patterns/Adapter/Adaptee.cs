using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Adaptee 包含一些有用的行为，但其接口与现有客户端代码不兼容。
    //客户端需要调用的是普通Request方法。
    //在客户端代码可以使用它之前，Adaptee 需要进行一些调整。
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}
