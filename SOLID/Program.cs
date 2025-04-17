//SOLID - S: Single Responsibility Principle


//Denying SOLID :

using System.ComponentModel.DataAnnotations;

public class UserCreator
{
    public void CreateUser(string username, string email ,string password)
    {
        //Validation Logic
        if (!ValidateEmail(email))
        {
            throw new ArgumentException("Invalid Email!");
        }
        // Business rules
        // Database persistence
        SaveUserToDatabase(username, email, password);
    }
    private bool ValidateEmail(string email)
    {
        //Validation Logic
    }
    private void SaveUserToDatabase(string username, string email, string password)
    {
        // Database persistence logic
    }
}

// The Code Above Does Not Obey The SOLID Principles.
// Because If A Change Was Needed For Email Service, Then User Class Should Be Changed.
//Additionally, This Code Limits To Just Send Emails Via This. 
//Here Is The Corrected Format.


class UserValidator
{
    public bool ValidateEmail(string email)
    {
        //Validation logic
    }
}
public class UserRepository
{
    public void SaveUser(string username, string email, string password)
    {
        // Database persistence logic
    }
}

public class UserCreator
{
    private readonly UserValidator _validator;
    private readonly UserRepository _repository;
    public UserCreator (UserCreator userCreator, UserRepository repository)
    {
        _validator = validator;
        _repository = repository;
    }
    public void CreateUser(string username, string email, string password) 
    {
        if (_validator.ValidateEmail(email))
        {
            throw new ArgumentException("Invalid Email Format");
        }

        //Business rules
        _repository.SaveUser(username, email, password);
    }
}