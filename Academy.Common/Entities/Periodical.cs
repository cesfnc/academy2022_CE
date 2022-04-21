namespace Academy.Common.Entities
{
    public class Periodical : Publication
    {
        public int Frequency { get; set; }
        public Periodical(string title, string author, int pages) : base(title, author, pages)
        {

        }

        public override string ToDescription()
        {
            return $"{Author} - {Title}, {Pages} " +
                $"pages, every {Frequency} days";
        }
    }
}
