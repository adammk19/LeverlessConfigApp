using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Rapid_Trigger_Config.Settings;
using static Rapid_Trigger_Config.App;
using System.IO;

namespace Rapid_Trigger_Config
{
    public partial class ConnectDevice : Form
    {

        public ConnectDevice()
        {
            InitializeComponent();
        }

        private void ConnectDevice_Load(object sender, EventArgs e)
        {
            // nothing to do here
        }

        private void ConnectDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                QuitApp();
            }
        }

        private void QuitApp()
        {
            Application.Exit();
        }
    }
}