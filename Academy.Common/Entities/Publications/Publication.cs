using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Common.Entities.Publications
{
    //classe base non instanziabile, deve essere derivata
    public abstract class Publication
    {
        public string Title { get; }
        public string Author { get; }
        public int Pages { get; set; }


        public Publication(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        //firma metodo abstract da implementare in classe derivata
        public abstract string ToDescription();

        public string GetDescription()
        {
            return $"{Author} - {Title}";
        }

        //override di classe base in classe derivata
        public override string ToString()
        {
            return "override ToString di object";
        }
    }
}
