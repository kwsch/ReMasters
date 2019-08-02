using Google.Protobuf;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReMastersLib
{
    public static class ProtoTableDumper
    {
        public static string DumpAll<T>(T message) where T : IMessage<T>
        {
            var s = new JsonFormatter.Settings(true);
            var f = new JsonFormatter(s);
            var result = f.Format(message);
            return Prettify(result);
        }

        private static string Prettify(string json) => JToken.Parse(json).ToString(Formatting.Indented);
    }
}
