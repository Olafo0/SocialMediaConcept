using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


        public MainWindow(string loginUsername)
        {
            InitializeComponent();

            // Setting up settings

            ImageUploader.AllowDrop = true;
            ImageUploader.SizeMode = PictureBoxSizeMode.StretchImage;
            TimelinePanel.VerticalScroll.Enabled = true;
        }

        private void PostBTN_Click(object sender, EventArgs e)
        {
            CreatePostPanel.Visible = true;


            // Size of Post : 295, 202
            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Size = new Size(260, 202);

            Button LikeButton = new Button();
            LikeButton.BackColor = Color.HotPink;
            LikeButton.Text = "Like";
            LikeButton.Size = new Size(75, 50);
            LikeButton.Location = new(180, 135);


            panel.Controls.Add(LikeButton);
            TimelinePanel.Controls.Add(panel);

        }
        private void TimelinePanel_MouseHover(object sender, EventArgs e)
        {
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
            CreatePostPanel.Visible = false;
            ImageUploader.Image = null;
        }
    }
}
