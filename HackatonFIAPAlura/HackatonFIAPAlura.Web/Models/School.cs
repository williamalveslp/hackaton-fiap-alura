namespace HackatonFIAPAlura.Web.Models
{
    public class School
    {
        public int Id { get; private set; }

        private static int _nextId = 1;

        public string SchoolName { get; private set; }
        public string City { get; private set; }

        public School(string schoolName, string city)
        {
            this.Id = _nextId++;
            this.SchoolName = schoolName;
            this.City = city;
        }
    }
}
