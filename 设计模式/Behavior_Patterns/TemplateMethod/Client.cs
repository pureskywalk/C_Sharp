using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //客户端代码调用模板方法来执行算法。客户端代码不必知道
    //它所处理的对象的具体类，只要它通过其基类的接口处理对象即可。
    class Client
    {
        public static void ClientCode(AbstractClass abstractClass)
        {
            // ...
            abstractClass.TemplateMethod();
            // ...
        }
    }
}
