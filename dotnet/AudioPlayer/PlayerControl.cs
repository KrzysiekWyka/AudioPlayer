using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AudioPlayer
{
    public partial class PlayerControl: UserControl
    {
        private string _filePath = string.Empty;
        private Color _playBtnColor = DefaultBackColor;
        private Color _pauseBtnColor = DefaultBackColor;
        private string _playBtnText = "Play";
        private string _pauseBtnText = "Pause";
        private int _volumeLevel = 100;
        private Color _labelColor = DefaultForeColor;

        #region Custom properties
        [Category("PlayerProperties")]
        public string FilePath
        {
            get => _filePath;
            set
            {
                _filePath = value;

                PlayFile(value);
            }
        }

        [Category("PlayerProperties")]
        public Color PlayBtnColor
        {
            get => _playBtnColor;
            set
            {
                _playBtnColor = value;

                playBtn.BackColor = value;
            }
        }

        [Category("PlayerProperties")]
        public Color PauseBtnColor
        {
            get => _pauseBtnColor;
            set
            {
                _pauseBtnColor = value;

                pauseBtn.BackColor = value;
            }
        }

        [Category("PlayerProperties")]
        public string PlayBtnText
        {
            get => _playBtnText;
            set
            {
                _playBtnText = value;

                playBtn.Text = value;
            }
        }

        [Category("PlayerProperties")]
        public string PauseBtnText
        {
            get => _pauseBtnText;
            set
            {
                _pauseBtnText = value;

                pauseBtn.Text = value;
            }
        }

        [Category("PlayerProperties")]
        public int VolumeLevel
        {
            get => _volumeLevel;
            set
            {
                _volumeLevel = value;

                _player.settings.volume = value;
            }
        }

        [Category("PlayerProperties")]
        public Color LabelColor
        {
            get => _labelColor;
            set
            {
                _labelColor = value;

                infoLbl.ForeColor = value;
            }
        }
        #endregion

        private readonly WindowsMediaPlayer _player = new WindowsMediaPlayer();

        public PlayerControl()
        {
            InitializeComponent();
            
            _player.PlayStateChange += Player_PlayStateChange;
            _player.MediaError += Player_MediaError;
            //_player.settings.volume =
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            _player.controls.play();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            _player.controls.pause();
        }

        private void Player_PlayStateChange(int newState)
        {
            switch ((WMPPlayState)newState)
            {
                case WMPPlayState.wmppsStopped:
                case WMPPlayState.wmppsPaused:
                    playBtn.Enabled = true;
                    pauseBtn.Enabled = false;
                break;
                case WMPPlayState.wmppsPlaying:
                    infoLbl.Text = $@"{_player.controls.currentItem.getItemInfo("Author")} - {_player.controls.currentItem.getItemInfo("Title")}";

                    playBtn.Enabled = false;
                    pauseBtn.Enabled = true;
                    break;
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            //this.Close();
        }


        private void PlayFile(string url)
        {
            _player.URL = url;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PlayFile(openFileDialog1.FileName);
            }
        }
    }
}
