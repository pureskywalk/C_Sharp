using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //仅当您的产品非常复杂且需要大量配置时，才使用 Builder 模式才有意义。
    //与其他创造模式不同，不同的具体生成器可以生产不相关的产品。换句话说，
    //各种生成器的结果可能并不总是遵循相同的接口。
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); //移除最后的", "

            return "Product parts: " + str + "\n";
        }
    }
}
