/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Hood.Core
{
    //https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-6-0
    public partial class Options : Form
    {
        bool _speechMuted = false;
        public Options()
        {
            InitializeComponent();
            Init();
        }
        //call from main form 
        public void Init()
        {
            _websiteLink.MouseClick += GoGithub;
                
            Version ver = Assembly.GetExecutingAssembly().GetName().Version;
            string subVer = ver.ToString().Substring(0, 5);
            _version.Text = $"v{subVer}";

            MicMuter.Settings = SaveManager.Load();

            //make sure that our checkbox is visually correct
            _muteSpeech.Checked = MicMuter.Settings.MuteSpeech;
            
            InitComboBoxes();

            if (MicMuter.Settings == null)
            {
                _modifierKey.SelectedIndex = 2;
                _quitModKey.SelectedIndex = 2;

                // finding index of the letter Q 
                int m = _keys.FindStringExact("M");
                int q = _keys.FindStringExact("Q");
                _keys.SelectedIndex = m;
                _quitKey.SelectedIndex = q;
            }
            else
            {
                _modifierKey.SelectedItem = MicMuter.Settings.mModifierKeys;
                _quitModKey.SelectedItem = MicMuter.Settings.qModifierKeys;
                _keys.SelectedItem = MicMuter.Settings.mKey;
                _quitKey.SelectedItem = MicMuter.Settings.qKey;
            }

            _quitModKey.SelectedIndexChanged += QuitModSelected;
            _quitKey.SelectedIndexChanged += QuitKeySelected;
            _modifierKey.SelectedIndexChanged += MuteModSelected;
            _keys.SelectedIndexChanged += MuteKeySelected;
            _applyButton.MouseUp += ApplySettings;
        }

        private void GoGithub(object sender, MouseEventArgs e)
        {
            //will still open in the default browser ie: chrome/firefox etc but needs "explorer" cause .netcore
            var url = "http://hoodstrats.github.io/Projects/";
            Process.Start("explorer", url);
        }

        //convert enums into the datasource for the combo boxes
        //no need for for loops or anything 
        private void InitComboBoxes()
        {
            _modifierKey.ValueMember = "Value";
            _modifierKey.DisplayMember = "Name";
            _modifierKey.DataSource = Enum.GetValues(typeof(ModifierKeys));
            _quitModKey.ValueMember = "Value";
            _quitModKey.DisplayMember = "Name";
            _quitModKey.DataSource = Enum.GetValues(typeof(ModifierKeys));
            _keys.ValueMember = "Value";
            _keys.DisplayMember = "Name";
            _keys.DataSource = Enum.GetValues(typeof(Keys));
            _quitKey.ValueMember = "Value";
            _quitKey.DisplayMember = "Name";
            _quitKey.DataSource = Enum.GetValues(typeof(Keys));
        }

        private void MuteKeySelected(object sender, EventArgs e)
        {
            MicMuter.Settings.mKey = (Keys)_keys.SelectedValue;
        }

        private void MuteModSelected(object sender, EventArgs e)
        {
            MicMuter.Settings.mModifierKeys = (ModifierKeys)_modifierKey.SelectedValue;
        }

        private void QuitModSelected(object sender, EventArgs e)
        {
            MicMuter.Settings.qModifierKeys = (ModifierKeys)_quitModKey.SelectedValue;
        }

        private void QuitKeySelected(object sender, EventArgs e)
        {
            MicMuter.Settings.qKey = (Keys)_quitKey.SelectedValue;
        }
        //when applied make sure to change the settings in the main settings var located in main form 
        //reregister the hotkeys within keyboard script 
        private void ApplySettings(object sender, MouseEventArgs e)
        {
            //set if the speech is muted in settings
            MicMuter.Settings.MuteSpeech = _speechMuted;
            //MicMuter.Keyboard.RegisterHotKey(MicMuter.Settings._mModifierKeys, MicMuter.Settings._mKey);
            //MicMuter.Keyboard.RegisterHotKey(MicMuter.Settings._qModifierKeys, MicMuter.Settings._qKey);
            SaveManager.Save(MicMuter.Settings);

            //open the new confirmation form
            RestartConfirm f = new RestartConfirm
            {
                StartPosition = FormStartPosition.CenterParent
            };
            f.ShowDialog(MicMuter.ActiveForm);
            
            if (!_speechMuted)
            {
                MicMuter.InitSynthSpeech();
            }
        }
        //don't set the settings right here immediately wait for user to apply
        private void MuteSpeechToggled(object sender, EventArgs e)
        {
            _speechMuted = _muteSpeech.Checked;
        }
    }
    public class Settings
    {
        public bool FirstRun { get; set; }
        public bool MuteSpeech { get; set; }
        public ModifierKeys qModifierKeys { get; set; }
        public ModifierKeys mModifierKeys { get; set; }
        public Keys qKey { get; set; }
        public Keys mKey { get; set; }
    }
}
