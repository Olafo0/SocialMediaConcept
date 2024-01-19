﻿using SocialMediaConcept.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace SocialMediaConcept
{
    public partial class MainWindow : Form
    {


        string connectionString = ConfigurationManager.AppSettings["connectionString"];

        //Current User
        UserClass CurrentLoggedUser;

        int CurrentLikeButton = 0;
        int PostCharLimit = 80;

        public MainWindow(string loginUsername)
        {
            InitializeComponent();

            // Setting up settings
            ImageUploader.AllowDrop = true;
            ImageUploader.SizeMode = PictureBoxSizeMode.StretchImage;
            TimelinePanel.VerticalScroll.Enabled = true;
            PostCharLimit = 80;

            // Setting up Textboxs
            CharLimitLB.Text = PostCharLimit.ToString();

            // Setting up Necessary controls
            NecesseryControlsSetUp();


            // Setting up the user
            SettingUpUser(loginUsername);

            // Setting up the posts
            GetUserPosts();
        }

        private void SettingUpUser(string LoggedUser)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                using (SqlCommand cmd = new SqlCommand("SettingUserUp", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LoggedUsername", LoggedUser);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int UserID = int.Parse(reader["UserID"].ToString());
                            string Username = reader["Username"].ToString();
                            string Password = reader["Password_"].ToString();
                            string Email = reader["Email"].ToString();
                            string DisplayName = reader["DisplayName"].ToString();
                            Object TempProfilePictre = reader["ProfilePictureImage"];

                            byte[]? ProfilePicture;
                            if (TempProfilePictre == DBNull.Value)
                            {
                                ProfilePicture = null;
                            }
                            else
                            {
                                ProfilePicture = (byte[]?)TempProfilePictre;
                            }
                            UserClass NewUser = new UserClass(UserID, Username, Password, Email, DisplayName, ProfilePicture);
                            CurrentLoggedUser = NewUser;
                        }
                    }

                }
            }
        }

        // Declaring Controls
        Label NameOfImageLB = new Label();

        private void NecesseryControlsSetUp()
        {

            // Creating Post Panel
            NameOfImageLB.Location = new Point(326, 62);
            CreatePostPanel.Controls.Add(NameOfImageLB);


        }

        private void GetUserPosts()
        {
            // Loads the users posts on the timeline 
        }


        private void PostBTN_Click(object sender, EventArgs e)
        {
            PostCharLimit = 80;
            CreatePostPanel.Visible = true;
        }

        Image ImageUploadedToPost;
        
        private void ImageUploader_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (extension != null && (extension.ToLower() == ".jpeg" || extension.ToLower() == ".jpg" || extension.ToLower() == ".png"))
                    {

                        // Deletes the file File format of the file uploaded.
                        string TempFileName = Path.GetFileName(file);
                        int ExtensionsIndex = TempFileName.LastIndexOf(extension);
                        string FileName = TempFileName.Substring(0, ExtensionsIndex);
                        ErrorImagePB.Visible = false;
                        ErrorLB.Visible = false;

                        // This should be added to Post_Click to add Images added. 
                        NameOfImageLB.Text = FileName;


                        ImageUploadedToPost = Image.FromFile(file);
                        ImageUploader.Image = Image.FromFile(file);
                        break;
                    }
                    else
                    {
                        ErrorImagePB.Visible = true;
                        ErrorLB.Visible = true;
                    }
                }
            }
        }
        private void ImageUploader_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void CreateCloseBTN_Click(object sender, EventArgs e)
        {


            // Clearing Post Panels when closed. 
            PostCharLimit = 80;
            CharLimitLB.Text = PostCharLimit.ToString();
            CreatePostPanel.Visible = false;
            ImageUploader.Image = null;
            CreateTitlePostTB.Text = null;
            NameOfImageLB.Text = null;
            ErrorLB.Visible = false;
            ErrorImagePB.Visible = false; 
        }

        private void SharePostBTN_Click(object sender, EventArgs e)
        {
            PostCharLimit = 80;
            CharLimitLB.Text = PostCharLimit.ToString();
            string TextInputted = CreateTitlePostTB.Text;


            // Size of Post : 295, 202
            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(260, 202);


            // Like button
            Button LikeButton = new Button();
            LikeButton.BackColor = Color.HotPink;
            LikeButton.Text = "Like";
            LikeButton.Size = new Size(30, 30);
            LikeButton.Location = new(215, 125);


            // Title 
            Label Title = new Label();
            Title.Text = TextInputted;
            Title.Location = new(9, 135);
            Title.Size = new(196, 57);

            // PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new(5, 5);
            pictureBox.Size = new Size(205, 125);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = ImageUploadedToPost; 



            // get image from drop and upload it to the picturebox and make it into a MemeoryStream
            panel.Controls.Add(LikeButton);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(Title);
            TimelinePanel.Controls.Add(panel);

            // Uploading the Post to the database.
            // Making the image into a MemoryStream
            byte[] ImageDataUploaded;

            MemoryStream ms = new MemoryStream();
            ImageUploadedToPost.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ImageDataUploaded = ms.ToArray();
            

            UserPosts newPost = new UserPosts(null, CurrentLoggedUser.UserID,ImageDataUploaded,CreateTitlePostTB.Text,"",0,DateTime.Now);

            MessageBox.Show(newPost.PostTitle);

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                using (SqlCommand cmd = new SqlCommand("UploadPost", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@userID", newPost.UserID);
                    //cmd.Parameters.Add("@postPicture", System.Data.SqlDbType.VarBinary, -1).Value = newPost.PostPicture;
                    cmd.Parameters.AddWithValue("@postPicture", newPost.PostPicture);
                    cmd.Parameters.AddWithValue("@postTitle", newPost.PostTitle);
                    cmd.Parameters.AddWithValue("@descripition", newPost.Descripition);
                    cmd.Parameters.AddWithValue("@likes", newPost.Likes);
                    cmd.Parameters.AddWithValue("@datePosted", newPost.DatePosted);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cnn.Close();
                }
            };

            CreateCloseBTN_Click(null, null);
        }

        private void TimelinePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CreateTitlePostTB_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back && String.IsNullOrEmpty(CreateTitlePostTB.Text))
            {
                MessageBox.Show("No :" + CreateTitlePostTB.Text.Length.ToString());
            }
            else if (e.KeyCode == Keys.Back && CreateTitlePostTB.Text.Length > 0)
            {
                PostCharLimit += 1;
                CharLimitLB.Text = PostCharLimit.ToString();
            }
            else
            {
                if (PostCharLimit <= 0)
                {

                }
                else
                {
                    PostCharLimit -= 1;
                    CharLimitLB.Text = PostCharLimit.ToString();
                }

            }
        }


        // When characters are selected and then deleted.
        private void CreateTitlePostTB_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Back && CreateTitlePostTB.SelectionLength > 0)
            //{
            //    int SelectedDelLength = CreateTitlePostTB.SelectionLength;
            //    PostCharLimit += SelectedDelLength;
            //}
        }

        private void CreateTitlePostTB_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == '\b' && CreateTitlePostTB.SelectedText.Length > 0)
            //{
            //    int SelectedDelLength = CreateTitlePostTB.SelectionLength;
            //    PostCharLimit += SelectedDelLength;
            //}
        }

        private void CreateTitlePostTB_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void CreateTitlePostTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
