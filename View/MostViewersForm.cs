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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FilmLibrary
{
    public partial class MostViewersForm : Form
    {
        FilmContext db;
        public MostViewersForm()
        {
            InitializeComponent();
            db = new FilmContext();
            db.Films.Load();
        }

        private void MostViewers_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var sql =
                from f in db.Films
                from g in f.Genres
                from c in f.Countries
                group g by new { genre = g.Name, country = c.Name } into gr
                select new
                {
                    Genre = gr.Key.genre,
                    Country = gr.Key.country,
                    Count = gr.Count()
                };
            var result = sql.ToList();
            var x = result
                .GroupBy(p => p.Genre)
                .ToDictionary(p => p.Key, p => p.Select(o => new { Cntry = o.Country, Cnt = o.Count }).ToList().OrderBy(o => o.Cnt).First())
                .ToList();
            foreach (var u in x)
                dataGridView1.Rows.Add(new object[] { u.Key, u.Value.Cntry, u.Value.Cnt });
        }

        
    }
}
