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
    public partial class MainForm : Form
    {
        FilmContext db;
        public MainForm()
        {
            InitializeComponent();

            db = new FilmContext();
            db.Films.Load();
        }

        private void ShowFilms()
        {
            dataGridViewFilms.Rows.Clear();
            var films = db.Films;
            foreach (Film u in films)
                dataGridViewFilms.Rows.Add(new object[] { u.Id, u.Name, u.Country, u.Year, u.Price, u.Viewers, u.Description });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowFilms();
        }

        private void GenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenresForm plForm = new GenresForm();
            plForm.Text = "Жанры";
            plForm.TypeGenre = GenresType.Genre;
            DialogResult result = plForm.ShowDialog(this);
        }

        private void LanguagesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenresForm plForm = new GenresForm();
            plForm.Text = "Языки";
            plForm.TypeGenre = GenresType.Language;
            DialogResult result = plForm.ShowDialog(this);
        }

        private void CountriesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GenresForm plForm = new GenresForm();
            plForm.Text = "Страны показа";
            plForm.TypeGenre = GenresType.Country;
            DialogResult result = plForm.ShowDialog(this);
        }

        private void актерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenresForm plForm = new GenresForm();
            plForm.Text = "Актеры";
            plForm.TypeGenre = GenresType.Actor;
            DialogResult result = plForm.ShowDialog(this);
        }

        private void режисерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenresForm plForm = new GenresForm();
            plForm.Text = "Режисеры";
            plForm.TypeGenre = GenresType.Director;
            DialogResult result = plForm.ShowDialog(this);
        }

        private void dataGridViewFilms_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridViewFilms.SelectedRows.Count <= 0)
                return;
            var row = dataGridViewFilms.SelectedRows[0];
            if (row == null)
                return;
            var Id = Convert.ToInt32(row.Cells[0].Value);
            var x = db.Films.Find(Id);
            db.Entry(x).Collection(p => p.Director).Load();
            db.Entry(x).Collection(p => p.Genres).Load();
            db.Entry(x).Collection(p => p.Languages).Load();
            db.Entry(x).Collection(p => p.Countries).Load();
            db.Entry(x).Collection(p => p.Actors).Load();
            listBoxDirectors.DataSource = x.Director;
            listBoxDirectors.DisplayMember = "Name";
            listBoxGenres.DataSource = x.Genres;
            listBoxGenres.DisplayMember = "Name";
            listBoxLanguages.DataSource = x.Languages;
            listBoxLanguages.DisplayMember = "Name";
            listBoxCountries.DataSource = x.Countries;
            listBoxCountries.DisplayMember = "Name";
            listBoxActors.DataSource = x.Actors;
            listBoxActors.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmEditorForm dlg = new FilmEditorForm();

            List<Director> directors = db.Directors.ToList();
            dlg.checkedListBoxDirectors.DataSource = directors;
            dlg.checkedListBoxDirectors.ValueMember = "Id";
            dlg.checkedListBoxDirectors.DisplayMember = "Name";

            List<Genre> genres = db.Genres.ToList();
            dlg.checkedListBoxGenres.DataSource = genres;
            dlg.checkedListBoxGenres.ValueMember = "Id";
            dlg.checkedListBoxGenres.DisplayMember = "Name";

            List<Actor> actors = db.Actors.ToList();
            dlg.checkedListBoxActors.DataSource = actors;
            dlg.checkedListBoxActors.ValueMember = "Id";
            dlg.checkedListBoxActors.DisplayMember = "Name";

            List<Language> langs = db.Languages.ToList();
            dlg.checkedListBoxLanguages.DataSource = langs;
            dlg.checkedListBoxLanguages.ValueMember = "Id";
            dlg.checkedListBoxLanguages.DisplayMember = "Name";

            List<Country> countries = db.Countries.ToList();
            dlg.checkedListBoxCountries.DataSource = countries;
            dlg.checkedListBoxCountries.ValueMember = "Id";
            dlg.checkedListBoxCountries.DisplayMember = "Name";

            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            Film film = new Film();
            film.Name = dlg.textBoxName.Text;
            film.Description = dlg.textBoxDescription.Text;
            film.Country = dlg.textBoxCountry.Text;
            film.Year = Convert.ToInt32(dlg.textBoxYear.Text);
            film.Price = Convert.ToInt32(dlg.textBoxPrice.Text);
            film.Viewers = Convert.ToInt32(dlg.textBoxViewers.Text);

            directors.Clear();
            foreach (Director director in dlg.checkedListBoxDirectors.CheckedItems)
                directors.Add(director);
            film.Director = directors;

            genres.Clear();
            foreach (Genre genre in dlg.checkedListBoxGenres.CheckedItems)
                genres.Add(genre);
            film.Genres = genres;

            actors.Clear();
            foreach (Actor actor in dlg.checkedListBoxActors.CheckedItems)
                actors.Add(actor);
            film.Actors = actors;

            langs.Clear();
            foreach (Language lang in dlg.checkedListBoxLanguages.CheckedItems)
                langs.Add(lang);
            film.Languages = langs;

            countries.Clear();
            foreach (Country country in dlg.checkedListBoxCountries.CheckedItems)
                countries.Add(country);
            film.Countries = countries;

            db.Films.Add(film);
            db.SaveChanges();
            ShowFilms();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewFilms.SelectedRows.Count <= 0)
                return;
            var row = dataGridViewFilms.SelectedRows[0];
            if (row == null)
                return;
            FilmEditorForm dlg = new FilmEditorForm();
            var Id = Convert.ToInt32(row.Cells[0].Value);
            var film = db.Films.Find(Id);

            dlg.textBoxName.Text = film.Name;
            dlg.textBoxDescription.Text = film.Description;
            dlg.textBoxCountry.Text = film.Country;
            dlg.textBoxYear.Text = film.Year.ToString();
            dlg.textBoxPrice.Text = film.Price.ToString();
            dlg.textBoxViewers.Text = film.Viewers.ToString();

            List<Director> directors = db.Directors.ToList();
            dlg.checkedListBoxDirectors.DataSource = directors;
            dlg.checkedListBoxDirectors.ValueMember = "Id";
            dlg.checkedListBoxDirectors.DisplayMember = "Name";
            foreach (Director t in film.Director)
                dlg.checkedListBoxDirectors.SetItemChecked(dlg.checkedListBoxDirectors.Items.IndexOf(t), true);

            List<Genre> genres = db.Genres.ToList();
            dlg.checkedListBoxGenres.DataSource = genres;
            dlg.checkedListBoxGenres.ValueMember = "Id";
            dlg.checkedListBoxGenres.DisplayMember = "Name";
            foreach (Genre t in film.Genres)
                dlg.checkedListBoxGenres.SetItemChecked(dlg.checkedListBoxGenres.Items.IndexOf(t), true);

            List<Actor> actors = db.Actors.ToList();
            dlg.checkedListBoxActors.DataSource = actors;
            dlg.checkedListBoxActors.ValueMember = "Id";
            dlg.checkedListBoxActors.DisplayMember = "Name";
            foreach (Actor t in film.Actors)
                dlg.checkedListBoxActors.SetItemChecked(dlg.checkedListBoxActors.Items.IndexOf(t), true);

            List<Language> langs = db.Languages.ToList();
            dlg.checkedListBoxLanguages.DataSource = langs;
            dlg.checkedListBoxLanguages.ValueMember = "Id";
            dlg.checkedListBoxLanguages.DisplayMember = "Name";
            foreach (Language t in film.Languages)
                dlg.checkedListBoxLanguages.SetItemChecked(dlg.checkedListBoxLanguages.Items.IndexOf(t), true);

            List<Country> countries = db.Countries.ToList();
            dlg.checkedListBoxCountries.DataSource = countries;
            dlg.checkedListBoxCountries.ValueMember = "Id";
            dlg.checkedListBoxCountries.DisplayMember = "Name";
            foreach (Country t in film.Countries)
                dlg.checkedListBoxCountries.SetItemChecked(dlg.checkedListBoxCountries.Items.IndexOf(t), true);

            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            film.Name = dlg.textBoxName.Text;
            film.Description = dlg.textBoxDescription.Text;
            film.Country = dlg.textBoxCountry.Text;
            film.Year = Convert.ToInt32(dlg.textBoxYear.Text);
            film.Price = Convert.ToInt32(dlg.textBoxPrice.Text);
            film.Viewers = Convert.ToInt32(dlg.textBoxViewers.Text);

            directors.Clear();
            foreach (Director director in dlg.checkedListBoxDirectors.CheckedItems)
                directors.Add(director);
            film.Director = directors;

            genres.Clear();
            foreach (Genre genre in dlg.checkedListBoxGenres.CheckedItems)
                genres.Add(genre);
            film.Genres = genres;

            actors.Clear();
            foreach (Actor actor in dlg.checkedListBoxActors.CheckedItems)
                actors.Add(actor);
            film.Actors = actors;

            langs.Clear();
            foreach (Language lang in dlg.checkedListBoxLanguages.CheckedItems)
                langs.Add(lang);
            film.Languages = langs;

            countries.Clear();
            foreach (Country country in dlg.checkedListBoxCountries.CheckedItems)
                countries.Add(country);
            film.Countries = countries;

            db.SaveChanges();
            ShowFilms();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewFilms.SelectedRows.Count <= 0)
                return;
            var row = dataGridViewFilms.SelectedRows[0];
            if (row == null)
                return;
            FilmEditorForm dlg = new FilmEditorForm();
            var Id = Convert.ToInt32(row.Cells[0].Value);
            var film = db.Films.Find(Id);
            if (MessageBox.Show(this, "Точно хотите удалить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            db.Films.Remove(film);
            db.SaveChanges();
            ShowFilms();
        }

        private void меньшаяСтоимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new PriceLessForm();

            List<Genre> genres = db.Genres.ToList();
            dlg.listBoxGenre.DataSource = genres;
            dlg.listBoxGenre.ValueMember = "Id";
            dlg.listBoxGenre.DisplayMember = "Name";

            List<Film> films = db.Films.ToList();
            List<String> filmCountries = films.Select(x => x.Country).Distinct().ToList();
            dlg.listBoxCounties.DataSource = filmCountries;

            dlg.listBoxFilmsCompare.DataSource = films;
            dlg.listBoxFilmsCompare.ValueMember = "Id";
            dlg.listBoxFilmsCompare.DisplayMember = "Name";

            var result = dlg.ShowDialog();
        }

        private void поискПоГодуСтранеИСтоимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new PriceIntoForm();

            List<Film> films = db.Films.ToList();
            List<String> filmCountries = films.Select(x => x.Country).Distinct().ToList();
            dlg.listBoxCountries.DataSource = filmCountries;
            List<int> filmYears = films.Select(x => x.Year).Distinct().ToList();
            filmYears.Sort();
            dlg.listBoxYears.DataSource = filmYears;
            var result = dlg.ShowDialog();
        }

        private void доляДешевыхИДорогихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new PortionsForm();
            List<Film> films = db.Films.ToList();

            List<Genre> genres = db.Genres.ToList();
            dlg.listBoxGenres.DataSource = genres;
            dlg.listBoxGenres.ValueMember = "Id";
            dlg.listBoxGenres.DisplayMember = "Name";

            List<String> filmCountries = films.Select(x => x.Country).Distinct().ToList();
            dlg.listBoxCountries.DataSource = filmCountries;

            var result = dlg.ShowDialog();
        }

        private void сраныСНаибольшимПоказомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new MostViewersForm();
            var result = dlg.ShowDialog();
        }

        private void поискАктеровУчаствовавшихВФильмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new FindActorsForm();
            var result = dlg.ShowDialog();
        }

        private void поискФильмовПоАктеруИГодуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new FindFilmsByYearForm();
            var result = dlg.ShowDialog();
        }

        private void поискАктеровПоГородуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new ActorsCityForm();
            var result = dlg.ShowDialog();
        }

        private void поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new ActorsProducersForm();
            var result = dlg.ShowDialog();
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new DirectorMostActorForm();
            var result = dlg.ShowDialog();
        }

        private void найтиПрезидентовКоторыеАктерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new DirectorActorForm();
            var result = dlg.ShowDialog();
        }
    }
}
