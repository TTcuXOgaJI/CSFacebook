using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public partial class FormLogin : Form
    {
        private bool isSlideMenu = false;

        public FormLogin()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void buttonSlidePanel_Click(object sender, EventArgs e)
        {
            //Open Side Panel
            if (isSlideMenu == false)
            {
                buttonDeletFromUsersList.Enabled = true;
                listBoxRememberedUsers.Enabled = true;
                for (int i = 171; i <= 385; i++)
                {
                    this.Width = i;
                    buttonDeletFromUsersList.Refresh();
                    listBoxRememberedUsers.Refresh();
                    labelRememberedUsers.Refresh();
                   // Thread.Sleep(2);
                }
                isSlideMenu = true;

            }

           //Hide Slide Panel
            else if (isSlideMenu == true)
            {

                for (int i = 385; i >= 171; i--)
                {
                    this.Width = i;
                   // Thread.Sleep(2);
                }
                buttonDeletFromUsersList.Enabled = false;
                listBoxRememberedUsers.Enabled = false;
                isSlideMenu = false;
            }
            //Start Size 171; 234, Slide Size 385; 234
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (FacebookServiceSession.TryToLogIn())
            {
                Form formFacebookAccountBoard = new FormFacebookAccountBoard();
                swapLoginFormToAccountBoardForm(formFacebookAccountBoard);

            }
        }


        private void swapLoginFormToAccountBoardForm(Form formAccountBoard)
        {
             this.Hide();
             formAccountBoard.ShowDialog();
             this.Show();
             FacebookServiceSession.Logout();
        }
    }
}
