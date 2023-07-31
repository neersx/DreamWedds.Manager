using System.Collections.ObjectModel;

namespace DreamWedds.Manager.Shared.Authorization;

public static class FSHRoles
{
    public const string Admin = nameof(Admin);
    public const string Basic = nameof(Basic);
    public const string Public = nameof(Public);

    public static IReadOnlyList<string> DefaultRoles { get; } = new ReadOnlyCollection<string>(new[]
    {
        Admin,
        Basic,
        Public
    });

    public static bool IsDefault(string roleName) => DefaultRoles.Any(r => r == roleName);
}