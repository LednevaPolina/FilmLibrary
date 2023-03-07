using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
    public partial class ActorsProducersForm : Form
    {
        FilmContext db;
        public ActorsProducersForm()
        {
            InitializeComponent();
            db = new FilmContext();
            db.Films.Load();
            comboBoxGender.SelectedIndex = 1;
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            dataGridViewActor.Rows.Clear();
            int sum;
            try
            {
                sum = Convert.ToInt32(textBoxSum.Text);
            }
            catch { return; }
            bool gender = comboBoxGender.SelectedIndex == 0;
            var result =
                from d in db.Directors
                from f in db.Films
                where d.Gender == gender
                group new { Name = d.Name, Price = f.Price } by d.Name into gr
                select new
                {
                    Name = gr.Key,
                    Sum = gr.Sum(p => p.Price)
                };
            foreach (var u in result.Where(x => x.Sum >= sum))
                dataGridViewActor.Rows.Add(new object[] { u.Name, u.Sum });
        }
    }
}
