namespace SocialMediaConcept
{
    partial class MainWindow
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
            TimelinePanel = new FlowLayoutPanel();
            PostBTN = new Button();
            CreatePostPanel = new Panel();
            ErrorImagePB = new PictureBox();
            ErrorLB = new Label();
            CreateCloseBTN = new Button();
            ImageUploader = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            CreatePostPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorImagePB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageUploader).BeginInit();
            SuspendLayout();
            // 
            // TimelinePanel
            // 
            TimelinePanel.AutoScroll = true;
            TimelinePanel.AutoScrollMargin = new Size(20, 20);
            TimelinePanel.AutoScrollMinSize = new Size(50, 50);
            TimelinePanel.BackColor = SystemColors.Info;
            TimelinePanel.Location = new Point(376, 12);
            TimelinePanel.Name = "TimelinePanel";
            TimelinePanel.Size = new Size(315, 426);
            TimelinePanel.TabIndex = 0;
            // 
            // PostBTN
            // 
            PostBTN.BackColor = Color.DodgerBlue;
            PostBTN.FlatStyle = FlatStyle.Flat;
            PostBTN.Location = new Point(697, 12);
            PostBTN.Name = "PostBTN";
            PostBTN.Size = new Size(77, 35);
            PostBTN.TabIndex = 1;
            PostBTN.Text = "Post";
            PostBTN.UseVisualStyleBackColor = false;
            PostBTN.Click += PostBTN_Click;
            // 
            // CreatePostPanel
            // 
            CreatePostPanel.BackColor = SystemColors.AppWorkspace;
            CreatePostPanel.Controls.Add(label2);
            CreatePostPanel.Controls.Add(ErrorImagePB);
            CreatePostPanel.Controls.Add(ErrorLB);
            CreatePostPanel.Controls.Add(CreateCloseBTN);
            CreatePostPanel.Controls.Add(ImageUploader);
            CreatePostPanel.Controls.Add(label1);
            CreatePostPanel.Location = new Point(176, 5);
            CreatePostPanel.Name = "CreatePostPanel";
            CreatePostPanel.Size = new Size(515, 439);
            CreatePostPanel.TabIndex = 2;
            CreatePostPanel.Visible = false;
            // 
            // ErrorImagePB
            // 
            ErrorImagePB.BackgroundImage = Properties.Resources.ErrorImage;
            ErrorImagePB.BackgroundImageLayout = ImageLayout.Stretch;
            ErrorImagePB.Location = new Point(19, 250);
            ErrorImagePB.Name = "ErrorImagePB";
            ErrorImagePB.Size = new Size(31, 27);
            ErrorImagePB.TabIndex = 4;
            ErrorImagePB.TabStop = false;
            ErrorImagePB.Visible = false;
            // 
            // ErrorLB
            // 
            ErrorLB.AutoSize = true;
            ErrorLB.ForeColor = Color.DarkRed;
            ErrorLB.Location = new Point(60, 257);
            ErrorLB.Name = "ErrorLB";
            ErrorLB.Size = new Size(215, 15);
            ErrorLB.TabIndex = 3;
            ErrorLB.Text = "Image format must be : jpeg,jpg, or png";
            ErrorLB.Visible = false;
            // 
            // CreateCloseBTN
            // 
            CreateCloseBTN.Location = new Point(449, 7);
            CreateCloseBTN.Name = "CreateCloseBTN";
            CreateCloseBTN.Size = new Size(61, 25);
            CreateCloseBTN.TabIndex = 2;
            CreateCloseBTN.Text = "Close";
            CreateCloseBTN.UseVisualStyleBackColor = true;
            CreateCloseBTN.Click += CreateCloseBTN_Click;
            // 
            // ImageUploader
            // 
            ImageUploader.BackColor = SystemColors.Control;
            ImageUploader.Location = new Point(19, 48);
            ImageUploader.Name = "ImageUploader";
            ImageUploader.Size = new Size(280, 196);
            ImageUploader.TabIndex = 1;
            ImageUploader.TabStop = false;
            ImageUploader.DragDrop += ImageUploader_DragDrop;
            ImageUploader.DragEnter += ImageUploader_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Create your post";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 48);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 5;
            label2.Text = "Image added ";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreatePostPanel);
            Controls.Add(PostBTN);
            Controls.Add(TimelinePanel);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainWindow";
            Text = "MainWindow";
            CreatePostPanel.ResumeLayout(false);
            CreatePostPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorImagePB).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageUploader).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel TimelinePanel;
        private Button PostBTN;
        private Panel panel1;
        private Panel CreatePostPanel;
        private PictureBox ImageUploader;
        private Label label1;
        private Button CreateCloseBTN;
        private PictureBox ErrorImagePB;
        private Label ErrorLB;
        private Label label2;
    }
}