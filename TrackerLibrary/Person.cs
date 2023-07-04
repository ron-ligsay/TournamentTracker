using System;


public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Gender { get; set; }
    public GetProfile {}
}

public class Person : IPerson
{
    private string firstName;
    private string lastName;
    private string middleName;
    private string gender;

    public Person(string firstName, string lastName, string middleName, string gender)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.middleName = middleName;
        this.gender = gender;
    }

    public string FirstName { get { return FirstName; } set { FirstName = value; } }
    public string LastName { get { return LastName; } set { LastName = value; } }
    public string MiddleName { get { return MiddleName; } set { MiddleName = value; } }
    public string Gender { get { return Gender; } set { Gender = value; } }

    // GetProfile should return the details - FirstName, LastName, MiddleName and Gender
    public GetProfile {
        return $"FirstName: {firstName}, LastName: {lastName}, MiddleName: {middleName}, Gender: {gender}";       
    }

} 