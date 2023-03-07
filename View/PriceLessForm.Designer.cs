namespace FilmLibrary
{
    partial class PriceLessForm
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
            this.listBoxGenre = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCounties = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxFilmsCompare = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Жанр";
            // 
            // listBoxGenre
            // 
            this.listBoxGenre.FormattingEnabled = true;
            this.listBoxGenre.ItemHeight = 16;
            this.listBoxGenre.Location = new System.Drawing.Point(12, 28);
            this.listBoxGenre.Name = "listBoxGenre";
            this.listBoxGenre.Size = new System.Drawing.Size(187, 292);
            this.listBoxGenre.TabIndex = 1;
            this.listBoxGenre.SelectedIndexChanged += new System.EventHandler(this.listBoxGenre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Страны";
            // 
            // listBoxCounties
            // 
            this.listBoxCounties.FormattingEnabled = true;
            this.listBoxCounties.ItemHeight = 16;
            this.listBoxCounties.Location = new System.Drawing.Point(205, 28);
            this.listBoxCounties.Name = "listBoxCounties";
            this.listBoxCounties.Size = new System.Drawing.Size(187, 292);
            this.listBoxCounties.TabIndex = 3;
            this.listBoxCounties.SelectedIndexChanged += new System.EventHandler(this.listBoxGenre_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фильмы для сравнения";
            // 
            // listBoxFilmsCompare
            // 
            this.listBoxFilmsCompare.FormattingEnabled = true;
            this.listBoxFilmsCompare.ItemHeight = 16;
            this.listBoxFilmsCompare.Location = new System.Drawing.Point(398, 28);
            this.listBoxFilmsCompare.Name = "listBoxFilmsCompare";
            this.listBoxFilmsCompare.Size = new System.Drawing.Size(289, 292);
            this.listBoxFilmsCompare.TabIndex = 5;
            this.listBoxFilmsCompare.SelectedIndexChanged += new System.EventHandler(this.listBoxGenre_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Фильмы, стоимость которых меньше";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 16;
            this.listBoxResult.Location = new System.Drawing.Point(693, 28);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(289, 292);
            this.listBoxResult.TabIndex = 7;
            // 
            // PriceLessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 335);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxFilmsCompare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxCounties);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxGenre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PriceLessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск фильмов дешевле указанного по жанру и стране";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBoxGenre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBoxCounties;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBoxFilmsCompare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}