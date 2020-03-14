using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode_Bridge
{
    public abstract class Phone
    {
        public string Name { get; set; }
        List<Soft> Soft=new List<Soft>();
        public virtual void SetSoft(Soft s) {
            Soft.Add(s);
        }

        public virtual void RunSoft() {
            foreach (var soft in Soft) {
                soft.Run();
            }
        }
    }

    public abstract class Soft {
       public abstract void Run();
    }

    public class ApplePhone: Phone
    {
        public ApplePhone()
        {
            this.Name = "ApplePhone";
            this.SetSoft(new MovePlayer());
        }
        public override void RunSoft()
        {
            Console.WriteLine("Apple手机运行软件");
            base.RunSoft();
        }
    }
    public class OppoPhone : Phone
    {
        public OppoPhone()
        {
            this.Name = "OppoPhone";
            this.SetSoft(new MovePlayer());
            this.SetSoft(new SongPlayer());
        }
        public override void RunSoft()
        {
            Console.WriteLine("OPPO手机运行软件");
            base.RunSoft();
        }
    }

    public class MovePlayer : Soft
    {
        public override void Run()
        {
            Console.WriteLine("Move 运行电影播放器");
        }
    }

    public class SongPlayer : Soft
    {
        public override void Run()
        {
            Console.WriteLine("Song 运行音乐播放器");
        }
    }

    public class Client {
        public void Test() {
            var applePhone = new ApplePhone();
            applePhone.RunSoft();
            var oppoPhone = new OppoPhone();
            oppoPhone.RunSoft();
        }
    }
}
