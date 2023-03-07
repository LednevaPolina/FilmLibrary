using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
    public partial class ActorsCityForm : Form
    {
        FilmContext db;
        public ActorsCityForm()
        {
            InitializeComponent();
            db = new FilmContext();
            db.Films.Load();
            comboBoxGender.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxActors.Items.Clear();
            bool gender = comboBoxGender.SelectedIndex == 0;
            string city = textBoxCity.Text;
            var result =
                from a in db.Actors
                where a.City == city && a.Gender == gender
                select a.Name;
            foreach (var u in result)
                listBoxActors.Items.Add(u);
        }
    }
}
