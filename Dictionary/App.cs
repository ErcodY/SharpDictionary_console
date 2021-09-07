using System;
using System.Collections.Generic;

namespace Dictionary
{
    class App
    {
        private readonly JsonSystem _json = new();
        private Dictionary<string, List<string>> _words = new();

        private void UploadDictionary()
        {
            _json.WriteData("user.json", _words);
        }

        private void LoadData()
        {
            _words = _json.ReadData<Dictionary<string, List<string>>>("user.json");
            foreach (var word in _words)
            {
                Console.Write(word.Key + ": ");
                Console.WriteLine(word.Value._ToString());
            }
        }
        
        public void Run()
        {
            LoadData();
        }
    }
}