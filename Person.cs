public class Person
{
    public string Name { get; set; }
    public string DateOfBirth { get; set; }
    public string Profession { get; set; }

    // Optionally, you can add a constructor if needed
    public Person(string name, string dateOfBirth, string profession)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        Profession = profession;
    }

    // Default constructor
    public Person() { }
}
