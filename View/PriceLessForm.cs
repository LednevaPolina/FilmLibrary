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
    public partial class PriceLessForm : Form
    {
        FilmContext db;
        public PriceLessForm()
        {
            InitializeComponent();
            db = new FilmContext();
            db.Films.Load();
        }

        private void listBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            if (listBoxGenre.SelectedItems.Count < 1 || listBoxCounties.SelectedItems.Count < 1 || listBoxFilmsCompare.SelectedItems.Count < 1)
                return;
            var genre = (listBoxGenre.SelectedItems[0] as Genre).Id;
            var country = listBoxCounties.SelectedItems[0].ToString();
            var film = (listBoxFilmsCompare.SelectedItems[0] as Film).Id;
            var cost = (listBoxFilmsCompare.SelectedItems[0] as Film).Price;
            // Собственно запрос
            var result =
                from f in db.Films
                from g in f.Genres
                where g.Id == genre && f.Country == country && f.Price < cost
                select new
                {
                    Name = f.Name,
                };
            foreach (var c in result)
                listBoxResult.Items.Add(c.Name);
        }
    }
}
