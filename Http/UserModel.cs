using System.Collections.Generic;

namespace Acme.Http;

/// <summary>
/// Input model for creating/updating weavy users.
/// </summary>
public class UserModel
{
    public string Uid { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Picture { get; set; }

    public string Directory { get; set; }

    public Dictionary<string, string> Metadata { get; set; }

    public string[] Tags { get; set; }

    public bool IsSuspended { get; set; }

    public int UserId { get; set; }

    public string Username { get; set; }

    public string ProductId { get; set; }

    public long TenantId { get; set; }

    /// <summary>
    /// Gets or sets the path where to redirect after successful sign-in.
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// Gets or sets the preferred time zone for date/time formatting.
    /// </summary>
    public string TimeZone { get; set; }
}
