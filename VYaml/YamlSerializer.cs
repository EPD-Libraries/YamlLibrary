using System;

namespace VYaml
{
    public static class YamlSerializer
    {
        [ThreadStatic]
        static YamlDeserializationContext? DeserializationContext;

        public static T Deserialize<T>()
        {
            var contextLocal = (DeserializationContext ??= new YamlDeserializationContext());
            throw new NotImplementedException();
        }
    }
}