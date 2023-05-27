using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模拟移动硬盘_U盘
{
    class Program
    {
        static void Main(string[] args)
        {
            //模拟移动硬盘，U盘，MP3插在电脑上

            MobileStorage ms = new MP3();//UDisk();//MobileDisk();
            Compute cp = new Compute(ms);
            cp.CpuRead();
            cp.CpuWrite();
            Console.ReadKey();

        }
    }

    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class MobileDisk:MobileStorage
    {

        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写数据");
        }
    }

    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读数据");
        }

        public override void Write()
        {
            Console.WriteLine("U盘在写数据");
        }
    }

    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读数据");
        }

        public override void Write()
        {
            Console.WriteLine("MP3在写数据");
        }

        public void PlayMusic()
        {
            Console.WriteLine("播放音乐");
        }
    }

    public class Compute
    {
        private MobileStorage _ms;

        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }

        public Compute(MobileStorage ms)
        {
            this.Ms = ms;
        }

        public void CpuRead()
        {
            this.Ms.Read();
        }

        public void CpuWrite()
        {
            this.Ms.Write();
        }
    }


}
