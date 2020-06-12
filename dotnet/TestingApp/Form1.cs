using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            volumeLevel.Value = 80;

            volumeLevel.ValueChanged += VolumeLevel_ValueChanged;
        }

        private void VolumeLevel_ValueChanged(object sender, EventArgs e)
        {
            playerControl.VolumeLevel = volumeLevel.Value;
        }

        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                playerControl.Visible = true;

                playerControl.FilePath = fileDialog.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(Width, Height);
        }
    }
}
