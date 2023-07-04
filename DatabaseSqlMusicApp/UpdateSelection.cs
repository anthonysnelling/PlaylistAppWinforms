using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSqlMusicApp
{
    public partial class UpdateSelection : Form
    {
        public int trackID = -1;
        public string? trackTitle = string.Empty;
        public int trackNumber = 0;
        public string? trackVideoUrl = string.Empty;
        public string? trackLyrics = string.Empty;
        public int trackAlbumID = 0;
        public DataGridView grid;
        public Form1 initialForm;

        public UpdateSelection()
        {
            InitializeComponent();
        }

        internal void updateFields()
        {
            txtBx_TrackTitle.Text = trackTitle;
            txtBx_Number.Text = trackNumber.ToString();
            txtBx_VideoUrl.Text = trackVideoUrl;
            txtBx_Lyrics.Text = trackLyrics;

            AlbumsDAO albumsDAO = new AlbumsDAO();
            ComboBx_AlbumID.DataSource = albumsDAO.getAlbumIDs();
            ComboBx_AlbumID.SelectedItem = trackAlbumID + " - " + albumsDAO.getAlbumTitleFromTrack(trackAlbumID);
            //MessageBox.Show($"{trackTitle}, {trackNumber}, {trackVideoUrl}, {trackLyrics}, {trackAlbumID}");
            //MessageBox.Show(trackAlbumID + " - " + albumsDAO.getAlbumTitleFromTrack(trackAlbumID));
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            if(trackID != -1)
            albumsDAO.updateTrack(trackID, txtBx_TrackTitle.Text, Int32.Parse(txtBx_Number.Text),
                txtBx_VideoUrl.Text, txtBx_Lyrics.Text, Int32.Parse(ComboBx_AlbumID.SelectedValue.ToString().Substring(0,1)));

            MessageBox.Show("Track Updated");
            grid.DataSource = null;
            initialForm.albums = albumsDAO.getAllAlbums();
            this.FindForm().Close();
        }
    }
}
