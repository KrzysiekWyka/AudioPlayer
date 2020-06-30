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

            _player.settings.volume = trackBar1.Value;

            trackBar1.ValueChanged += TrackBar1_ValueChanged;
            
            _player.PlayStateChange += Player_PlayStateChange;
            _player.MediaError += Player_MediaError;
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            _player.settings.volume = trackBar1.Value;
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

        public static float NewFontSize(Graphics graphics, Size size, Font font, string str)
        {
            SizeF stringSize = graphics.MeasureString(str, font);
            float wRatio = size.Width / stringSize.Width;
            float hRatio = size.Height / stringSize.Height;
            float ratio = Math.Min(hRatio, wRatio);
            return (font.Size * ratio) - ((float)0.2 * (font.Size * ratio));
        }

        private void playBtn_Paint(object sender, PaintEventArgs e)
        {
            float fontSize = NewFontSize(e.Graphics, playBtn.Size, playBtn.Font, playBtn.Text);
            
            Font f = new Font("Arial", fontSize, FontStyle.Bold);
            playBtn.Font = f;
        }

        private void pauseBtn_Paint(object sender, PaintEventArgs e)
        {
            float fontSize = NewFontSize(e.Graphics, pauseBtn.Size, pauseBtn.Font, pauseBtn.Text);

            Font f = new Font("Arial", fontSize, FontStyle.Bold);
            pauseBtn.Font = f;
        }

        private void infoLbl_Paint(object sender, PaintEventArgs e)
        {
            float fontSize = NewFontSize(e.Graphics, infoLbl.Size, infoLbl.Font, infoLbl.Text);

            Font f = new Font("Arial", fontSize, FontStyle.Bold);
            infoLbl.Font = f;
        }
    }
}
