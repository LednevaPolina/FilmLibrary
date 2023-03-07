namespace FilmLibrary
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.listBoxActors = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxCountries = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxGenres = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDirectors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сщгтекн = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viewers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вспомогательныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguagesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CountriesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.актерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режисерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.меньшаяСтоимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоГодуСтранеИСтоимостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доляДешевыхИДорогихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сраныСНаибольшимПоказомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискАктеровУчаствовавшихВФильмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискФильмовПоАктеруИГодуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискАктеровПоГородуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиПрезидентовКоторыеАктерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listBoxActors);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listBoxCountries);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listBoxLanguages);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listBoxGenres);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listBoxDirectors);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridViewFilms);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1520, 706);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1520, 734);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // listBoxActors
            // 
            this.listBoxActors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxActors.FormattingEnabled = true;
            this.listBoxActors.ItemHeight = 16;
            this.listBoxActors.Location = new System.Drawing.Point(1225, 193);
            this.listBoxActors.Name = "listBoxActors";
            this.listBoxActors.Size = new System.Drawing.Size(283, 436);
            this.listBoxActors.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1240, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Актеры";
            // 
            // listBoxCountries
            // 
            this.listBoxCountries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCountries.FormattingEnabled = true;
            this.listBoxCountries.ItemHeight = 16;
            this.listBoxCountries.Location = new System.Drawing.Point(942, 403);
            this.listBoxCountries.Name = "listBoxCountries";
            this.listBoxCountries.Size = new System.Drawing.Size(277, 228);
            this.listBoxCountries.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(942, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Страны показа";
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.ItemHeight = 16;
            this.listBoxLanguages.Location = new System.Drawing.Point(942, 193);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.Size = new System.Drawing.Size(277, 180);
            this.listBoxLanguages.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(967, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Языки";
            // 
            // listBoxGenres
            // 
            this.listBoxGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGenres.FormattingEnabled = true;
            this.listBoxGenres.ItemHeight = 16;
            this.listBoxGenres.Location = new System.Drawing.Point(1225, 23);
            this.listBoxGenres.Name = "listBoxGenres";
            this.listBoxGenres.Size = new System.Drawing.Size(283, 148);
            this.listBoxGenres.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1240, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Жанры";
            // 
            // listBoxDirectors
            // 
            this.listBoxDirectors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDirectors.FormattingEnabled = true;
            this.listBoxDirectors.ItemHeight = 16;
            this.listBoxDirectors.Location = new System.Drawing.Point(942, 23);
            this.listBoxDirectors.Name = "listBoxDirectors";
            this.listBoxDirectors.Size = new System.Drawing.Size(277, 148);
            this.listBoxDirectors.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(967, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Режисеры";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(118, 677);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(224, 677);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewFilms
            // 
            this.dataGridViewFilms.AllowUserToAddRows = false;
            this.dataGridViewFilms.AllowUserToDeleteRows = false;
            this.dataGridViewFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FilmName,
            this.Сщгтекн,
            this.Year,
            this.Price,
            this.Viewers,
            this.Description});
            this.dataGridViewFilms.Location = new System.Drawing.Point(3, 29);
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.RowHeadersWidth = 51;
            this.dataGridViewFilms.RowTemplate.Height = 24;
            this.dataGridViewFilms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilms.Size = new System.Drawing.Size(933, 636);
            this.dataGridViewFilms.TabIndex = 0;
            this.dataGridViewFilms.SelectionChanged += new System.EventHandler(this.dataGridViewFilms_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // FilmName
            // 
            this.FilmName.HeaderText = "Название";
            this.FilmName.MinimumWidth = 6;
            this.FilmName.Name = "FilmName";
            this.FilmName.ReadOnly = true;
            this.FilmName.Width = 125;
            // 
            // Сщгтекн
            // 
            this.Сщгтекн.HeaderText = "Страна";
            this.Сщгтекн.MinimumWidth = 6;
            this.Сщгтекн.Name = "Сщгтекн";
            this.Сщгтекн.ReadOnly = true;
            this.Сщгтекн.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоимость";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Viewers
            // 
            this.Viewers.HeaderText = "Количество зрителей";
            this.Viewers.MinimumWidth = 6;
            this.Viewers.Name = "Viewers";
            this.Viewers.ReadOnly = true;
            this.Viewers.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вспомогательныеДанныеToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1520, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вспомогательныеДанныеToolStripMenuItem
            // 
            this.вспомогательныеДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenresToolStripMenuItem,
            this.LanguagesToolStripMenuItem1,
            this.CountriesToolStripMenuItem2,
            this.актерыToolStripMenuItem,
            this.режисерыToolStripMenuItem});
            this.вспомогательныеДанныеToolStripMenuItem.Name = "вспомогательныеДанныеToolStripMenuItem";
            this.вспомогательныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.вспомогательныеДанныеToolStripMenuItem.Text = "Вспомогательные данные";
            // 
            // GenresToolStripMenuItem
            // 
            this.GenresToolStripMenuItem.Name = "GenresToolStripMenuItem";
            this.GenresToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.GenresToolStripMenuItem.Text = "Жанры";
            this.GenresToolStripMenuItem.Click += new System.EventHandler(this.GenresToolStripMenuItem_Click);
            // 
            // LanguagesToolStripMenuItem1
            // 
            this.LanguagesToolStripMenuItem1.Name = "LanguagesToolStripMenuItem1";
            this.LanguagesToolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.LanguagesToolStripMenuItem1.Text = "Языки";
            this.LanguagesToolStripMenuItem1.Click += new System.EventHandler(this.LanguagesToolStripMenuItem1_Click);
            // 
            // CountriesToolStripMenuItem2
            // 
            this.CountriesToolStripMenuItem2.Name = "CountriesToolStripMenuItem2";
            this.CountriesToolStripMenuItem2.Size = new System.Drawing.Size(196, 26);
            this.CountriesToolStripMenuItem2.Text = "Страны показа";
            this.CountriesToolStripMenuItem2.Click += new System.EventHandler(this.CountriesToolStripMenuItem2_Click);
            // 
            // актерыToolStripMenuItem
            // 
            this.актерыToolStripMenuItem.Name = "актерыToolStripMenuItem";
            this.актерыToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.актерыToolStripMenuItem.Text = "Актеры ";
            this.актерыToolStripMenuItem.Click += new System.EventHandler(this.актерыToolStripMenuItem_Click);
            // 
            // режисерыToolStripMenuItem
            // 
            this.режисерыToolStripMenuItem.Name = "режисерыToolStripMenuItem";
            this.режисерыToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.режисерыToolStripMenuItem.Text = "Режисеры";
            this.режисерыToolStripMenuItem.Click += new System.EventHandler(this.режисерыToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.меньшаяСтоимостьToolStripMenuItem,
            this.поискПоГодуСтранеИСтоимостиToolStripMenuItem,
            this.доляДешевыхИДорогихToolStripMenuItem,
            this.сраныСНаибольшимПоказомToolStripMenuItem,
            this.поискАктеровУчаствовавшихВФильмеToolStripMenuItem,
            this.поискФильмовПоАктеруИГодуToolStripMenuItem,
            this.поискАктеровПоГородуToolStripMenuItem,
            this.поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.найтиПрезидентовКоторыеАктерыToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // меньшаяСтоимостьToolStripMenuItem
            // 
            this.меньшаяСтоимостьToolStripMenuItem.Name = "меньшаяСтоимостьToolStripMenuItem";
            this.меньшаяСтоимостьToolStripMenuItem.Size = new System.Drawing.Size(456, 26);
            this.меньшаяСтоимостьToolStripMenuItem.Text = "Меньшая стоимость";
            this.меньшаяСтоимостьToolStripMenuItem.ToolTipText = "Фильмы, чья стоимость меньше выделенного";
            this.меньшаяСтоимостьToolStripMenuItem.Click += new System.EventHandler(this.меньшаяСтоимостьToolStripMenuItem_Click);
            // 
            // поискПоГодуСтранеИСтоимостиToolStripMenuItem
            // 
            this.поискПоГодуСтранеИСтоимостиToolStripMenuItem.Name = "поискПоГодуСтранеИСтоимостиToolStripMenuItem";
            this.поискПоГодуСтранеИСтоимостиToolStripMenuItem.Size = new System.Drawing.Size(456, 26);
            this.поискПоГодуСтранеИСтоимостиToolStripMenuItem.Text = "Поиск по году, стране и стоимости";
            this.поискПоГодуСтранеИСтоимостиToolStripMenuItem.ToolTipText = "Поиск по году, стране и диапазону цен";
            this.поискПоГодуСтранеИСтоимостиToolStripMenuItem.Click += new System.EventHandler(this.поискПоГодуСтранеИСтоимостиToolStripMenuItem_Click);
            // 
            // доляДешевыхИДорогихToolStripMenuItem
            // 
            this.доляДешевыхИДорогихToolStripMenuItem.Name = "доляДешевыхИДорогихToolStripMenuItem";
            this.доляДешевыхИДорогихToolStripMenuItem.Size = new System.Drawing.Size(456, 26);
            this.доляДешевыхИДорогихToolStripMenuItem.Text = "Доля дешевых и дорогих";
            this.доляДешевыхИДорогихToolStripMenuItem.ToolTipText = "Вычислить долю дешевых и дорогих по стране и жанру";
            this.доляДешевыхИДорогихToolStripMenuItem.Click += new System.EventHandler(this.доляДешевыхИДорогихToolStripMenuItem_Click);
            // 
            // сраныСНаибольшимПоказомToolStripMenuItem
            // 
            this.сраныСНаибольшимПоказомToolStripMenuItem.Name = "сраныСНаибольшимПоказомToolStripMenuItem";
            this.сраныСНаибольшимПоказомToolStripMenuItem.Size = new System.Drawing.Size(456, 26);
            this.сраныСНаибольшимПоказомToolStripMenuItem.Text = "Сраны с наибольшим показом";
            this.сраныСНаибольшимПоказомToolStripMenuItem.ToolTipText = "Выводит страны с наибольшим показом по жанрам";
            this.сраныСНаибольшимПоказомToolStripMenuItem.Click += new System.EventHandler(this.сраныСНаибольшимПоказомToolStripMenuItem_Click);
            // 
            // поискАктеровУчаствовавшихВФильмеToolStripMenuItem
            // 
            this.поискАктеровУчаствовавшихВФильмеToolStripMenuItem.Name = "поискАктеровУчаствовавшихВФильмеToolStripMenuItem";
            this.поискАктеровУчаствовавшихВФильмеToolStripMenuItem.Size = new System.Drawing.Size(456, 26);
            this.поискАктеровУчаствовавшихВФильмеToolStripMenuItem.Text = "Поиск актеров, участвовавших в фильме";
            this.поискАктеровУчаствовавшихВФильмеToolStripMenuItem.Click += new System.EventHandler(this.поискАктеровУчаствовавшихВФильмеToolStripMenuItem_Click);
            // 
            // поискФильмовПоАктеруИГодуToolStripMenuItem
            // 
            this.поискФильмовПоАктеруИГодуToolStripMenuItem.Name = "поискФильмовПоАктеруИГодуToolStripMenuItem";
            this.поискФильмовПоАктеруИГодуToolStripMenuItem.Size = new System.Drawing.Size(456, 26);
            this.поискФильмовПоАктеруИГодуToolStripMenuItem.Text = "Поиск фильмов по актеру и году";
            this.поискФильмовПоАктеруИГодуToolStripMenuItem.Click += new System.EventHandler(this.поискФильмовПоАктеруИГодуToolStripMenuItem_Click);
            // 
            // поискАктеровПоГородуToolStripMenuItem
            // 
            this.поискАктеровПоГородуToolStripMenuItem.Name = "поискАктеровПоГородуToolStripMenuItem";
            this.поискАктеровПоГородуToolStripMenuItem.Size = new System.Drawing.Size(456, 26);
            this.поискАктеровПоГородуToolStripMenuItem.Text = "Поиск актеров по городу";
            this.поискАктеровПоГородуToolStripMenuItem.Click += new System.EventHandler(this.поискАктеровПоГородуToolStripMenuItem_Click);
            // 
            // поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem
            // 
            this.поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem.Name = "поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem";
            this.поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem.Size = new System.Drawing.Size(456, 26);
            this.поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem.Text = "Поиск актеров, которые одновременно продюсеры";
            this.поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem.Click += new System.EventHandler(this.поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(456, 26);
            this.найтиToolStripMenuItem.Text = "Найти руководителей с состоянием больше актера";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // найтиПрезидентовКоторыеАктерыToolStripMenuItem
            // 
            this.найтиПрезидентовКоторыеАктерыToolStripMenuItem.Name = "найтиПрезидентовКоторыеАктерыToolStripMenuItem";
            this.найтиПрезидентовКоторыеАктерыToolStripMenuItem.Size = new System.Drawing.Size(456, 26);
            this.найтиПрезидентовКоторыеАктерыToolStripMenuItem.Text = "Найти президентов, которые актеры";
            this.найтиПрезидентовКоторыеАктерыToolStripMenuItem.Click += new System.EventHandler(this.найтиПрезидентовКоторыеАктерыToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 734);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильмотека";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem вспомогательныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguagesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CountriesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem актерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режисерыToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxDirectors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxGenres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLanguages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxCountries;
        private System.Windows.Forms.ListBox listBoxActors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem меньшаяСтоимостьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сщгтекн;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viewers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.ToolStripMenuItem поискПоГодуСтранеИСтоимостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доляДешевыхИДорогихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сраныСНаибольшимПоказомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискАктеровУчаствовавшихВФильмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискФильмовПоАктеруИГодуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискАктеровПоГородуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискАктеровКоторыеОдновременноПродюсерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиПрезидентовКоторыеАктерыToolStripMenuItem;
    }
}

