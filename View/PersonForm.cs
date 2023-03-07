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
    public partial class PersonForm : Form
    {
        public bool? Gender;
        public PersonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxGender.SelectedIndex == -1)
                return;
            Gender = comboBoxGender.SelectedIndex == 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Person_Load(object sender, EventArgs e)
        {
            if (Gender != null)
                comboBoxGender.SelectedIndex = Gender == true ? 0 : 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
