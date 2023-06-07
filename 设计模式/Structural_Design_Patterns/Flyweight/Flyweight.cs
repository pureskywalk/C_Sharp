using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    //Flyweight存储属于多个真实业务实体的状态的
    //公共部分（也称为内部状态）。享元通过其方
    //法参数接受状态的其余部分（外在状态，每个实体都是唯一的）。
    //此处的享元可以将方法抽象出来，一边拓展不同变体的享元，即不同形式的享元
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this._sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}
