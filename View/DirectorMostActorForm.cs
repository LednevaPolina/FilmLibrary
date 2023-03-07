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
    public partial class DirectorMostActorForm : Form
    {
        FilmContext db;
        public DirectorMostActorForm()
        {
            InitializeComponent();
            db = new FilmContext();
            db.Films.Load();
        }

        private void listBoxActors_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDirectors.Items.Clear();
            try
            {
                int wealth = (listBoxActors.SelectedItem as Actor).Wealth;
                var result =
                    from d in db.Directors
                    where d.Wealth > wealth
                    select d.Name;
                foreach (var u in result)
                    listBoxDirectors.Items.Add(u);
            }
            catch { }
        }

        private void DirectorMostActor_Load(object sender, EventArgs e)
        {
            List<Actor> actor = db.Actors.ToList();
            listBoxActors.DataSource = actor;
            listBoxActors.ValueMember = "Wealth";
            listBoxActors.DisplayMember = "Name";
        }
    }
}
