
using System;
using System.Collections.Generic;
using System.Linq;

public class TypeResolver
    {
        public IEnumerable<Type> Resolve(Type type)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                   .SelectMany(s => s.GetTypes())
                   .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);
        }
    }