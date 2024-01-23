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
            CharLimitLB = new Label();
            label4 = new Label();
            CreateTitlePostTB = new RichTextBox();
            label3 = new Label();
            SharePostBTN = new Button();
            label2 = new Label();
            ErrorImagePB = new PictureBox();
            ErrorLB = new Label();
            CreateCloseBTN = new Button();
            ImageUploader = new PictureBox();
            label1 = new Label();
            RefreshFeedBTN = new Button();
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
            TimelinePanel.Size = new Size(281, 426);
            TimelinePanel.TabIndex = 0;
            TimelinePanel.Paint += TimelinePanel_Paint;
            // 
            // PostBTN
            // 
            PostBTN.BackColor = Color.DodgerBlue;
            PostBTN.FlatStyle = FlatStyle.Flat;
            PostBTN.Location = new Point(663, 12);
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
            CreatePostPanel.Controls.Add(CharLimitLB);
            CreatePostPanel.Controls.Add(label4);
            CreatePostPanel.Controls.Add(CreateTitlePostTB);
            CreatePostPanel.Controls.Add(label3);
            CreatePostPanel.Controls.Add(SharePostBTN);
            CreatePostPanel.Controls.Add(label2);
            CreatePostPanel.Controls.Add(ErrorImagePB);
            CreatePostPanel.Controls.Add(ErrorLB);
            CreatePostPanel.Controls.Add(CreateCloseBTN);
            CreatePostPanel.Controls.Add(ImageUploader);
            CreatePostPanel.Controls.Add(label1);
            CreatePostPanel.Location = new Point(141, 6);
            CreatePostPanel.Name = "CreatePostPanel";
            CreatePostPanel.Size = new Size(515, 439);
            CreatePostPanel.TabIndex = 2;
            CreatePostPanel.Visible = false;
            // 
            // CharLimitLB
            // 
            CharLimitLB.AutoSize = true;
            CharLimitLB.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CharLimitLB.ForeColor = SystemColors.ControlText;
            CharLimitLB.Location = new Point(160, 369);
            CharLimitLB.Name = "CharLimitLB";
            CharLimitLB.Size = new Size(12, 13);
            CharLimitLB.TabIndex = 11;
            CharLimitLB.Text = "x";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 369);
            label4.Name = "label4";
            label4.Size = new Size(117, 13);
            label4.TabIndex = 10;
            label4.Text = "Characters remaining :";
            // 
            // CreateTitlePostTB
            // 
            CreateTitlePostTB.Location = new Point(19, 309);
            CreateTitlePostTB.MaxLength = 80;
            CreateTitlePostTB.Name = "CreateTitlePostTB";
            CreateTitlePostTB.Size = new Size(196, 57);
            CreateTitlePostTB.TabIndex = 9;
            CreateTitlePostTB.Text = "";
            CreateTitlePostTB.SelectionChanged += CreateTitlePostTB_SelectionChanged;
            CreateTitlePostTB.TextChanged += CreateTitlePostTB_TextChanged;
            CreateTitlePostTB.KeyDown += CreateTitlePostTB_KeyDown;
            CreateTitlePostTB.KeyPress += CreateTitlePostTB_KeyPress_1;
            CreateTitlePostTB.KeyUp += CreateTitlePostTB_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 291);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 8;
            label3.Text = "Title";
            // 
            // SharePostBTN
            // 
            SharePostBTN.Location = new Point(421, 397);
            SharePostBTN.Name = "SharePostBTN";
            SharePostBTN.Size = new Size(64, 26);
            SharePostBTN.TabIndex = 6;
            SharePostBTN.Text = "Post";
            SharePostBTN.UseVisualStyleBackColor = true;
            SharePostBTN.Click += SharePostBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 48);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 5;
            label2.Text = "Image added ";
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
            // RefreshFeedBTN
            // 
            RefreshFeedBTN.Location = new Point(663, 53);
            RefreshFeedBTN.Name = "RefreshFeedBTN";
            RefreshFeedBTN.Size = new Size(75, 23);
            RefreshFeedBTN.TabIndex = 3;
            RefreshFeedBTN.Text = "Refresh";
            RefreshFeedBTN.UseVisualStyleBackColor = true;
            RefreshFeedBTN.Click += RefreshFeedBTN_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RefreshFeedBTN);
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
        private Label label3;
        private Button SharePostBTN;
        private RichTextBox CreateTitlePostTB;
        private Label label4;
        private Label label5;
        private Label CharLimitLB;
        private Button RefreshFeedBTN;
    }
}