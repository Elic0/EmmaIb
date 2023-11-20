public class TodoItem
{
    public string Name { get; set; }
    public int? Age { get; set; }
    public string Profession { get; set; }
    public string Country { get; set; }
    public string City { get; set; }

    public TodoItem(string name, int age, string profession, string country, string city)
    {
        Name = name;
        Age = age;
        Profession = profession;
        Country = country;
        City = city;
    }
}
