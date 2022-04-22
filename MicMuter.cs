/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Hood.Core
{
    public partial class MicMuter : Form
    {
        public static KeyboardHook Keyboard { get => _keyboard; set => _keyboard = value; }
        public static Settings Settings { get => _settings; set => _settings = value; }

        enum MicState { Unmuted, Muted };

        //use this for baloon notifications
        bool _hasNotified = false;
        bool _muted = false;

        static Settings _settings;
        static KeyboardHook _keyboard = new KeyboardHook();

        //to toggle tray icons
        Icon _origIcon;
        Icon _mutedIcon;

        //construct new instance of the class
        CoreAudioController _controller { get; } = new CoreAudioController();
        static SpeechSynthesizer _synth { get; } = new SpeechSynthesizer();

        public MicMuter()
        {
            InitializeComponent();

            //don't have to wait for options menu to be initialized
            _settings = SaveManager.Load();
            
            Resize += ResizeProgram;
            //this accounts for all instances in which the program is closed
            //FormClosed += ExitEvent;
            //this happens right before the form is closed, good place to check for mute
            FormClosing += CheckIfStillMuted;
            _muteButton.Click += MuteClicked;
            optionsToolStripMenuItem.Click += OptionsToolStripMenuItem_Click;

            SetupTrayIcon();
            
            InitSynthSpeech();
            
            ToggleButtonInfo();

            //need to reregister these whenever options are changed 
            _keyboard.RegisterHotKey(_settings.mModifierKeys, _settings.mKey);
            _keyboard.RegisterHotKey(_settings.qModifierKeys, _settings.qKey);
            _keyboard.KeyPressed += UpdateLoop;

            //make sure we know if the mic is already muted and set bool
            _muted = GetDefaultInputDevice().IsMuted;

            //open form with about and website link etc upon first run 
            FirstRun();
        }
        CoreAudioDevice GetDefaultInputDevice() => _controller.GetCaptureDevices(DeviceState.Active).FirstOrDefault(o => o.IsDefaultDevice);
        
        //call again from options menu if checkbox is unchecked and apply is pressed
        public static void InitSynthSpeech()
        {
            if (_settings.MuteSpeech) return;

            //run this whole thing here ASYNC
            _synth.SelectVoice("Microsoft Zira Desktop");
            _synth.SetOutputToDefaultAudioDevice();
            _synth.SpeakAsync("Speech Enabled");
        }

        private void FirstRun()
        {
           if(_settings.FirstRun == false)
            {
                FirstRunDiag fr = new FirstRunDiag
                {
                    StartPosition = FormStartPosition.CenterParent,
                };
                //this actually centers the form to this one without any extra fuss unlike Show()
                fr.ShowDialog(this);
                _settings.FirstRun = true;
                SaveManager.Save(_settings);
            }
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open the new form with all the options
            Options f = new Options
            {
                StartPosition = FormStartPosition.CenterParent,
            };
            f.ShowDialog(this);
        }
        private void AboutMenuItemClicked(object sender, EventArgs e)
        {
            FirstRunDiag fr = new FirstRunDiag
            {
                StartPosition = FormStartPosition.CenterParent,
            };
            fr.ShowDialog(this);
        }

        private void MuteClicked(object sender, EventArgs e)
        {
            _muted = !_muted;
            ToggleMute(_muted);
        }

        private void SetupTrayIcon()
        {
            _notifyIcon.DoubleClick += ToggleProgram;
            _origIcon = new Icon(Application.StartupPath + @"\SPR\SnowballUnmuted.ico");
            _mutedIcon = new Icon(Application.StartupPath + @"\SPR\SnowballMuted.ico");
            _notifyIcon.Visible = false;

            //setup our rightclick menu items and event handlers
            //they get added from top to bottom
            _rightClickMenu.Items.Add("Mute");
            _rightClickMenu.Items.Add("Unmute");
            _rightClickMenu.Items.Add("Exit");

            _rightClickMenu.ItemClicked += RightClickMenuEvents;
            //this automatically activates when tray icon is right clicked
            _notifyIcon.ContextMenuStrip = _rightClickMenu;
        }
        private void RightClickMenuEvents(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == _rightClickMenu.Items[0])
            {
                ToggleMute(true);
            }
            else if (e.ClickedItem == _rightClickMenu.Items[1])
            {
                ToggleMute(false);
            }
            else
            {
                Close();
            }
            _rightClickMenu.Close();
        }

        //built-in winform event that gets called when program is resized thru controls
        private void ResizeProgram(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                _notifyIcon.Visible = true;
                _notifyIcon.BalloonTipTitle = "Snowball Muter";
                //make sure to check if they have already recieved the notification of "running in the background" 
                if (!_hasNotified)
                {
                    _notifyIcon.BalloonTipText = "Muter Running in the background";
                    _notifyIcon.ShowBalloonTip(1);
                    _hasNotified = true;
                }
                //built in method that hides the program from the taskbar 
                Hide();
            }
        }
        //returns the program to normal when clicking the notification icon
        private void ToggleProgram(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
            _hasNotified = false;
            //built in method that shows the program in the taskbar 
            Show();
            WindowState = FormWindowState.Normal;
        }
        //here we mute and unmute and change the button image 
        void UpdateLoop(object o, KeyPressedEventArgs e)
        {
            if (e.Key == _settings.mKey)
            {
                _muted = !_muted;
                ToggleMute(_muted);
            }
            else if (e.Key == _settings.qKey)
            {
                Close();
            }
        }
        //method for each toggle method on tray icon menu
        void ToggleMute(bool mute)
        {
            //make sure our bool is set regardless
            _muted = mute;
            GetDefaultInputDevice().Mute(mute);
            ToggleButtonInfo();
        }

        //use this from all mute functionality to toggle button data
        void ToggleButtonInfo()
        {
            if (GetDefaultInputDevice().IsMuted)
            {
                _muteButton.Text = "Mic Muted";
                _muteButton.ForeColor = Color.Black;
                _muteButton.BackColor = Color.Red;
                _notifyIcon.Icon = _mutedIcon;
                
                if(!_settings.MuteSpeech)
                _synth.SpeakAsync("Mic Muted");
            }
            else
            {
                _muteButton.Text = "Mic Unmuted";
                _muteButton.ForeColor = Color.White;
                _muteButton.BackColor = Color.Green;
                _notifyIcon.Icon = _origIcon;

                if(!_settings.MuteSpeech)
                _synth.SpeakAsync("Mic Unmuted");
                //GetAudioDevice().Volume = _output;
            }
        }
        private void CheckIfStillMuted(object sender, FormClosingEventArgs e)
        {
            if (_muted)
            {
                var warn = MessageBox.Show(this, "Mic is still Muted.\nDo you still want to exit?", "Mic Muted",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (warn != DialogResult.Yes)
                {
                    //cancel exit event
                    e.Cancel = true;
                    return;
                }
            }
            ExitEvent(sender,e);
        }
        //occurs whenever the program is closed, use it to check if still muted
        void ExitEvent(object sender, EventArgs e)
        {
            if (!_settings.MuteSpeech)
            {

            Prompt prompt = new Prompt("Talk to you later");
            //can't use ASYNC and check prompt completion because of AWAIT in async
            _synth.Speak(prompt);
            if (prompt.IsCompleted)
            {
                Environment.Exit(0);
            }
            }
            else
            {
                Environment.Exit(0);
            }
        }

    }
}
