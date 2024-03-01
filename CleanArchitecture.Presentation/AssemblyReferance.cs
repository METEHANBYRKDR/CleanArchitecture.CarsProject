using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Presentation
{
    public static class AssemblyReferance
    {
        public static Assembly assembly = typeof(Assembly).Assembly;
    }
}
