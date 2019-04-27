namespace IggClient
{
    partial class IGGResolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IGGResolver));
            this.button1 = new System.Windows.Forms.Button();
            this.unresolvedBox = new System.Windows.Forms.TextBox();
            this.resolvedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.torrentLabel2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.resolverButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.directdlButton = new System.Windows.Forms.Button();
            this.torrentButton = new System.Windows.Forms.Button();
            this.hestia = new System.Windows.Forms.PictureBox();
            this.credits1 = new System.Windows.Forms.Label();
            this.credits2 = new System.Windows.Forms.Label();
            this.torrentUrl = new System.Windows.Forms.TextBox();
            this.magnetLink = new System.Windows.Forms.TextBox();
            this.torrentLabel1 = new System.Windows.Forms.Label();
            this.magnetgrabButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hestia)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(278, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resolve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // unresolvedBox
            // 
            this.unresolvedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.unresolvedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unresolvedBox.ForeColor = System.Drawing.Color.White;
            this.unresolvedBox.Location = new System.Drawing.Point(34, 109);
            this.unresolvedBox.Name = "unresolvedBox";
            this.unresolvedBox.Size = new System.Drawing.Size(732, 20);
            this.unresolvedBox.TabIndex = 1;
            this.unresolvedBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resolvedBox
            // 
            this.resolvedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.resolvedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resolvedBox.ForeColor = System.Drawing.Color.White;
            this.resolvedBox.Location = new System.Drawing.Point(34, 261);
            this.resolvedBox.Name = "resolvedBox";
            this.resolvedBox.Size = new System.Drawing.Size(732, 20);
            this.resolvedBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Put the URL here!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // torrentLabel2
            // 
            this.torrentLabel2.AutoSize = true;
            this.torrentLabel2.ForeColor = System.Drawing.Color.White;
            this.torrentLabel2.Location = new System.Drawing.Point(31, 284);
            this.torrentLabel2.Name = "torrentLabel2";
            this.torrentLabel2.Size = new System.Drawing.Size(141, 13);
            this.torrentLabel2.TabIndex = 4;
            this.torrentLabel2.Text = "Magnet link comes out here!";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(750, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(700, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 50);
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // resolverButton
            // 
            this.resolverButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.resolverButton.FlatAppearance.BorderSize = 0;
            this.resolverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolverButton.ForeColor = System.Drawing.Color.White;
            this.resolverButton.Location = new System.Drawing.Point(0, 0);
            this.resolverButton.Name = "resolverButton";
            this.resolverButton.Size = new System.Drawing.Size(175, 50);
            this.resolverButton.TabIndex = 6;
            this.resolverButton.Text = "Bluemediafiles Resolver";
            this.resolverButton.UseVisualStyleBackColor = false;
            this.resolverButton.Click += new System.EventHandler(this.resolverButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.Color.Maroon;
            this.searchButton.Location = new System.Drawing.Point(175, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(175, 50);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // directdlButton
            // 
            this.directdlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.directdlButton.FlatAppearance.BorderSize = 0;
            this.directdlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directdlButton.ForeColor = System.Drawing.Color.DarkRed;
            this.directdlButton.Location = new System.Drawing.Point(350, 0);
            this.directdlButton.Name = "directdlButton";
            this.directdlButton.Size = new System.Drawing.Size(175, 50);
            this.directdlButton.TabIndex = 8;
            this.directdlButton.Text = "Direct Download";
            this.directdlButton.UseVisualStyleBackColor = false;
            // 
            // torrentButton
            // 
            this.torrentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.torrentButton.FlatAppearance.BorderSize = 0;
            this.torrentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.torrentButton.ForeColor = System.Drawing.Color.White;
            this.torrentButton.Location = new System.Drawing.Point(525, 0);
            this.torrentButton.Name = "torrentButton";
            this.torrentButton.Size = new System.Drawing.Size(175, 50);
            this.torrentButton.TabIndex = 9;
            this.torrentButton.Text = "Torrent";
            this.torrentButton.UseVisualStyleBackColor = false;
            this.torrentButton.Click += new System.EventHandler(this.torrentButton_Click);
            // 
            // hestia
            // 
            this.hestia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hestia.BackgroundImage")));
            this.hestia.Location = new System.Drawing.Point(791, 999);
            this.hestia.Name = "hestia";
            this.hestia.Size = new System.Drawing.Size(956, 465);
            this.hestia.TabIndex = 10;
            this.hestia.TabStop = false;
            // 
            // credits1
            // 
            this.credits1.AutoSize = true;
            this.credits1.Font = new System.Drawing.Font("Noto Sans CJK SC Medium", 54.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.credits1.ForeColor = System.Drawing.Color.White;
            this.credits1.Location = new System.Drawing.Point(-12, 6999);
            this.credits1.Name = "credits1";
            this.credits1.Size = new System.Drawing.Size(412, 108);
            this.credits1.TabIndex = 11;
            this.credits1.Text = "IGG Client";
            // 
            // credits2
            // 
            this.credits2.AutoSize = true;
            this.credits2.Font = new System.Drawing.Font("Noto Sans CJK SC Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.credits2.ForeColor = System.Drawing.Color.White;
            this.credits2.Location = new System.Drawing.Point(-509, 207);
            this.credits2.Name = "credits2";
            this.credits2.Size = new System.Drawing.Size(241, 28);
            this.credits2.TabIndex = 12;
            this.credits2.Text = "- With love, from Hestia!";
            // 
            // torrentUrl
            // 
            this.torrentUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.torrentUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.torrentUrl.ForeColor = System.Drawing.Color.White;
            this.torrentUrl.Location = new System.Drawing.Point(34, 109);
            this.torrentUrl.Name = "torrentUrl";
            this.torrentUrl.Size = new System.Drawing.Size(732, 20);
            this.torrentUrl.TabIndex = 13;
            // 
            // magnetLink
            // 
            this.magnetLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.magnetLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.magnetLink.ForeColor = System.Drawing.Color.White;
            this.magnetLink.Location = new System.Drawing.Point(34, 261);
            this.magnetLink.Name = "magnetLink";
            this.magnetLink.Size = new System.Drawing.Size(732, 20);
            this.magnetLink.TabIndex = 14;
            // 
            // torrentLabel1
            // 
            this.torrentLabel1.AutoSize = true;
            this.torrentLabel1.ForeColor = System.Drawing.Color.White;
            this.torrentLabel1.Location = new System.Drawing.Point(31, 132);
            this.torrentLabel1.Name = "torrentLabel1";
            this.torrentLabel1.Size = new System.Drawing.Size(193, 13);
            this.torrentLabel1.TabIndex = 15;
            this.torrentLabel1.Text = "Put IGG or PCGamesTorrent URL here.";
            // 
            // magnetgrabButton
            // 
            this.magnetgrabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.magnetgrabButton.FlatAppearance.BorderSize = 0;
            this.magnetgrabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magnetgrabButton.ForeColor = System.Drawing.Color.White;
            this.magnetgrabButton.Location = new System.Drawing.Point(278, 334);
            this.magnetgrabButton.Name = "magnetgrabButton";
            this.magnetgrabButton.Size = new System.Drawing.Size(265, 70);
            this.magnetgrabButton.TabIndex = 16;
            this.magnetgrabButton.Text = "Grab Magnet";
            this.magnetgrabButton.UseVisualStyleBackColor = false;
            this.magnetgrabButton.Click += new System.EventHandler(this.magnetgrabButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Resolved URL comes out here!";
            // 
            // IGGResolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.torrentLabel2);
            this.Controls.Add(this.torrentUrl);
            this.Controls.Add(this.credits2);
            this.Controls.Add(this.torrentButton);
            this.Controls.Add(this.directdlButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resolverButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unresolvedBox);
            this.Controls.Add(this.credits1);
            this.Controls.Add(this.hestia);
            this.Controls.Add(this.magnetLink);
            this.Controls.Add(this.resolvedBox);
            this.Controls.Add(this.magnetgrabButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.torrentLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IGGResolver";
            this.Text = "IGG Client";
            this.Load += new System.EventHandler(this.IGGResolver_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IGGResolver_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IGGResolver_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.hestia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox unresolvedBox;
        private System.Windows.Forms.TextBox resolvedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label torrentLabel2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button resolverButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button directdlButton;
        private System.Windows.Forms.Button torrentButton;
        private System.Windows.Forms.PictureBox hestia;
        private System.Windows.Forms.Label credits1;
        private System.Windows.Forms.Label credits2;
        private System.Windows.Forms.TextBox torrentUrl;
        private System.Windows.Forms.TextBox magnetLink;
        private System.Windows.Forms.Label torrentLabel1;
        private System.Windows.Forms.Button magnetgrabButton;
        private System.Windows.Forms.Label label2;
    }
}

