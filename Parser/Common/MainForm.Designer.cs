namespace Parser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonScopus = new System.Windows.Forms.Button();
            this.ButtonElibrary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(30, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите базу данных";
            // 
            // ButtonScopus
            // 
            this.ButtonScopus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonScopus.BackColor = System.Drawing.Color.Transparent;
            this.ButtonScopus.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ButtonScopus.FlatAppearance.BorderSize = 2;
            this.ButtonScopus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ButtonScopus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonScopus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonScopus.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonScopus.Location = new System.Drawing.Point(85, 52);
            this.ButtonScopus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonScopus.Name = "ButtonScopus";
            this.ButtonScopus.Size = new System.Drawing.Size(110, 55);
            this.ButtonScopus.TabIndex = 6;
            this.ButtonScopus.Text = "Scopus";
            this.ButtonScopus.UseVisualStyleBackColor = false;
            this.ButtonScopus.Click += new System.EventHandler(this.ButtonScopus_Click);
            // 
            // ButtonElibrary
            // 
            this.ButtonElibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonElibrary.BackColor = System.Drawing.Color.Transparent;
            this.ButtonElibrary.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ButtonElibrary.FlatAppearance.BorderSize = 2;
            this.ButtonElibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ButtonElibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonElibrary.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonElibrary.ForeColor = System.Drawing.Color.Maroon;
            this.ButtonElibrary.Location = new System.Drawing.Point(85, 127);
            this.ButtonElibrary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonElibrary.Name = "ButtonElibrary";
            this.ButtonElibrary.Size = new System.Drawing.Size(110, 55);
            this.ButtonElibrary.TabIndex = 7;
            this.ButtonElibrary.Text = "Elibrary";
            this.ButtonElibrary.UseVisualStyleBackColor = false;
            this.ButtonElibrary.Click += new System.EventHandler(this.ButtonElibrary_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Parser.Properties.Resources.MainForm_background_v2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.ButtonElibrary);
            this.Controls.Add(this.ButtonScopus);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliograph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonScopus;
        private System.Windows.Forms.Button ButtonElibrary;
    }
}

