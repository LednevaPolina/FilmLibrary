namespace FilmLibrary
{
    partial class PriceIntoForm
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
            this.textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPriceTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxYears = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxCountries = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxFilms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диапазон стоимости от";
            // 
            // textBoxPriceFrom
            // 
            this.textBoxPriceFrom.Location = new System.Drawing.Point(180, 12);
            this.textBoxPriceFrom.Name = "textBoxPriceFrom";
            this.textBoxPriceFrom.Size = new System.Drawing.Size(100, 22);
            this.textBoxPriceFrom.TabIndex = 1;
            this.textBoxPriceFrom.TextChanged += new System.EventHandler(this.textBoxPriceFrom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "до";
            // 
            // textBoxPriceTo
            // 
            this.textBoxPriceTo.Location = new System.Drawing.Point(315, 12);
            this.textBoxPriceTo.Name = "textBoxPriceTo";
            this.textBoxPriceTo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPriceTo.TabIndex = 3;
            this.textBoxPriceTo.TextChanged += new System.EventHandler(this.textBoxPriceFrom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Года";
            // 
            // listBoxYears
            // 
            this.listBoxYears.FormattingEnabled = true;
            this.listBoxYears.ItemHeight = 16;
            this.listBoxYears.Location = new System.Drawing.Point(12, 68);
            this.listBoxYears.Name = "listBoxYears";
            this.listBoxYears.Size = new System.Drawing.Size(190, 180);
            this.listBoxYears.TabIndex = 5;
            this.listBoxYears.SelectedIndexChanged += new System.EventHandler(this.textBoxPriceFrom_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Страны";
            // 
            // listBoxCountries
            // 
            this.listBoxCountries.FormattingEnabled = true;
            this.listBoxCountries.ItemHeight = 16;
            this.listBoxCountries.Location = new System.Drawing.Point(208, 68);
            this.listBoxCountries.Name = "listBoxCountries";
            this.listBoxCountries.Size = new System.Drawing.Size(190, 180);
            this.listBoxCountries.TabIndex = 7;
            this.listBoxCountries.SelectedIndexChanged += new System.EventHandler(this.textBoxPriceFrom_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Фильмы";
            // 
            // listBoxFilms
            // 
            this.listBoxFilms.FormattingEnabled = true;
            this.listBoxFilms.ItemHeight = 16;
            this.listBoxFilms.Location = new System.Drawing.Point(442, 68);
            this.listBoxFilms.Name = "listBoxFilms";
            this.listBoxFilms.Size = new System.Drawing.Size(298, 180);
            this.listBoxFilms.TabIndex = 9;
            // 
            // PriceIntoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 267);
            this.Controls.Add(this.listBoxFilms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxCountries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxYears);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPriceTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPriceFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PriceIntoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск по диапазону цен, году и стране";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPriceFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPriceTo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBoxYears;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox listBoxCountries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxFilms;
    }
}