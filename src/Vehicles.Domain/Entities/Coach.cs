using Vehicles.Domain.Validation;

namespace Vehicles.Domain.Entities;

public sealed class Coach
{
    public Coach(string name, string expLevel, string nationality)
    {
        ValidadeDomain(name, expLevel, nationality);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string ExperienceLevel { get; private set; }
    public string Nationality { get; private set; }
    public int TeamId { get; private set; }
    public Team Team { get; private set; }

    public void ValidadeDomain(string name, string expLevel, string nationality)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name),
            "Invalid name. The name is required!");
        DomainExceptionValidation.When(string.IsNullOrEmpty(expLevel),
            "Invalid experience level. The experience level is required!");
        DomainExceptionValidation.When(string.IsNullOrEmpty(nationality),
            "Invalid nationality. The nationality is required!");

        Name = name;
        ExperienceLevel = expLevel;
        Nationality = nationality;
    }
}
