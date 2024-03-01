using System.Reflection;

namespace CleanArchitecture.Persistance;

public static class AssemblyReferance
{
    public static readonly Assembly Assembly = typeof(Assembly).Assembly;
}
