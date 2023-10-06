namespace HackatonFIAPAlura.Web.Models
{
    public class Partner
    {
        public int Id { get; private set; }
        private static int _nextId = 1;

        public string Name { get; private set; }
        public string City { get; private set; }
        public string Specialist { get; private set; }

        public Partner(string name, string city, string specialist)
        {
            this.Id = _nextId++;
            this.Name = name;
            this.City = city;
            this.Specialist = specialist;
        }
    }
}
