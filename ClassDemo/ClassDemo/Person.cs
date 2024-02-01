namespace ClassDemo;

public class Person
{
    public Person(string firstName)
    {
        //ensure you're using property not field
        //if you input null then it'll call the setter below (this is validation)
        FirstName = firstName;
    }
    //GUIDLINE: this field should only be accessed through get/set properties 
    //only use property never the field
    //only create a field when you have a reason to have one, otherwise just use auto property
    private string? _firstName; //saying it can be null
    //because it's private you cannot access - must use FirstName

    public string FirstName {
        get => _firstName!; //telling compiler it's okay to be null in this case
        set {
            //if value is null throw exception
            _firstName = value ?? throw new ArgumentNullException(nameof(value));
        }
    }


    //public string LastName { get; set; }



    public void SetName(string? temp) {
        _firstName = null; //wrong
        FirstName = null; //Right
            }
    //Person person = new();
    //assumes based on first Person - don't have to rewrite for new Person()

    // GUIDELINE: only use var when data type is obvious
    //this is not better than just doing it first way
    //var person3 = new Person(); //simplified new

    public string? MiddleName {  get; set; }


}