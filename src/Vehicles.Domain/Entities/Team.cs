using Vehicles.Domain.Validation;

namespace Vehicles.Domain.Entities;

public sealed class Team
{
    public Team(string name, string city, string stadium, int foundedYear)
    {
        ValidateDomain(name, city, stadium, foundedYear);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string City { get; private set; }
    public string Stadium { get; private set; }
    public int FoundedYear { get; private set; }
    public ICollection<Player> Players { get; private set; }
    public Coach Coach { get; private set; }

    public void ValidateDomain(string name, string city, string stadium, int foundedYear)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name),
            "Invalid name. The name is required.");
        DomainExceptionValidation.When(string.IsNullOrEmpty(city),
            "Invalid city. The city is required.");
        DomainExceptionValidation.When(string.IsNullOrEmpty(stadium),
            "Invalid stadium. The stadium is required.");
        DomainExceptionValidation.When(foundedYear <= 1800 || foundedYear > DateTime.Now.Year,
            "Invalid founded year. The founded year must be a valid year.");
        DomainExceptionValidation.When(name.Length <= 3,
            "The name must be at least 4 characters long.");
        DomainExceptionValidation.When(city.Length <= 3,
            "The city must be at least 4 characters long.");
        DomainExceptionValidation.When(stadium.Length <= 6,
            "The stadium must be at least 7 characters long.");

        Name = name;
        City = city;
        Stadium = stadium;
        FoundedYear = foundedYear;
    }
}
