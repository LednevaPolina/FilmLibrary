namespace FilmLibrary
{
    partial class DirectorMostActorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxActors = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDirectors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Актеры";
            // 
            // listBoxActors
            // 
            this.listBoxActors.FormattingEnabled = true;
            this.listBoxActors.ItemHeight = 16;
            this.listBoxActors.Location = new System.Drawing.Point(12, 28);
            this.listBoxActors.Name = "listBoxActors";
            this.listBoxActors.Size = new System.Drawing.Size(276, 308);
            this.listBoxActors.TabIndex = 1;
            this.listBoxActors.SelectedIndexChanged += new System.EventHandler(this.listBoxActors_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Руководители киностудий";
            // 
            // listBoxDirectors
            // 
            this.listBoxDirectors.FormattingEnabled = true;
            this.listBoxDirectors.ItemHeight = 16;
            this.listBoxDirectors.Location = new System.Drawing.Point(310, 28);
            this.listBoxDirectors.Name = "listBoxDirectors";
            this.listBoxDirectors.Size = new System.Drawing.Size(300, 308);
            this.listBoxDirectors.TabIndex = 3;
            // 
            // DirectorMostActorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.listBoxDirectors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxActors);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectorMostActorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск руководителей с состоянием больше актера";
            this.Load += new System.EventHandler(this.DirectorMostActor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxActors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDirectors;
    }
}