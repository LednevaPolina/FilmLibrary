namespace FilmLibrary
{
    partial class DirectorActorForm
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
            this.listBoxDirectors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxDirectors
            // 
            this.listBoxDirectors.FormattingEnabled = true;
            this.listBoxDirectors.ItemHeight = 16;
            this.listBoxDirectors.Location = new System.Drawing.Point(11, 10);
            this.listBoxDirectors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDirectors.Name = "listBoxDirectors";
            this.listBoxDirectors.Size = new System.Drawing.Size(243, 340);
            this.listBoxDirectors.TabIndex = 0;
            // 
            // DirectorActorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 360);
            this.Controls.Add(this.listBoxDirectors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectorActorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectorActor";
            this.Load += new System.EventHandler(this.DirectorActor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDirectors;
    }
}