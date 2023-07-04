namespace DatabaseSqlMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadAlbumsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.addAlbumGroup = new System.Windows.Forms.GroupBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txtBx_Description = new System.Windows.Forms.TextBox();
            this.txtBx_ImageUrl = new System.Windows.Forms.TextBox();
            this.txtBx_Year = new System.Windows.Forms.TextBox();
            this.txtBx_Artist = new System.Windows.Forms.TextBox();
            this.txtBx_AlbumName = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.imageUrlLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.artistNameLbl = new System.Windows.Forms.Label();
            this.albumNameLbl = new System.Windows.Forms.Label();
            this.lbl_TrackList = new System.Windows.Forms.Label();
            this.dataGrid_TrackList = new System.Windows.Forms.DataGridView();
            this.btn_DeleteTrack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBx_Number = new System.Windows.Forms.TextBox();
            this.ComboBx_AlbumID = new System.Windows.Forms.ComboBox();
            this.btn_Add_Update_Track = new System.Windows.Forms.Button();
            this.txtBx_Lyrics = new System.Windows.Forms.TextBox();
            this.txtBx_VideoUrl = new System.Windows.Forms.TextBox();
            this.txtBx_TrackTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btn_EditSelectedTrack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.addAlbumGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_TrackList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadAlbumsBtn
            // 
            resources.ApplyResources(this.loadAlbumsBtn, "loadAlbumsBtn");
            this.loadAlbumsBtn.Name = "loadAlbumsBtn";
            this.loadAlbumsBtn.UseVisualStyleBackColor = true;
            this.loadAlbumsBtn.Click += new System.EventHandler(this.loadAlbumsBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchBtn
            // 
            resources.ApplyResources(this.searchBtn, "searchBtn");
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchField
            // 
            resources.ApplyResources(this.searchField, "searchField");
            this.searchField.Name = "searchField";
            this.searchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchField_KeyPress);
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // addAlbumGroup
            // 
            this.addAlbumGroup.Controls.Add(this.btn_Insert);
            this.addAlbumGroup.Controls.Add(this.txtBx_Description);
            this.addAlbumGroup.Controls.Add(this.txtBx_ImageUrl);
            this.addAlbumGroup.Controls.Add(this.txtBx_Year);
            this.addAlbumGroup.Controls.Add(this.txtBx_Artist);
            this.addAlbumGroup.Controls.Add(this.txtBx_AlbumName);
            this.addAlbumGroup.Controls.Add(this.descriptionLbl);
            this.addAlbumGroup.Controls.Add(this.imageUrlLbl);
            this.addAlbumGroup.Controls.Add(this.yearLbl);
            this.addAlbumGroup.Controls.Add(this.artistNameLbl);
            this.addAlbumGroup.Controls.Add(this.albumNameLbl);
            resources.ApplyResources(this.addAlbumGroup, "addAlbumGroup");
            this.addAlbumGroup.Name = "addAlbumGroup";
            this.addAlbumGroup.TabStop = false;
            // 
            // btn_Insert
            // 
            resources.ApplyResources(this.btn_Insert, "btn_Insert");
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txtBx_Description
            // 
            resources.ApplyResources(this.txtBx_Description, "txtBx_Description");
            this.txtBx_Description.Name = "txtBx_Description";
            // 
            // txtBx_ImageUrl
            // 
            resources.ApplyResources(this.txtBx_ImageUrl, "txtBx_ImageUrl");
            this.txtBx_ImageUrl.Name = "txtBx_ImageUrl";
            // 
            // txtBx_Year
            // 
            resources.ApplyResources(this.txtBx_Year, "txtBx_Year");
            this.txtBx_Year.Name = "txtBx_Year";
            // 
            // txtBx_Artist
            // 
            resources.ApplyResources(this.txtBx_Artist, "txtBx_Artist");
            this.txtBx_Artist.Name = "txtBx_Artist";
            // 
            // txtBx_AlbumName
            // 
            resources.ApplyResources(this.txtBx_AlbumName, "txtBx_AlbumName");
            this.txtBx_AlbumName.Name = "txtBx_AlbumName";
            // 
            // descriptionLbl
            // 
            resources.ApplyResources(this.descriptionLbl, "descriptionLbl");
            this.descriptionLbl.Name = "descriptionLbl";
            // 
            // imageUrlLbl
            // 
            resources.ApplyResources(this.imageUrlLbl, "imageUrlLbl");
            this.imageUrlLbl.Name = "imageUrlLbl";
            // 
            // yearLbl
            // 
            resources.ApplyResources(this.yearLbl, "yearLbl");
            this.yearLbl.Name = "yearLbl";
            // 
            // artistNameLbl
            // 
            resources.ApplyResources(this.artistNameLbl, "artistNameLbl");
            this.artistNameLbl.Name = "artistNameLbl";
            // 
            // albumNameLbl
            // 
            resources.ApplyResources(this.albumNameLbl, "albumNameLbl");
            this.albumNameLbl.Name = "albumNameLbl";
            // 
            // lbl_TrackList
            // 
            resources.ApplyResources(this.lbl_TrackList, "lbl_TrackList");
            this.lbl_TrackList.Name = "lbl_TrackList";
            // 
            // dataGrid_TrackList
            // 
            this.dataGrid_TrackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_TrackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGrid_TrackList, "dataGrid_TrackList");
            this.dataGrid_TrackList.Name = "dataGrid_TrackList";
            this.dataGrid_TrackList.RowTemplate.Height = 29;
            this.dataGrid_TrackList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_TrackList_CellClick);
            // 
            // btn_DeleteTrack
            // 
            resources.ApplyResources(this.btn_DeleteTrack, "btn_DeleteTrack");
            this.btn_DeleteTrack.Name = "btn_DeleteTrack";
            this.btn_DeleteTrack.UseVisualStyleBackColor = true;
            this.btn_DeleteTrack.Click += new System.EventHandler(this.btn_DeleteTrack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBx_Number);
            this.groupBox1.Controls.Add(this.ComboBx_AlbumID);
            this.groupBox1.Controls.Add(this.btn_Add_Update_Track);
            this.groupBox1.Controls.Add(this.txtBx_Lyrics);
            this.groupBox1.Controls.Add(this.txtBx_VideoUrl);
            this.groupBox1.Controls.Add(this.txtBx_TrackTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtBx_Number
            // 
            resources.ApplyResources(this.txtBx_Number, "txtBx_Number");
            this.txtBx_Number.Name = "txtBx_Number";
            // 
            // ComboBx_AlbumID
            // 
            this.ComboBx_AlbumID.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBx_AlbumID, "ComboBx_AlbumID");
            this.ComboBx_AlbumID.Name = "ComboBx_AlbumID";
            // 
            // btn_Add_Update_Track
            // 
            resources.ApplyResources(this.btn_Add_Update_Track, "btn_Add_Update_Track");
            this.btn_Add_Update_Track.Name = "btn_Add_Update_Track";
            this.btn_Add_Update_Track.UseVisualStyleBackColor = true;
            this.btn_Add_Update_Track.Click += new System.EventHandler(this.btn_Add_Update_Track_Click);
            // 
            // txtBx_Lyrics
            // 
            resources.ApplyResources(this.txtBx_Lyrics, "txtBx_Lyrics");
            this.txtBx_Lyrics.Name = "txtBx_Lyrics";
            // 
            // txtBx_VideoUrl
            // 
            resources.ApplyResources(this.txtBx_VideoUrl, "txtBx_VideoUrl");
            this.txtBx_VideoUrl.Name = "txtBx_VideoUrl";
            // 
            // txtBx_TrackTitle
            // 
            resources.ApplyResources(this.txtBx_TrackTitle, "txtBx_TrackTitle");
            this.txtBx_TrackTitle.Name = "txtBx_TrackTitle";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            resources.ApplyResources(this.webView, "webView");
            this.webView.Name = "webView";
            this.webView.Source = new System.Uri("https://www.youtube.com", System.UriKind.Absolute);
            this.webView.ZoomFactor = 0.65D;
            // 
            // btn_EditSelectedTrack
            // 
            resources.ApplyResources(this.btn_EditSelectedTrack, "btn_EditSelectedTrack");
            this.btn_EditSelectedTrack.Name = "btn_EditSelectedTrack";
            this.btn_EditSelectedTrack.UseVisualStyleBackColor = true;
            this.btn_EditSelectedTrack.Click += new System.EventHandler(this.btn_EditSelectedTrack_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btn_EditSelectedTrack);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_DeleteTrack);
            this.Controls.Add(this.dataGrid_TrackList);
            this.Controls.Add(this.lbl_TrackList);
            this.Controls.Add(this.addAlbumGroup);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadAlbumsBtn);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.addAlbumGroup.ResumeLayout(false);
            this.addAlbumGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_TrackList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loadAlbumsBtn;
        private DataGridView dataGridView1;
        private Button searchBtn;
        private TextBox searchField;
        private PictureBox pictureBox;
        private GroupBox addAlbumGroup;
        private Label imageUrlLbl;
        private Label yearLbl;
        private Label artistNameLbl;
        private Label albumNameLbl;
        private TextBox txtBx_Description;
        private TextBox txtBx_ImageUrl;
        private TextBox txtBx_Year;
        private TextBox txtBx_Artist;
        private TextBox txtBx_AlbumName;
        private Label descriptionLbl;
        private Button btn_Insert;
        private Label lbl_TrackList;
        private DataGridView dataGrid_TrackList;
        private Button btn_DeleteTrack;
        private GroupBox groupBox1;
        private ComboBox ComboBx_AlbumID;
        private Button btn_Add_Update_Track;
        private TextBox txtBx_Lyrics;
        private TextBox txtBx_VideoUrl;
        private TextBox txtBx_TrackTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Button btn_EditSelectedTrack;
        private TextBox txtBx_Number;
    }
}