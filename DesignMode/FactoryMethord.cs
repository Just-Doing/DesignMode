using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMode
{


    public abstract class Doc {
        public string Title { get; set; }
    }


    public abstract class DocApplication
    {
        public Doc doc;
        public virtual void Constauctor() { }

        public void Open()
        {
            Console.WriteLine(doc.Title);
        }
    }



    public class Word : Doc {
        public Word(){
            Title = "word";
        }
    }

    public class Excel : Doc
    {
        public Excel()
        {
            Title = "Excel";
        }
    }
    public class Ppt : Doc
    {
        public Ppt()
        {
            Title = "Ppt";
        }
    }


    public class WordApp : DocApplication {
        public override void Constauctor()
        {
            doc = new Word();
        }
    }
    public class ExcelApp : DocApplication
    {
        public override void Constauctor()
        {
            doc = new Excel();
        }
    }


    public class PptApp : DocApplication
    {
        public override void Constauctor()
        {
            doc = new Ppt();
        }
    }
}
