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
    public partial class FindFilmsByYearForm : Form
    {
        FilmContext db;
        public FindFilmsByYearForm()
        {
            InitializeComponent();
            db = new FilmContext();
            db.Films.Load();
        }

        private void listBoxActors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxFilms.Items.Clear();
                int year = Convert.ToInt32(textBoxYear.Text);
                int actor = (listBoxActors.SelectedItems[0] as Actor).Id;
                var result =
                    from f in db.Films
                    from a in f.Actors
                    where a.Id == actor && f.Year == year
                    select f.Name;
                foreach (var u in result)
                    listBoxFilms.Items.Add(u);
            }
            catch { }
        }

        private void FindFilmsByYear_Load(object sender, EventArgs e)
        {
            List<Actor> actors = db.Actors.ToList();
            listBoxActors.DataSource = actors;
            listBoxActors.ValueMember = "Id";
            listBoxActors.DisplayMember = "Name";
        }
    }
}
