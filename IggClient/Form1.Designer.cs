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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resolve!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // unresolvedBox
            // 
            this.unresolvedBox.Location = new System.Drawing.Point(32, 72);
            this.unresolvedBox.Name = "unresolvedBox";
            this.unresolvedBox.Size = new System.Drawing.Size(732, 20);
            this.unresolvedBox.TabIndex = 1;
            this.unresolvedBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resolvedBox
            // 
            this.resolvedBox.Location = new System.Drawing.Point(32, 224);
            this.resolvedBox.Name = "resolvedBox";
            this.resolvedBox.Size = new System.Drawing.Size(732, 20);
            this.resolvedBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Put the url here!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resolved url comes out here!";
            // 
            // IGGResolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resolvedBox);
            this.Controls.Add(this.unresolvedBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IGGResolver";
            this.Text = "IGG Link Resolver";
            this.Load += new System.EventHandler(this.IGGResolver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox unresolvedBox;
        private System.Windows.Forms.TextBox resolvedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

