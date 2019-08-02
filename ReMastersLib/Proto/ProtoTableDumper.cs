using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReMastersLib
{
    public static class ProtoTableDumper
    {
        /// <summary>
        /// Converts the <see cref="message"/> to a string with newlines separating each declaration for easy analysis.
        /// </summary>
        /// <typeparam name="T">Type of message</typeparam>
        /// <param name="message">Decoded proto message data</param>
        /// <returns>Single line string ready for writing to a file</returns>
        public static string DumpAll<T>(this T message) where T : IMessage<T>
        {
            var s = new JsonFormatter.Settings(true);
            var f = new JsonFormatter(s);
            var result = f.Format(message);
            return Prettify(result);
        }

        /// <summary>
        /// Converts each message in <see cref="messages"/> to a string.
        /// </summary>
        /// <typeparam name="T">Type of message</typeparam>
        /// <param name="messages">Decoded proto message data table</param>
        /// <returns>Single line string ready for writing to a file</returns>
        public static IEnumerable<string> DumpAll<T>(this RepeatedField<T> messages) where T : IMessage<T>
        {
            var s = new JsonFormatter.Settings(true);
            var f = new JsonFormatter(s);

            return messages.Select(z => f.Format(z));
        }

        private static string Prettify(string json) => JToken.Parse(json).ToString(Formatting.Indented);
    }
}
