namespace TestingApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerControl = new AudioPlayer.PlayerControl();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.volumeLevel = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.volumeLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // playerControl
            // 
            this.playerControl.FilePath = "";
            this.playerControl.LabelColor = System.Drawing.Color.Red;
            this.playerControl.Location = new System.Drawing.Point(12, 12);
            this.playerControl.Name = "playerControl";
            this.playerControl.PauseBtnColor = System.Drawing.Color.Lime;
            this.playerControl.PauseBtnText = "Stop";
            this.playerControl.PlayBtnColor = System.Drawing.Color.Aqua;
            this.playerControl.PlayBtnText = "Graj";
            this.playerControl.Size = new System.Drawing.Size(216, 69);
            this.playerControl.TabIndex = 0;
            this.playerControl.Visible = false;
            this.playerControl.VolumeLevel = 100;
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "MP3 File (*.mp3)|*.mp3";
            this.fileDialog.InitialDirectory = "%userprofile%/Music";
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(132, 107);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(75, 23);
            this.loadFileBtn.TabIndex = 1;
            this.loadFileBtn.Text = "Load file";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // volumeLevel
            // 
            this.volumeLevel.Location = new System.Drawing.Point(12, 107);
            this.volumeLevel.Maximum = 100;
            this.volumeLevel.Name = "volumeLevel";
            this.volumeLevel.Size = new System.Drawing.Size(104, 45);
            this.volumeLevel.SmallChange = 10;
            this.volumeLevel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 167);
            this.Controls.Add(this.volumeLevel);
            this.Controls.Add(this.loadFileBtn);
            this.Controls.Add(this.playerControl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.volumeLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AudioPlayer.PlayerControl playerControl;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.TrackBar volumeLevel;
    }
}

