using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    //Memento 接口提供了一种检索 Memento 元数据（如创建日期或名称）
    //的方法。但是，它不会公开发起方的状态。
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}
