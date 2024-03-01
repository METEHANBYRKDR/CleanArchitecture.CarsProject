using System.Reflection;

namespace CleanArchitecture.Application;

public static class AssemblyReferance
{
    public static readonly Assembly assembly = typeof(Assembly).Assembly;
}
