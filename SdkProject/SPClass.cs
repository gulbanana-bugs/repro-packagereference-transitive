using FrameworkProject;

namespace SdkProject
{
    public class SPClass
    {
        public FPClass x;
        public Newtonsoft.Json.JsonConverter Converter => x.Converter;
    }
}
