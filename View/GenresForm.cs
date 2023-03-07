using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
    public enum GenresType
    {
        Genre,
        Language,
        Country,
        Actor,
        Director,
    }
    public partial class GenresForm : Form
    {
        FilmContext db;

        public GenresType TypeGenre = GenresType.Genre;
        public GenresForm()
        {
            InitializeComponent();
            db = new FilmContext();
        }

        void ShowGenres()
        {
            listBoxGenres.Items.Clear();
            switch (TypeGenre)
            {
                case GenresType.Genre:
                    var gen = db.Genres;
                    foreach (var g in gen)
                        listBoxGenres.Items.Add(g.Name);
                    break;
                case GenresType.Language:
                    var lang = db.Languages;
                    foreach (var g in lang)
                        listBoxGenres.Items.Add(g.Name);
                    break;
                case GenresType.Country:
                    var count = db.Countries;
                    foreach (var g in count)
                        listBoxGenres.Items.Add(g.Name);
                    break;
                case GenresType.Actor:
                    var act = db.Actors;
                    foreach (var g in act)
                        listBoxGenres.Items.Add(g.Name);
                    break;
                case GenresType.Director:
                    var dir = db.Directors;
                    foreach (var g in dir)
                        listBoxGenres.Items.Add(g.Name);
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterTextForm plForm = new EnterTextForm();
            if (TypeGenre == GenresType.Genre || TypeGenre == GenresType.Language || TypeGenre == GenresType.Country)
                RunTextDialog(false);
            else
                RunPersonDialog(false);
            ShowGenres();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxGenres.SelectedItems.Count == 0)
                return;
            if (TypeGenre == GenresType.Genre || TypeGenre == GenresType.Language || TypeGenre == GenresType.Country)
                RunTextDialog(true);
            else
                RunPersonDialog(true);
            ShowGenres();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxGenres.SelectedItems.Count == 0)
                return;
            if (MessageBox.Show(this, "Точно хотите удалить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            switch (TypeGenre)
            {
                case GenresType.Genre:
                    var x = db.Genres.FirstOrDefault(g => g.Name == listBoxGenres.Text);
                    if (x != null)
                    {
                        db.Genres.Remove(x);
                        db.SaveChanges();
                    }
                    break;
                case GenresType.Language:
                    var y = db.Languages.FirstOrDefault(g => g.Name == listBoxGenres.Text);
                    if (y != null)
                    {
                        db.Languages.Remove(y);
                        db.SaveChanges();
                    }
                    break;
                case GenresType.Country:
                    var z = db.Countries.FirstOrDefault(g => g.Name == listBoxGenres.Text);
                    if (z != null)
                    {
                        db.Countries.Remove(z);
                        db.SaveChanges();
                    }
                    break;
                case GenresType.Actor:
                    var a = db.Actors.FirstOrDefault(g => g.Name == listBoxGenres.Text);
                    if (a != null)
                    {
                        db.Actors.Remove(a);
                        db.SaveChanges();
                    }
                    break;
                case GenresType.Director:
                    var b = db.Directors.FirstOrDefault(g => g.Name == listBoxGenres.Text);
                    if (b != null)
                    {
                        db.Directors.Remove(b);
                        db.SaveChanges();
                    }
                    break;
            }
            ShowGenres();
        }

        private void Genres_Load(object sender, EventArgs e)
        {
            ShowGenres();
        }

        // Функции для ввода текста или человека. Разница в том, что человек имеет пол.
        private void RunTextDialog(bool edit)
        {
            var plForm = new EnterTextForm();
            if (TypeGenre == GenresType.Genre)
                plForm.Text = "Жанр";
            else if (TypeGenre == GenresType.Language)
                plForm.Text = "Язык";
            else if (TypeGenre == GenresType.Country)
                plForm.Text = "Страна";
            else
                return;
            var oldName = edit ? listBoxGenres.Text : "";
            plForm.textBoxName.Text = oldName;
            DialogResult result = plForm.ShowDialog(this);
            if (result != DialogResult.OK || oldName == plForm.textBoxName.Text)
                return;
            switch (TypeGenre)
            {
                case GenresType.Genre:
                    var x = db.Genres.FirstOrDefault(g => g.Name == plForm.textBoxName.Text);
                    if (x != null)
                    {
                        MessageBox.Show(this, "Такой жанр уже существует", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (edit)
                    {
                        Genre gen = db.Genres.FirstOrDefault(g => g.Name == oldName);
                        if (gen != null)
                        {
                            gen.Name = plForm.textBoxName.Text;
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        db.Genres.Add(new Genre { Name = plForm.textBoxName.Text });
                        db.SaveChanges();
                    }
                    break;
                case GenresType.Language:
                    var y = db.Languages.FirstOrDefault(g => g.Name == plForm.textBoxName.Text);
                    if (y != null)
                    {
                        MessageBox.Show(this, "Такой язык уже существует", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (edit)
                    {
                        Language lan = db.Languages.FirstOrDefault(g => g.Name == oldName);
                        if (lan != null)
                        {
                            lan.Name = plForm.textBoxName.Text;
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        db.Languages.Add(new Language { Name = plForm.textBoxName.Text });
                        db.SaveChanges();
                    }
                    break;
                case GenresType.Country:
                    var z = db.Countries.FirstOrDefault(g => g.Name == plForm.textBoxName.Text);
                    if (z != null)
                    {
                        MessageBox.Show(this, "Такая страна уже существует", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (edit)
                    {
                        Country con = db.Countries.FirstOrDefault(g => g.Name == oldName);
                        if (con != null)
                        {
                            con.Name = plForm.textBoxName.Text;
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        db.Countries.Add(new Country { Name = plForm.textBoxName.Text });
                        db.SaveChanges();
                    }
                    break;
            }
        }

        private void RunPersonDialog(bool edit)
        {
            var plForm = new PersonForm();
            if (TypeGenre == GenresType.Actor)
                plForm.Text = "Актер";
            else if (TypeGenre == GenresType.Director)
                plForm.Text = "Режисер";
            else
                return;
            var oldName = edit ? listBoxGenres.Text : "";
            string oldCity = "";
            int oldWealth = 0;
            bool? oldGender = null;
            if (edit)
                switch (TypeGenre)
                {
                    case GenresType.Actor:
                        var x = db.Actors.FirstOrDefault(g => g.Name == oldName);
                        if (x == null)
                            return;
                        oldGender = x.Gender;
                        oldCity = x.City;
                        oldWealth = x.Wealth;
                        break;
                    case GenresType.Director:
                        var y = db.Directors.FirstOrDefault(g => g.Name == oldName);
                        if (y == null)
                            return;
                        oldGender = y.Gender;
                        oldCity = y.City;
                        oldWealth = y.Wealth;
                        break;
                }
            plForm.textBoxName.Text = oldName;
            plForm.textBoxCity.Text = oldCity;
            plForm.Gender = oldGender;
            plForm.textBoxWealth.Text = oldWealth.ToString();
            DialogResult result = plForm.ShowDialog(this);
            if (result != DialogResult.OK ||
                (oldCity == plForm.textBoxCity.Text &&
                oldWealth.ToString() == plForm.textBoxWealth.Text &&
                oldName == plForm.textBoxName.Text &&
                (oldGender == null || oldGender == plForm.Gender)))
                return;
            switch (TypeGenre)
            {
                case GenresType.Actor:
                    if (oldName != plForm.textBoxName.Text)
                    {
                        var x = db.Actors.FirstOrDefault(g => g.Name == plForm.textBoxName.Text);
                        if (x != null)
                        {
                            MessageBox.Show(this, "Такой актер уже существует", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (edit)
                    {
                        Actor act = db.Actors.FirstOrDefault(g => g.Name == oldName);
                        if (act != null)
                        {
                            act.Name = plForm.textBoxName.Text;
                            act.Gender = plForm.Gender == true;
                            act.City = plForm.textBoxCity.Text;
                            act.Wealth = Convert.ToInt32(plForm.textBoxWealth.Text);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        db.Actors.Add(new Actor { Name = plForm.textBoxName.Text, City = plForm.textBoxCity.Text, Wealth = Convert.ToInt32(plForm.textBoxWealth.Text), Gender = plForm.Gender == true });
                        db.SaveChanges();
                    }
                    break;
                case GenresType.Director:
                    if (oldName != plForm.textBoxName.Text)
                    {
                        var y = db.Directors.FirstOrDefault(g => g.Name == plForm.textBoxName.Text);
                        if (y != null)
                        {
                            MessageBox.Show(this, "Такой режисер уже существует", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (edit)
                    {
                        Director lan = db.Directors.FirstOrDefault(g => g.Name == oldName);
                        if (lan != null)
                        {
                            lan.Name = plForm.textBoxName.Text;
                            lan.Gender = plForm.Gender == true;
                            lan.City = plForm.textBoxCity.Text;
                            lan.Wealth = Convert.ToInt32(plForm.textBoxWealth.Text);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        db.Directors.Add(new Director { Name = plForm.textBoxName.Text, City = plForm.textBoxCity.Text, Wealth = Convert.ToInt32(plForm.textBoxWealth.Text), Gender = plForm.Gender == true });
                        db.SaveChanges();
                    }
                    break;
            }
        }
    }
}

