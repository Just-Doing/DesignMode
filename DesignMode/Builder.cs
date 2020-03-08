using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode_Builder
{
    public class HongShaoRou {
        public int Wendu { get; set; }
        public int Shui { get; set; }
        public int You { get; set; }
    }
    public abstract class HongshaorouBuilder // 红烧肉
    {
        public HongShaoRou hongshaorou { get; set; }
        abstract public void Qiguo();
        abstract public void ShaoYou();
        abstract public void FangtShui();

        public HongShaoRou Get() {
            hongshaorou = new HongShaoRou();
            Qiguo(); // 起锅
            ShaoYou(); // 烧油
            FangtShui(); // 放葱姜蒜
            return hongshaorou;
        }
    }

    public class ChuanCai : HongshaorouBuilder { // 川菜
        public override void FangtShui()
        {
            hongshaorou.Shui = 100;
        }

        public override void Qiguo()
        {
            hongshaorou.Wendu = 800;
        }

        public override void ShaoYou()
        {
            hongshaorou.You = 500;
        }
    }
    
    public class Client {
        public void ZuoHongshaorou()
        {
            var cuanCai = new ChuanCai();
            HongShaoRou cuancaiHongshaorou = cuanCai.Get();
            Console.WriteLine("wendu:{0}, shui:{1}, you: {2}", cuancaiHongshaorou.Wendu, cuancaiHongshaorou.Shui, cuancaiHongshaorou.You);
        }
    }
}
