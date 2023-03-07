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
    public partial class DirectorActorForm : Form
    {
        FilmContext db;
        public DirectorActorForm()
        {
            InitializeComponent();
            db = new FilmContext();
            db.Films.Load();
        }

        private void DirectorActor_Load(object sender, EventArgs e)
        {
            var result =
                from a in db.Actors
                from d in db.Directors
                where d.Name == a.Name
                select d.Name;
            foreach (var u in result)
                listBoxDirectors.Items.Add(u);
        }
    }
}
