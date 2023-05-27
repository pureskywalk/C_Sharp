using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 超市收银系统
{
    class CangKU
    {
        //存储货物
        private List<List<ProductFather>> list1 = new List<List<ProductFather>>();

        public List<List<ProductFather>> List1
        {
            get { return list1; }
            set { list1 = value; }
        }
        /// <summary>
        /// 创建仓库对象时，向仓库中添加4个货架
        /// </summary>
        public CangKU()
        {
            this.List1.Add(new List<ProductFather>());
            this.List1.Add(new List<ProductFather>());
            this.List1.Add(new List<ProductFather>());
            this.List1.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 仓库进货
        /// </summary>
        /// <param name="strType">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public void JinPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": this.List1[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "宏基笔记本"));
                        break;
                    case"SangSung":this.List1[1].Add(new Acer(Guid.NewGuid().ToString(), 2000, "三星手机"));
                        break;
                    case "JiangYou": this.List1[2].Add(new Acer(Guid.NewGuid().ToString(), 50, "老抽"));
                        break;
                    case "Banana": this.List1[3].Add(new Acer(Guid.NewGuid().ToString(), 50, "香蕉"));
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// 仓库取货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">货物数量</param>
        public ProductFather[] QuPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": pros[i] = List1[0][0];
                        List1[0].RemoveAt(0);
                        break;
                    case "SangSung": pros[i] = List1[1][0];
                        List1[1].RemoveAt(0);
                        break;
                    case "JiangYou": pros[i] = List1[2][0];
                        List1[2].RemoveAt(0);
                        break;
                    case "Banana": pros[i] = List1[3][0];
                        List1[3].RemoveAt(0);
                        break;
                    default:
                        break;
                }
            }
            return pros;
        }

        /// <summary>
        /// 展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in List1)
            {
                Console.WriteLine("我们仓库有:{0},\t有{1}个,\t每个{2}元",item[0].Name,item.Count,item[0].Price);
            }
        }
         
    }
}
