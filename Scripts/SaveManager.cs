/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Hood.Core
{
    public static class SaveManager
    {
        static string sFile = $"{Environment.CurrentDirectory}/Settings.ini";

        //setup file checking etc here 
        public static Settings Load()
        {
            Settings s;

            if (File.Exists(sFile))
            {
                //try to initialize the settings class using json 
                string openFile = File.ReadAllText(sFile);
                s = JsonSerializer.Deserialize<Settings>(openFile);
            }
            else
            {
                s = new Settings
                {
                    qModifierKeys = ModifierKeys.Control,
                    mModifierKeys = ModifierKeys.Control,
                    qKey = Keys.Q,
                    mKey = Keys.M
                };
                Save(s);
            }
            return s;
        }
        public static void Save(Settings s)
        {
            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string setFile = JsonSerializer.Serialize(s, jsonOptions);
            File.WriteAllText(sFile, setFile);
        }
    }
}
