using SocialMediaConcept.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
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


            // Setting up the posts
            GetUserPosts();


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

        Image img;
        int yLocationOfNOMLB = 62;
        List<string> ListOfImageName = new List<string>();
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
                        string TempFileName = Path.GetFileName(file);
                        int ExtensionsIndex = TempFileName.LastIndexOf(extension);
                        string FileName = TempFileName.Substring(0, ExtensionsIndex);

                        ErrorImagePB.Visible = false;
                        ErrorLB.Visible = false;

                        // This should be added to Post_Click to add Images added. 
                        //Label NameOfImageLB = new Label();
                        //NameOfImageLB.Text = FileName;
                        //NameOfImageLB.Location = new(326, yLocationOfNOMLB);
                        ListOfImageName.Add(FileName);

                        yLocationOfNOMLB += 14;


                        // 326, 48 14
                        Image img = Image.FromFile(file);
                        ImageUploader.Image = img;
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
            PostCharLimit = 80;
            CharLimitLB.Text = PostCharLimit.ToString();
            CreatePostPanel.Visible = false;
            ImageUploader.Image = null;
            CreateTitlePostTB.Text = null;
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
            pictureBox.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Coding part2\\SocialMediaConcept\\SocialMediaConcept\\Resources\\Satsudou.PNG");



            panel.Controls.Add(LikeButton);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(Title);
            TimelinePanel.Controls.Add(panel);

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
