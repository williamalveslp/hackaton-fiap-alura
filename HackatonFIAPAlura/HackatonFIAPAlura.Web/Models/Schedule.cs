namespace HackatonFIAPAlura.Web.Models;

public class Schedule
{
    public int Id { get; set; }

    private static int _nextId = 1;

    public string Name { get; private set; }
    public string PersonType { get; private set; }
    public string Phone { get; private set; } 
    public string Email { get; private set; }
    public DateTime AvailableDate { get; private set; }
    public string Description { get; private set; }

    public Schedule(string name, string personType, string phone, string email, DateTime availableDate, string description)
    {
        this.Id = _nextId++;
        this.Name = name;
        this.PersonType = personType;
        this.Phone = phone;
        this.Email = email;
        this.AvailableDate = availableDate;
        this.Description = description;
    }
}