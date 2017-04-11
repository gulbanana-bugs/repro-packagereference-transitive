using SdkProject1;

namespace FrameworkProject
{
    public class FPClass
    {
        public SP1Class x;
        public Newtonsoft.Json.JsonConverter Converter => x.Converter;
    }
}
