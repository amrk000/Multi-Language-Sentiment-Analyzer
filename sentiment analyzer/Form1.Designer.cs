namespace sentiment_analyzer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.result = new System.Windows.Forms.Label();
            this.unicodeEmoji = new System.Windows.Forms.Label();
            this.paragraphStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sentiment Analyzer";
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputText.ContextMenuStrip = this.contextMenuStrip1;
            this.inputText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputText.Location = new System.Drawing.Point(434, 98);
            this.inputText.Margin = new System.Windows.Forms.Padding(10);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(550, 501);
            this.inputText.TabIndex = 1;
            this.inputText.Tag = "";
            this.inputText.Text = "";
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            this.inputText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputText_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem1.Text = "Copy";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem2.Text = "Cut";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem3.Text = "Paste";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem4.Text = "Select All";
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(12, 447);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(404, 69);
            this.result.TabIndex = 3;
            this.result.Text = "What Do You Have?";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unicodeEmoji
            // 
            this.unicodeEmoji.Font = new System.Drawing.Font("Arial Narrow", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unicodeEmoji.Location = new System.Drawing.Point(12, 114);
            this.unicodeEmoji.Name = "unicodeEmoji";
            this.unicodeEmoji.Size = new System.Drawing.Size(404, 302);
            this.unicodeEmoji.TabIndex = 4;
            this.unicodeEmoji.Text = "🤔";
            // 
            // paragraphStatus
            // 
            this.paragraphStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paragraphStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paragraphStatus.ForeColor = System.Drawing.Color.Gray;
            this.paragraphStatus.Location = new System.Drawing.Point(12, 541);
            this.paragraphStatus.Name = "paragraphStatus";
            this.paragraphStatus.Size = new System.Drawing.Size(404, 45);
            this.paragraphStatus.TabIndex = 5;
            this.paragraphStatus.Text = "0 Characters, 0 Words, 0 Sentences";
            this.paragraphStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.settings);
            this.panel1.Controls.Add(this.about);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sentiment_analyzer.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // settings
            // 
            this.settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.Image = global::sentiment_analyzer.Properties.Resources.settings;
            this.settings.Location = new System.Drawing.Point(768, -14);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(3);
            this.settings.Size = new System.Drawing.Size(105, 114);
            this.settings.TabIndex = 7;
            this.settings.Text = "Settings";
            this.settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // about
            // 
            this.about.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.about.ForeColor = System.Drawing.Color.White;
            this.about.Image = global::sentiment_analyzer.Properties.Resources.about1;
            this.about.Location = new System.Drawing.Point(879, -14);
            this.about.Name = "about";
            this.about.Padding = new System.Windows.Forms.Padding(3);
            this.about.Size = new System.Drawing.Size(105, 114);
            this.about.TabIndex = 1;
            this.about.Text = "About";
            this.about.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paragraphStatus);
            this.Controls.Add(this.unicodeEmoji);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentiment Analyzer | FCI 2022 | Arabization Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private RichTextBox inputText;
        private Label result;
        private Label unicodeEmoji;
        private Label paragraphStatus;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private Button about;
        private Button settings;
        private PictureBox pictureBox1;
    }
}