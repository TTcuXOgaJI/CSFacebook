namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    partial class FormFacebookAccountBoard
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
            this.pictureBoxUserSmallPicture = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowMoreInfo = new System.Windows.Forms.Button();
            this.tabControlAllNews = new System.Windows.Forms.TabControl();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.tabPageNews = new System.Windows.Forms.TabPage();
            this.buttonLinkToUrl = new System.Windows.Forms.Button();
            this.buttonCommits = new System.Windows.Forms.Button();
            this.buttonCloseTab = new System.Windows.Forms.Button();
            this.groupBoxFFilters = new System.Windows.Forms.GroupBox();
            this.labelContentFilter = new System.Windows.Forms.Label();
            this.labelNameFilter = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRefreshTable = new System.Windows.Forms.Button();
            this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
            this.listBoxCheckIns = new System.Windows.Forms.ListBox();
            this.labelCheckIns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserSmallPicture)).BeginInit();
            this.tabControlAllNews.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            this.groupBoxFFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUserSmallPicture
            // 
            this.pictureBoxUserSmallPicture.Location = new System.Drawing.Point(12, 49);
            this.pictureBoxUserSmallPicture.Name = "pictureBoxUserSmallPicture";
            this.pictureBoxUserSmallPicture.Size = new System.Drawing.Size(134, 134);
            this.pictureBoxUserSmallPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserSmallPicture.TabIndex = 0;
            this.pictureBoxUserSmallPicture.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(28, 23);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(108, 23);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name";
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(12, 208);
            this.textBoxPostStatus.Multiline = true;
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPostStatus.Size = new System.Drawing.Size(551, 50);
            this.textBoxPostStatus.TabIndex = 2;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(569, 208);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(101, 50);
            this.buttonPostStatus.TabIndex = 3;
            this.buttonPostStatus.Text = "Post New Status";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(164, 49);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(134, 134);
            this.listBoxFriends.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Friends";
            // 
            // buttonShowMoreInfo
            // 
            this.buttonShowMoreInfo.Location = new System.Drawing.Point(12, 276);
            this.buttonShowMoreInfo.Name = "buttonShowMoreInfo";
            this.buttonShowMoreInfo.Size = new System.Drawing.Size(658, 26);
            this.buttonShowMoreInfo.TabIndex = 6;
            this.buttonShowMoreInfo.Text = "⇊  ⇊  ShowMoreInfo  ⇊  ⇊";
            this.buttonShowMoreInfo.UseVisualStyleBackColor = true;
            this.buttonShowMoreInfo.Click += new System.EventHandler(this.buttonShowMoreInfo_Click);
            // 
            // tabControlAllNews
            // 
            this.tabControlAllNews.Controls.Add(this.tabPageEvents);
            this.tabControlAllNews.Controls.Add(this.tabPagePosts);
            this.tabControlAllNews.Controls.Add(this.tabPageNews);
            this.tabControlAllNews.Location = new System.Drawing.Point(12, 373);
            this.tabControlAllNews.Name = "tabControlAllNews";
            this.tabControlAllNews.SelectedIndex = 0;
            this.tabControlAllNews.Size = new System.Drawing.Size(658, 182);
            this.tabControlAllNews.TabIndex = 7;
            this.tabControlAllNews.SelectedIndexChanged += new System.EventHandler(this.tabControlAllNews_SelectedIndexChanged);
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvents.Size = new System.Drawing.Size(650, 156);
            this.tabPageEvents.TabIndex = 0;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.Controls.Add(this.dataGridViewPosts);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 22);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePosts.Size = new System.Drawing.Size(650, 156);
            this.tabPagePosts.TabIndex = 2;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
            // 
            // tabPageNews
            // 
            this.tabPageNews.Location = new System.Drawing.Point(4, 22);
            this.tabPageNews.Name = "tabPageNews";
            this.tabPageNews.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNews.Size = new System.Drawing.Size(650, 156);
            this.tabPageNews.TabIndex = 3;
            this.tabPageNews.Text = "News";
            this.tabPageNews.UseVisualStyleBackColor = true;
            // 
            // buttonLinkToUrl
            // 
            this.buttonLinkToUrl.Location = new System.Drawing.Point(12, 561);
            this.buttonLinkToUrl.Name = "buttonLinkToUrl";
            this.buttonLinkToUrl.Size = new System.Drawing.Size(75, 23);
            this.buttonLinkToUrl.TabIndex = 8;
            this.buttonLinkToUrl.Text = "button1";
            this.buttonLinkToUrl.UseVisualStyleBackColor = true;
            // 
            // buttonCommits
            // 
            this.buttonCommits.Location = new System.Drawing.Point(119, 561);
            this.buttonCommits.Name = "buttonCommits";
            this.buttonCommits.Size = new System.Drawing.Size(75, 23);
            this.buttonCommits.TabIndex = 9;
            this.buttonCommits.Text = "button2";
            this.buttonCommits.UseVisualStyleBackColor = true;
            // 
            // buttonCloseTab
            // 
            this.buttonCloseTab.Location = new System.Drawing.Point(591, 561);
            this.buttonCloseTab.Name = "buttonCloseTab";
            this.buttonCloseTab.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseTab.TabIndex = 10;
            this.buttonCloseTab.Text = "button3";
            this.buttonCloseTab.UseVisualStyleBackColor = true;
            // 
            // groupBoxFFilters
            // 
            this.groupBoxFFilters.Controls.Add(this.labelContentFilter);
            this.groupBoxFFilters.Controls.Add(this.labelNameFilter);
            this.groupBoxFFilters.Controls.Add(this.textBox2);
            this.groupBoxFFilters.Controls.Add(this.textBox1);
            this.groupBoxFFilters.Location = new System.Drawing.Point(12, 308);
            this.groupBoxFFilters.Name = "groupBoxFFilters";
            this.groupBoxFFilters.Size = new System.Drawing.Size(500, 60);
            this.groupBoxFFilters.TabIndex = 11;
            this.groupBoxFFilters.TabStop = false;
            this.groupBoxFFilters.Text = "Filters";
            // 
            // labelContentFilter
            // 
            this.labelContentFilter.AutoSize = true;
            this.labelContentFilter.Location = new System.Drawing.Point(225, 41);
            this.labelContentFilter.Name = "labelContentFilter";
            this.labelContentFilter.Size = new System.Drawing.Size(50, 13);
            this.labelContentFilter.TabIndex = 3;
            this.labelContentFilter.Text = "Content :";
            // 
            // labelNameFilter
            // 
            this.labelNameFilter.AutoSize = true;
            this.labelNameFilter.Location = new System.Drawing.Point(6, 41);
            this.labelNameFilter.Name = "labelNameFilter";
            this.labelNameFilter.Size = new System.Drawing.Size(63, 13);
            this.labelNameFilter.TabIndex = 2;
            this.labelNameFilter.Text = "UserName :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonRefreshTable
            // 
            this.buttonRefreshTable.Location = new System.Drawing.Point(518, 308);
            this.buttonRefreshTable.Name = "buttonRefreshTable";
            this.buttonRefreshTable.Size = new System.Drawing.Size(147, 59);
            this.buttonRefreshTable.TabIndex = 12;
            this.buttonRefreshTable.Text = "Refresh";
            this.buttonRefreshTable.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPosts
            // 
            this.dataGridViewPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPosts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPosts.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPosts.MultiSelect = false;
            this.dataGridViewPosts.Name = "dataGridViewPosts";
            this.dataGridViewPosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPosts.Size = new System.Drawing.Size(644, 150);
            this.dataGridViewPosts.TabIndex = 1;
            // 
            // listBoxCheckIns
            // 
            this.listBoxCheckIns.FormattingEnabled = true;
            this.listBoxCheckIns.Location = new System.Drawing.Point(305, 49);
            this.listBoxCheckIns.Name = "listBoxCheckIns";
            this.listBoxCheckIns.Size = new System.Drawing.Size(158, 134);
            this.listBoxCheckIns.TabIndex = 13;
            // 
            // labelCheckIns
            // 
            this.labelCheckIns.AutoSize = true;
            this.labelCheckIns.Font = new System.Drawing.Font("Arial Narrow", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIns.Location = new System.Drawing.Point(344, 21);
            this.labelCheckIns.Name = "labelCheckIns";
            this.labelCheckIns.Size = new System.Drawing.Size(85, 25);
            this.labelCheckIns.TabIndex = 14;
            this.labelCheckIns.Text = "Checkins";
            // 
            // FormFacebookAccountBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 306);
            this.Controls.Add(this.labelCheckIns);
            this.Controls.Add(this.listBoxCheckIns);
            this.Controls.Add(this.buttonRefreshTable);
            this.Controls.Add(this.groupBoxFFilters);
            this.Controls.Add(this.buttonCloseTab);
            this.Controls.Add(this.buttonCommits);
            this.Controls.Add(this.buttonLinkToUrl);
            this.Controls.Add(this.tabControlAllNews);
            this.Controls.Add(this.buttonShowMoreInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxUserSmallPicture);
            this.Name = "FormFacebookAccountBoard";
            this.Text = "FormFacebookAccountBoard";
            this.Load += new System.EventHandler(this.FormFacebookAccountBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserSmallPicture)).EndInit();
            this.tabControlAllNews.ResumeLayout(false);
            this.tabPagePosts.ResumeLayout(false);
            this.groupBoxFFilters.ResumeLayout(false);
            this.groupBoxFFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUserSmallPicture;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowMoreInfo;
        private System.Windows.Forms.TabControl tabControlAllNews;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.TabPage tabPageNews;
        private System.Windows.Forms.Button buttonLinkToUrl;
        private System.Windows.Forms.Button buttonCommits;
        private System.Windows.Forms.Button buttonCloseTab;
        private System.Windows.Forms.GroupBox groupBoxFFilters;
        private System.Windows.Forms.Label labelContentFilter;
        private System.Windows.Forms.Label labelNameFilter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRefreshTable;
        private System.Windows.Forms.DataGridView dataGridViewPosts;
        private System.Windows.Forms.ListBox listBoxCheckIns;
        private System.Windows.Forms.Label labelCheckIns;
    }
}