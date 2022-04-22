namespace Academy.Common.Entities.Publications
{
    public class Periodical : Publication
    {
        public int Frequency { get; set; }
        public Periodical(string title, string author, int pages)
            : base(title, author, pages)
        {

        }

        public Periodical(string title, string author, int pages, int frequency)
            : base(title, author, pages)
        {
            Frequency = frequency;
        }

        public override string ToDescription()
        {
            return $"{Author} - {Title}, {Pages} " +
                $"pages, every {Frequency} days";
        }
    }
}
