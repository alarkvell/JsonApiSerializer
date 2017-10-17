using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace JsonApiSerializer
{
    public static class BackportUtil
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            if (value == null)
            {
                return true;
            }

            for (var i = 0; i < value.Length; i++)
            {
                if (!char.IsWhiteSpace(value[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static Type[] GenericTypeArguments(this Type type)
        {
                if (type.IsGenericType && !type.IsGenericTypeDefinition)
                {
                    return type.GetGenericArguments();
                }
                else
                {
                    return Type.EmptyTypes;
                }
        }
    }
}
