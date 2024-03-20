using Bogus;
using TestRail.ApiTesting;

namespace TestRail_Example.Fakers;

public sealed class ProjectFaker : Faker<Project>
{
    public ProjectFaker()
    {
        RuleFor(b => b.Name, f => f.Random.AlphaNumeric(20));
        RuleFor(b => b.Announcement, f => f.Random.Words(50));
        RuleFor(b => b.SuiteMode, f => f.Random.Number(1, 3));
        RuleFor(b => b.ShowAnnouncement, f => f.Random.Bool());
    }
}