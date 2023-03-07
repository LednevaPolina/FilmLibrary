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
    public partial class PortionsForm : Form
    {
        FilmContext db;
        public PortionsForm()
        {
            InitializeComponent();
            db = new FilmContext();
            db.Films.Load();
        }

        private void textBoxUp_TextChanged(object sender, EventArgs e)
        {
            textBoxCheaps.Text = "";
            textBoxPricy.Text = "";
            if (listBoxCountries.SelectedItems.Count < 1 || listBoxGenres.SelectedItems.Count < 1)
                return;
            var genre = (listBoxGenres.SelectedItems[0] as Genre).Id;
            string country = listBoxCountries.SelectedItems[0].ToString();
            int total = (
                from f in db.Films
                from g in f.Genres
                where g.Id == genre && f.Country == country
                select f).Count();
            try
            {
                int up = Convert.ToInt32(textBoxUp.Text);
                if (total != 0)
                {
                    var cheaps = (
                        from f in db.Films
                        from g in f.Genres
                        where g.Id == genre && f.Country == country && f.Price <= up
                        select f).Count();
                    textBoxCheaps.Text = Math.Round(cheaps * 100.0 / total, 2).ToString();
                }
            }
            catch { }
            try
            {
                int down = Convert.ToInt32(textBoxDown.Text);
                if (total != 0)
                {
                    var pricy = (
                        from f in db.Films
                        from g in f.Genres
                        where g.Id == genre && f.Country == country && f.Price >= down
                        select f).Count();
                    textBoxPricy.Text = Math.Round(pricy * 100.0 / total, 2).ToString();
                }
            }
            catch { }
        }
    }
}
