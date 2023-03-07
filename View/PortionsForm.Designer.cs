namespace FilmLibrary
{
    partial class PortionsForm
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
            this.textBoxUp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDown = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxGenres = new System.Windows.Forms.ListBox();
            this.listBoxCountries = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCheaps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPricy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Верхний предел дешевых";
            // 
            // textBoxUp
            // 
            this.textBoxUp.Location = new System.Drawing.Point(190, 12);
            this.textBoxUp.Name = "textBoxUp";
            this.textBoxUp.Size = new System.Drawing.Size(100, 22);
            this.textBoxUp.TabIndex = 1;
            this.textBoxUp.TextChanged += new System.EventHandler(this.textBoxUp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Нижний предел дорогих";
            // 
            // textBoxDown
            // 
            this.textBoxDown.Location = new System.Drawing.Point(190, 40);
            this.textBoxDown.Name = "textBoxDown";
            this.textBoxDown.Size = new System.Drawing.Size(100, 22);
            this.textBoxDown.TabIndex = 3;
            this.textBoxDown.TextChanged += new System.EventHandler(this.textBoxUp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Жанры";
            // 
            // listBoxGenres
            // 
            this.listBoxGenres.FormattingEnabled = true;
            this.listBoxGenres.ItemHeight = 16;
            this.listBoxGenres.Location = new System.Drawing.Point(15, 94);
            this.listBoxGenres.Name = "listBoxGenres";
            this.listBoxGenres.Size = new System.Drawing.Size(184, 196);
            this.listBoxGenres.TabIndex = 5;
            this.listBoxGenres.SelectedIndexChanged += new System.EventHandler(this.textBoxUp_TextChanged);
            // 
            // listBoxCountries
            // 
            this.listBoxCountries.FormattingEnabled = true;
            this.listBoxCountries.ItemHeight = 16;
            this.listBoxCountries.Location = new System.Drawing.Point(205, 94);
            this.listBoxCountries.Name = "listBoxCountries";
            this.listBoxCountries.Size = new System.Drawing.Size(184, 196);
            this.listBoxCountries.TabIndex = 6;
            this.listBoxCountries.SelectedValueChanged += new System.EventHandler(this.textBoxUp_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Страны";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дешевых фильмов";
            // 
            // textBoxCheaps
            // 
            this.textBoxCheaps.Location = new System.Drawing.Point(398, 267);
            this.textBoxCheaps.Name = "textBoxCheaps";
            this.textBoxCheaps.ReadOnly = true;
            this.textBoxCheaps.Size = new System.Drawing.Size(40, 22);
            this.textBoxCheaps.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дорогих фильмов";
            // 
            // textBoxPricy
            // 
            this.textBoxPricy.Location = new System.Drawing.Point(543, 268);
            this.textBoxPricy.Name = "textBoxPricy";
            this.textBoxPricy.ReadOnly = true;
            this.textBoxPricy.Size = new System.Drawing.Size(40, 22);
            this.textBoxPricy.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "%";
            // 
            // PortionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 301);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPricy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCheaps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxCountries);
            this.Controls.Add(this.listBoxGenres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пропорции дешевых и дорогих по жанру и стране";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDown;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBoxGenres;
        public System.Windows.Forms.ListBox listBoxCountries;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCheaps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPricy;
        private System.Windows.Forms.Label label8;
    }
}