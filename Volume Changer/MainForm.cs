using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Volume_Changer
{
    public partial class MainForm : Form
    {
        KeyboardHook keyboardHook = new KeyboardHook();
        KeysConverter converter = new KeysConverter();

        public static KeyboardHook.VKeys SoundKey = KeyboardHook.VKeys.TILDER;

        public static int Volume1 = 100;
        public static int Volume2 = 20;

        public MainForm()
        {
            InitializeComponent();

            keyboardHook.KeyDown += new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyDown);
            keyboardHook.Install();

            PUBGHotKey1Text.Text = SoundKey.ToString() + " = 100%/20% Volume Changer";
        }

        void keyboardHook_KeyDown(KeyboardHook.VKeys key)
        {
            if (key == SoundKey)
            {
                if (getPUBGProcessID() != 0)
                {
                    if (VolumeMixer.GetApplicationVolume(getPUBGProcessID()) == Volume1)
                    {
                        VolumeMixer.SetApplicationVolume(getPUBGProcessID(), Volume2);
                    }
                    else
                    {
                        VolumeMixer.SetApplicationVolume(getPUBGProcessID(), Volume1);
                    }
                }
            }

            // Print key pressed
            //logBox.Text = "[" + DateTime.Now.ToLongTimeString() + "] KeyDown Event {" + key.ToString() + "}" + Environment.NewLine + logBox.Text;
        }

        public int getPUBGProcessID()
        {
            foreach (Process p in Process.GetProcesses("."))
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {

                        if (p.MainWindowTitle.Contains("PLAYERUNKNOWN'S BATTLEGROUNDS"))
                        {
                            return p.Id;
                        }
                    }
                }
                catch (Exception ex) { }
            }

            return 0;
        }
    }
}
