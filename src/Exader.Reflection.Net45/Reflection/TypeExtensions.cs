using System;
using System.Reflection;
using JetBrains.Annotations;

namespace Exader.Reflection
{
    public static class MethodBodyHelper
    {
        internal static MethodBodyInfo GetMethodBodyInfo(this Type type, string name)
        {
            return MethodBodyInfo.Create(type.GetMethod(name));
        }

        [CanBeNull]
        internal static MethodBodyInfo GetMethodBodyInfo(this MethodInfo method)
        {
            return MethodBodyInfo.Create(method);
        }
    }
}
