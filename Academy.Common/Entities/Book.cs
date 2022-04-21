using System;

namespace Academy.Common.Entities
{
    //classe derivata
    public class Book : Publication
    {
        //eventuali edizioni
        public Book(string title, string author, int pages) : base(title, author, pages)
        {

        }

        public override string ToDescription()
        {
            return $"{Author} - {Title}, {Pages} pages";
        }

        public override string ToString()
        {
            return "Book " + ToDescription();
        }
    }
}
