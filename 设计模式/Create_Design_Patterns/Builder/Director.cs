using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //主管只负责按特定顺序执行建筑步骤。在根据特定订单或配置
    //生产产品时，这很有帮助。严格来说，Director 类是可选的，
    //因为客户端可以直接控制构建器。
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        //主管可以使用相同的构建步骤构建多个产品变体。
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
