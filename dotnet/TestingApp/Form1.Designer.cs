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
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.volumeLevel = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playerControl = new AudioPlayer.PlayerControl();
            ((System.ComponentModel.ISupportInitialize)(this.volumeLevel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "MP3 File (*.mp3)|*.mp3";
            this.fileDialog.InitialDirectory = "%userprofile%/Music";
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadFileBtn.Location = new System.Drawing.Point(169, 119);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(160, 44);
            this.loadFileBtn.TabIndex = 1;
            this.loadFileBtn.Text = "Load file";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // volumeLevel
            // 
            this.volumeLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeLevel.Location = new System.Drawing.Point(3, 119);
            this.volumeLevel.Maximum = 100;
            this.volumeLevel.Name = "volumeLevel";
            this.volumeLevel.Size = new System.Drawing.Size(160, 44);
            this.volumeLevel.SmallChange = 10;
            this.volumeLevel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.playerControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadFileBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.volumeLevel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 166);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // playerControl
            // 
            this.playerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerControl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.playerControl, 3);
            this.playerControl.FilePath = "";
            this.playerControl.LabelColor = System.Drawing.Color.Red;
            this.playerControl.Location = new System.Drawing.Point(3, 3);
            this.playerControl.Name = "playerControl";
            this.playerControl.PauseBtnColor = System.Drawing.Color.Lime;
            this.playerControl.PauseBtnText = "Stop";
            this.playerControl.PlayBtnColor = System.Drawing.Color.Aqua;
            this.playerControl.PlayBtnText = "Graj";
            this.playerControl.Size = new System.Drawing.Size(326, 110);
            this.playerControl.TabIndex = 0;
            this.playerControl.Visible = false;
            this.playerControl.VolumeLevel = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 166);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeLevel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AudioPlayer.PlayerControl playerControl;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.TrackBar volumeLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

