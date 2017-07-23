using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BondTech.HotkeyManagement.Win;

namespace Volume_Changer
{
    public partial class MainForm : Form
    {
        internal HotKeyManager MyHotKeyManager;
        GlobalHotKey VolumeHotKey = new GlobalHotKey("VolumeHotKey", Modifiers.None, Keys.None);
        public static int Volume1;
        public static int Volume2;
        public static string EXE;
        public static bool Modifier;

        public MainForm()
        {
            InitializeComponent();
            LoadSettings();
            RegisterHotKeys();
        }

        public int getPUBGProcessID(string process)
        {
            Process[] WantedProcess = Process.GetProcessesByName(process);
            if (WantedProcess.Length > 0)
            {
                return WantedProcess[0].Id;
            }
            else
            {
                return 0;
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Volume1 = Volume1;
            Properties.Settings.Default.Volume2 = Volume2;
            Properties.Settings.Default.Process = EXE;
            Properties.Settings.Default.UseModifier = Modifier;
            Properties.Settings.Default.Save();
        }
        private void LoadSettings()
        {
                
            Volume1 = Properties.Settings.Default.Volume1;
            Volume2 = Properties.Settings.Default.Volume2;
            EXE = Properties.Settings.Default.Process;
            Modifier = Properties.Settings.Default.UseModifier;

            ProcessBox.Text = Properties.Settings.Default.Process;
            Max.Value = Volume1;
            Min.Value = Volume2;


            Modifier = Properties.Settings.Default.UseModifier;
            UseModifier.Checked = Modifier;

            ShortcutText.Text = Properties.Settings.Default.KeyboardShortcut;
            UpdateCustomShortcut(ShortcutText.Text);

        }

        private void Max_ValueChanged(object sender, EventArgs e)
        {
            Volume1 = (int)Max.Value;
            SaveSettings();
        }

        private void Min_ValueChanged(object sender, EventArgs e)
        {
            Volume2 = (int)Min.Value;
            SaveSettings();
        }

        private void ProcessBox_TextChanged(object sender, EventArgs e)
        {
            EXE = ProcessBox.Text;
            SaveSettings();
        }

        void RegisterHotKeys()
        {
            MyHotKeyManager = new HotKeyManager(this);
            MyHotKeyManager.GlobalHotKeyPressed += new GlobalHotKeyEventHandler(MyHotKeyManager_GlobalHotKeyPressed);
            VolumeHotKey.Enabled = true;
            MyHotKeyManager.AddGlobalHotKey(VolumeHotKey);
            MyHotKeyManager.DisableOnManagerFormInactive = true;
        }

        void MyHotKeyManager_GlobalHotKeyPressed(object sender, GlobalHotKeyEventArgs e)
        {
            if (e.HotKey.Name == "VolumeHotKey")
            {
                if (getPUBGProcessID(EXE) != 0)
                {
                    if (VolumeMixer.GetApplicationVolume(getPUBGProcessID(EXE)) == Volume1)
                    {
                        VolumeMixer.SetApplicationVolume(getPUBGProcessID(EXE), Volume2);
                    }
                    else
                    {
                        VolumeMixer.SetApplicationVolume(getPUBGProcessID(EXE), Volume1);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShortcutText.Text = SetKey.ChangeShortcut(ShortcutText.Text);
            UpdateCustomShortcut(ShortcutText.Text);
        }

        void UpdateCustomShortcut(string text)
        {

            //Will help determine if the shortcut has any modifier.
            bool HasAlt = false; bool HasControl = false; bool HasShift = false;

            Modifiers Modifier = Modifiers.None;		//Variable to contain modifier.
            Keys key = 0;           //The key to register.

            string[] result;
            string[] separators = new string[] { " + " };
            result = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //Iterate through the keys and find the modifier.
            foreach (string entry in result)
            {
                //Find the Control Key.
                if (entry.Trim() == Keys.Control.ToString())
                {
                    HasControl = true;
                }
                //Find the Alt key.
                if (entry.Trim() == Keys.Alt.ToString())
                {
                    HasAlt = true;
                }
                //Find the Shift key.
                if (entry.Trim() == Keys.Shift.ToString())
                {
                    HasShift = true;
                }
            }

            if (HasControl) { Modifier |= Modifiers.Control; }
            if (HasAlt) { Modifier |= Modifiers.Alt; }
            if (HasShift) { Modifier |= Modifiers.Shift; }

            //Get the last key in the shortcut
            KeysConverter keyconverter = new KeysConverter();
            key = (Keys)keyconverter.ConvertFrom(result.GetValue(result.Length - 1));
            
            VolumeHotKey.Key = key;
            VolumeHotKey.Modifier = Modifier;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            SaveSettings();
        }

        private void UseModifier_CheckedChanged(object sender, EventArgs e)
        {
            Modifier = UseModifier.Checked;
            SaveSettings();
        }
    }
}
