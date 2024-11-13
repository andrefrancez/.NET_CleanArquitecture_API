using Vehicles.Domain.Validation;

namespace Vehicles.Domain.Entities;

public sealed class Player
{
    public Player(string name, string position, string nationality, DateTime birthDate, int jerseyNumber)
    {
        ValidadeDomain(name, position, nationality, birthDate, jerseyNumber);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Position { get; private set; }
    public string Nationality { get; private set; }
    public DateTime BirthDate { get; private set; }
    public int JerseyNumber { get; private set; }
    public int TeamId { get; private set; }
    public Team Team { get; private set; }

    public void ValidadeDomain(string name, string position, string nationality, DateTime birthDate, int jerseyNumber)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name),
            "Invalid name. The name is required!");
        DomainExceptionValidation.When(string.IsNullOrEmpty(position),
            "Invalid position. The position is required!");
        DomainExceptionValidation.When(string.IsNullOrEmpty(nationality),
            "Invalid nationality. The nationality is required!");
        DomainExceptionValidation.When(birthDate > DateTime.Now,
            "Invalid birth date. The birth date cannot be in the future.");
        DomainExceptionValidation.When(birthDate < DateTime.Now.AddYears(-50),
            "Invalid birth date. The birth date is unrealistically old.");
        DomainExceptionValidation.When(birthDate > DateTime.Now.AddYears(-15),
            "Invalid birth date. The player must be at least 15 years old.");
        DomainExceptionValidation.When(jerseyNumber <= 99 || jerseyNumber > 0,
            "Invalid jersey number. The jersey number must be a valid number between 0 to 99.");

        Name = name;
        Position = position;
        Nationality = nationality;
        BirthDate = birthDate;
        JerseyNumber = jerseyNumber;
    }
}
