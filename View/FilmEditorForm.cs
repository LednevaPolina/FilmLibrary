using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
    public partial class FilmEditorForm : Form
    {
        public FilmEditorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBoxPrice.Text);
                try
                {
                    Convert.ToInt32(textBoxViewers.Text);
                    try
                    {
                        Convert.ToInt32(textBoxYear.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Год должен быть числом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Число зрителей должно быть числом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Стоимость должна быть числом", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
