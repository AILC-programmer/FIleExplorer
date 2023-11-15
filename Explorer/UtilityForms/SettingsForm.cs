using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer.UtilityForms
{
    public partial class SettingsForm : MetroForm
    {
        private string directoryName = "Settings";
        private string settingsPath;
        public SettingsForm()
        {
            InitializeComponent();

            settingsPath = Path.Combine(Application.StartupPath, directoryName);

            if (!Directory.Exists(settingsPath))
                Directory.CreateDirectory(settingsPath);
            
        }


    }
}
