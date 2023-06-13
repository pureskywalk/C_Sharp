using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //抽象类定义了一个模板方法，该方法包含某种算法的框架，由对（通常）抽象基元操作的调用组成。
    //
    //具体子类应实现这些操作，但保持模板方法本身不变。
    abstract class AbstractClass
    {
        //模板方法定义算法的框架。
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation3();
            this.Hook2();
        }

        //这些操作已经实现。
        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        }

        //这些操作必须在子类中实现。
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        //这些是“钩子”。子类可以覆盖它们，但这不是强制性的，
        //因为钩子已经有默认（但为空）的实现。钩子在算法的一些
        //关键位置提供了额外的扩展点。
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}
