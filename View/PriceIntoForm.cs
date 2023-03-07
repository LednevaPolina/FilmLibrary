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
    public partial class PriceIntoForm : Form
    {
        FilmContext db;
        public PriceIntoForm()
        {
            InitializeComponent();
            db = new FilmContext();
            db.Films.Load();
        }

        private void textBoxPriceFrom_TextChanged(object sender, EventArgs e)
        {
            listBoxFilms.Items.Clear();
            try
            {
                int fr = Convert.ToInt32(textBoxPriceFrom.Text);
                int to = Convert.ToInt32(textBoxPriceTo.Text);
                int year = Convert.ToInt32(listBoxYears.SelectedItems[0]);
                string countries = listBoxCountries.SelectedItems[0].ToString();

                var result =
                    from f in db.Films
                    where f.Price >= fr && f.Price <= to && f.Year == year && f.Country == countries
                    select new
                    {
                        Name = f.Name,
                    };
                foreach (var c in result)
                    listBoxFilms.Items.Add(c.Name);
            }
            catch { }
        }
    }
}
