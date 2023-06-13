using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        //Command 接口声明执行命令的方法。
        void Execute();
    }
}
