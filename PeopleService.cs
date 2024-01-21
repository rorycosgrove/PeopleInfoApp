using System.Collections.Generic;

public class PeopleService
{
    private List<Person> people = new List<Person>();

    public IEnumerable<Person> GetAllPeople() => people;

    public void AddPerson(Person person) { /*...*/ }
    public void UpdatePerson(Person person) { /*...*/ }
    public void DeletePerson(Person person) { /*...*/ }
}
