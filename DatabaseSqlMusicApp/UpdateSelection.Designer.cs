namespace DatabaseSqlMusicApp
{
    partial class UpdateSelection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBx_Number = new System.Windows.Forms.TextBox();
            this.ComboBx_AlbumID = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txtBx_Lyrics = new System.Windows.Forms.TextBox();
            this.txtBx_VideoUrl = new System.Windows.Forms.TextBox();
            this.txtBx_TrackTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBx_Number);
            this.groupBox1.Controls.Add(this.ComboBx_AlbumID);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.txtBx_Lyrics);
            this.groupBox1.Controls.Add(this.txtBx_VideoUrl);
            this.groupBox1.Controls.Add(this.txtBx_TrackTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(38, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 240);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Track";
            // 
            // txtBx_Number
            // 
            this.txtBx_Number.Location = new System.Drawing.Point(122, 62);
            this.txtBx_Number.Name = "txtBx_Number";
            this.txtBx_Number.Size = new System.Drawing.Size(235, 27);
            this.txtBx_Number.TabIndex = 9;
            // 
            // ComboBx_AlbumID
            // 
            this.ComboBx_AlbumID.FormattingEnabled = true;
            this.ComboBx_AlbumID.Location = new System.Drawing.Point(122, 163);
            this.ComboBx_AlbumID.Name = "ComboBx_AlbumID";
            this.ComboBx_AlbumID.Size = new System.Drawing.Size(235, 28);
            this.ComboBx_AlbumID.TabIndex = 12;
            // 
            // btn_Update
            // 
            this.btn_Update.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Update.Location = new System.Drawing.Point(241, 205);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(116, 29);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txtBx_Lyrics
            // 
            this.txtBx_Lyrics.Location = new System.Drawing.Point(122, 130);
            this.txtBx_Lyrics.Multiline = true;
            this.txtBx_Lyrics.Name = "txtBx_Lyrics";
            this.txtBx_Lyrics.Size = new System.Drawing.Size(235, 27);
            this.txtBx_Lyrics.TabIndex = 11;
            // 
            // txtBx_VideoUrl
            // 
            this.txtBx_VideoUrl.Location = new System.Drawing.Point(122, 96);
            this.txtBx_VideoUrl.Name = "txtBx_VideoUrl";
            this.txtBx_VideoUrl.Size = new System.Drawing.Size(235, 27);
            this.txtBx_VideoUrl.TabIndex = 10;
            // 
            // txtBx_TrackTitle
            // 
            this.txtBx_TrackTitle.Location = new System.Drawing.Point(122, 28);
            this.txtBx_TrackTitle.Name = "txtBx_TrackTitle";
            this.txtBx_TrackTitle.Size = new System.Drawing.Size(235, 27);
            this.txtBx_TrackTitle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Album ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(9, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lyrics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Video URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(9, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Track Title";
            // 
            // UpdateSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 304);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateSelection";
            this.Text = "UpdateSelection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBx_Number;
        private ComboBox ComboBx_AlbumID;
        private Button btn_Update;
        private TextBox txtBx_Lyrics;
        private TextBox txtBx_VideoUrl;
        private TextBox txtBx_TrackTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}