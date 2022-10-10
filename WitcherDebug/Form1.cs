using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using Timer = System.Timers.Timer;

namespace WitcherDebug
{
    public partial class Form1 : Form
    {
        private Timer _findAppTimer;
        private XmlConfig _config;
        private bool _activated;
        private string _findingProcess = "Поиск процесса игры...";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            title.BackColor = Color.Transparent;
            title.ForeColor = Color.Gray;
            Selo.SetStyleRefl(title, ControlStyles.SupportsTransparentBackColor, true);
            activate.BackColor = Color.Transparent;
            activate.ForeColor = Color.White;
            Selo.SetStyleRefl(activate, ControlStyles.SupportsTransparentBackColor, true);
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            Selo.SetStyleRefl(label2, ControlStyles.SupportsTransparentBackColor, true);
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            Selo.SetStyleRefl(label4, ControlStyles.SupportsTransparentBackColor, true);
            findProc.BackColor = Color.Transparent;
            findProc.ForeColor = Color.White;
            Selo.SetStyleRefl(findProc, ControlStyles.SupportsTransparentBackColor, true);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            activateDisableGUI.BackColor = Color.Transparent;
            activateDisableGUI.ForeColor = Color.White;
            Selo.SetStyleRefl(activateDisableGUI, ControlStyles.SupportsTransparentBackColor, true);
            activateFreeCamera.BackColor = Color.Transparent;
            activateFreeCamera.ForeColor = Color.White;
            Selo.SetStyleRefl(activateFreeCamera, ControlStyles.SupportsTransparentBackColor, true);

            _config = new XmlConfig();
            if (File.Exists("config.xml"))
                _config = XmlParser.Parse<XmlConfig>(File.ReadAllText("config.xml"));

            switch (_config.Language)
            {
                case "en":
                    title.Text = "The Witcher: Enhanced Edition Developer Console Activator";
                    activate.Text = "Activate";
                    activateFreeCamera.Text = "Free Camera";
                    activateDisableGUI.Text = "Disable GUI";
                    findProc.Text = _findingProcess = "Searching for the process...";
                    Text = "Developer Console Activator";
                    break;
                case "ru":
                    break;
            }
            
            _findAppTimer = new Timer(_config.Interval);
            _findAppTimer.Elapsed += OnAppTimerElapsed;
            _findAppTimer.AutoReset = true;
            _findAppTimer.Enabled = true;
            findProc.Text = string.Empty;

            WDCActivator.Load();
            if (WDCActivator.PId == 0 || WDCActivator.Mem.mProc.Process == null)
            {
                ResetButtons();
                findProc.Text = _findingProcess;
                WDCActivator.IsLoaded = false;
            }
        }

        private void OnAppTimerElapsed(object sender, ElapsedEventArgs e)
        {
            WDCActivator.Load();
            if (WDCActivator.PId == 0 || WDCActivator.Mem.mProc.Process == null)
            {
                findProc.Text = _findingProcess;
                ResetButtons();
                _activated = false;
                WDCActivator.IsLoaded = false;
            }
            else
            {
                findProc.Text = string.Empty;
                EnableButtons();
                if (_config.Auto && !_activated)
                {
                    activate.Checked = true;
                    AutoActivate();
                    _activated = true;
                }
            }
        }

        private void activate_CheckedChanged(object sender, EventArgs e)
        {
            if (WDCActivator.PId == 0 || WDCActivator.Mem.mProc.Process == null)
            {
                ResetButtons();
                findProc.Text = _findingProcess;
                _activated = false;
                WDCActivator.IsLoaded = false;
                return;
            }
            WDCActivator.Activate(activate.Checked ? "1" : "0");
        }

        private async void AutoActivate()
        {
            await Task.Delay(3000);
            WDCActivator.Activate("1");
        }

        private void activateFreeCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (WDCActivator.PId == 0 || WDCActivator.Mem.mProc.Process == null)
            {
                ResetButtons();
                findProc.Text = _findingProcess;
                _activated = false;
                WDCActivator.IsLoaded = false;
                return;
            }
            WDCActivator.ActivateFreeCamera(activateFreeCamera.Checked ? "1" : "0");
        }

        private void disableGUI_CheckedChanged(object sender, EventArgs e)
        {
            if (WDCActivator.PId == 0 || WDCActivator.Mem.mProc.Process == null)
            {
                ResetButtons();
                findProc.Text = _findingProcess;
                _activated = false;
                WDCActivator.IsLoaded = false;
                return;
            }
            WDCActivator.DisableGUI(activateDisableGUI.Checked ? "1" : "0");
        }

        private void ResetButtons()
        {
            activate.Enabled = activate.Checked = false;
            activateFreeCamera.Enabled = activateFreeCamera.Checked = false;
            activateDisableGUI.Enabled = activateDisableGUI.Checked = false;
        }

        private void EnableButtons() => activate.Enabled = activateFreeCamera.Enabled = activateDisableGUI.Enabled = true;
    }
}
