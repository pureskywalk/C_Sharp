using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 超市收银系统
{
    class SupperMarket
    {
        //创建仓库
        CangKU ck = new CangKU();

        /// <summary>
        /// 创建超市对象时，给仓库的货架进货
        /// </summary>
        public SupperMarket()
        {
            ck.JinPros("Acer", 1000);
            ck.JinPros("SangSung", 1000);
            ck.JinPros("JiangYou", 1000);
            ck.JinPros("Banana", 1000);
        }

        /// <summary>
        /// 与用户交互
        /// </summary>
        public void AskBuying()
        {
            Console.WriteLine("欢迎");
            ck.ShowPros();
            Console.WriteLine("请问您需要什么");
            string strType = Console.ReadLine();
            Console.WriteLine("请问您需要多少");
            int count = Convert.ToInt32(Console.ReadLine());
            //取货
            ProductFather[] pros =  ck.QuPros(strType, count);
            //计价
            double realMoney = GetMoney(pros);
            Console.WriteLine("您需支付{0}元",realMoney);
        }

        /// <summary>
        /// 计算同一种货物的总价钱
        /// </summary>
        /// <param name="pros">商品数组</param>
        /// <returns></returns>
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }
    }
}
