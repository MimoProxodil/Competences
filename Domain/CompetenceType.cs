using System;

namespace Domain;

public class CompetenceType
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Name { get; set; }
    public required string ShortName { get; set; }
}
 