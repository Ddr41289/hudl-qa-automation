using System;
using System.IO;
using Newtonsoft.Json;

namespace hudl_qa_automation.Utilities
{
    public class ConfigReader
    {
        public static ConfigReader ReadConfig(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Config file not found.", filePath);
            }

            string json = File.ReadAllText(filePath);
            ConfigReader config = JsonConvert.DeserializeObject<ConfigReader>(json);
            return config;
        }
    }
}
