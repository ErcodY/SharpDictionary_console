using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Dictionary
{
    class JsonSystem
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions = new()
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };

        public void WriteData(string path,object obj )
        {
            using var sw = new StreamWriter(path);
            var json = JsonSerializer.Serialize(obj, _jsonSerializerOptions);
            sw.WriteLine(json);
        }

        public T ReadData<T>(string path)
        {
            using var sr = new StreamReader(path);
            var json = sr.ReadToEnd();
            return JsonSerializer.Deserialize<T>(json, _jsonSerializerOptions);
        }
    }
}