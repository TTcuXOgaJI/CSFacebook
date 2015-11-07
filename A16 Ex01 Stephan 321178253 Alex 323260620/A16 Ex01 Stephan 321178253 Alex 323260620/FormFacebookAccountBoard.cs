using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Facebook;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public partial class FormFacebookAccountBoard : Form
    {
        private readonly WallPostsConverter r_WallPosts = new WallPostsConverter();
        private bool isSlideMenu = false;
        public FormFacebookAccountBoard()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void hiddenInfoPanelSwitcher(bool isOnOf)
        {
            groupBoxFFilters.Enabled = isOnOf;
            buttonCloseTab.Enabled = isOnOf;
            buttonCommits.Enabled = isOnOf;
            buttonLinkToUrl.Enabled = isOnOf;
            buttonRefreshTable.Enabled = isOnOf;
            tabControlAllNews.Enabled = isOnOf;         
        }

        private void hiddenInfoPanelRefresher()
        {
            listBoxCheckIns.Refresh();
            listBoxFriends.Refresh();
            groupBoxFFilters.Refresh();
            buttonCloseTab.Refresh();
            buttonCommits.Refresh();
            buttonLinkToUrl.Refresh();
            buttonRefreshTable.Refresh();
            tabControlAllNews.Refresh();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            hiddenInfoPanelSwitcher(false);            
            pictureBoxUserSmallPicture.LoadAsync(FacebookServiceSession.LoggedFacebookUser.PictureNormalURL);
            labelUserName.Text = FacebookServiceSession.LoggedFacebookUser.Name;
            foreach (User friend in FacebookServiceSession.LoggedFacebookUser.Friends)
            {
                listBoxFriends.Items.Add(friend.Name);
            }
            foreach (Checkin checkin in FacebookServiceSession.LoggedFacebookUser.Checkins)
            {
                listBoxCheckIns.Items.Add(checkin.Place.Name);
            }
        }


        private void FormFacebookAccountBoard_Load(object sender, EventArgs e)
        {

        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            if (textBoxPostStatus.Text.Length != 0)
            {
                Status postedStatus = FacebookServiceSession.LoggedFacebookUser.PostStatus(textBoxPostStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                textBoxPostStatus.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowMoreInfo_Click(object sender, EventArgs e)
        {
            //698; 345 original size ,698; 625
            if (!isSlideMenu)
            {
                dataGridViewPosts.Visible = false;
                hiddenInfoPanelSwitcher(true);
                for (int i = 345; i <= 628; i++)
                {
                    this.Height = i;
                    hiddenInfoPanelRefresher();
                }
                fillSelectedTabGrid();
                dataGridViewPosts.Visible = true;
                isSlideMenu = true;
            }
            else if (isSlideMenu)
            {
                for (int i = 628; i >= 345; i--)
                {
                    this.Height = i;
                  
                }
                hiddenInfoPanelSwitcher(false);
                isSlideMenu = false;
            }

        }

        private void tabControlAllNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillSelectedTabGrid();
        }

        private void fillSelectedTabGrid()
        {
            if (tabControlAllNews.SelectedTab == tabPageEvents)
            {
              
            }
            else if (tabControlAllNews.SelectedTab == tabPagePosts)
            {
                r_WallPosts.RequestPostRecordsUpdate();
                dataGridViewPosts.DataSource = r_WallPosts.PostRecords;
            }
        }

        private void dataGridViewPosts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxUserSmallPicture_Click(object sender, EventArgs e)
        {
            
        }
    }
}
