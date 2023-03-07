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
    public partial class FindActorsForm : Form
    {
        FilmContext db;
        public FindActorsForm()
        {
            InitializeComponent();
            db = new FilmContext();
            db.Films.Load();
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxActors.Items.Clear();
            if (comboBoxGender.SelectedIndex < 0)
                return;
            int film = (listBoxFilms.SelectedItems[0] as Film).Id;
            bool gender = comboBoxGender.SelectedIndex == 0;
            var result =
                from f in db.Films
                from a in f.Actors
                where f.Id == film && a.Gender == gender
                select a.Name;
            foreach (var u in result)
                listBoxActors.Items.Add(u);
        }

        private void FindActors_Load(object sender, EventArgs e)
        {
            List<Film> films = db.Films.ToList();
            listBoxFilms.DataSource = films;
            listBoxFilms.ValueMember = "Id";
            listBoxFilms.DisplayMember = "Name";
        }
    }
}
