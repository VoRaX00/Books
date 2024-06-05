namespace books
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            link = new DataGridViewLinkColumn();
            genre = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            preview = new DataGridViewImageColumn();
            site_name = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button_search = new Button();
            from = new TextBox();
            before = new TextBox();
            label1 = new Label();
            genresBox = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            siteBox = new CheckedListBox();
            label4 = new Label();
            authorBox = new CheckedListBox();
            buttonPrevious = new Button();
            buttonNext = new Button();
            labelPageNumber = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, author, price, link, genre, description, preview, site_name });
            dataGridView1.Location = new Point(0, 229);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1476, 329);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.DataPropertyName = "name";
            name.HeaderText = "Название";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // author
            // 
            author.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            author.DataPropertyName = "author";
            author.HeaderText = "Автор";
            author.Name = "author";
            author.ReadOnly = true;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price.DataPropertyName = "price";
            price.HeaderText = "Цена";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // link
            // 
            link.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            link.DataPropertyName = "link";
            link.HeaderText = "Ссылка";
            link.Name = "link";
            link.ReadOnly = true;
            link.Resizable = DataGridViewTriState.True;
            link.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // genre
            // 
            genre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            genre.DataPropertyName = "genre";
            genre.HeaderText = "Жанр";
            genre.Name = "genre";
            genre.ReadOnly = true;
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            description.DataPropertyName = "description";
            description.HeaderText = "Описание";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // preview
            // 
            preview.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            preview.DataPropertyName = "preview";
            preview.HeaderText = "Обложка";
            preview.ImageLayout = DataGridViewImageCellLayout.Zoom;
            preview.Name = "preview";
            preview.ReadOnly = true;
            preview.Resizable = DataGridViewTriState.True;
            preview.SortMode = DataGridViewColumnSortMode.Automatic;
            preview.Width = 116;
            // 
            // site_name
            // 
            site_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            site_name.DataPropertyName = "site_name";
            site_name.HeaderText = "Название сайта";
            site_name.Name = "site_name";
            site_name.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(1143, 42);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Найти";
            textBox1.Size = new Size(320, 33);
            textBox1.TabIndex = 1;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.Location = new Point(1143, 85);
            button_search.Margin = new Padding(5);
            button_search.Name = "button_search";
            button_search.Size = new Size(320, 38);
            button_search.TabIndex = 2;
            button_search.Text = "Поиск";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // from
            // 
            from.Location = new Point(19, 42);
            from.Margin = new Padding(5);
            from.Name = "from";
            from.PlaceholderText = "от";
            from.Size = new Size(155, 33);
            from.TabIndex = 3;
            from.TextChanged += from_TextChanged;
            from.KeyPress += from_KeyPress;
            // 
            // before
            // 
            before.Location = new Point(184, 42);
            before.Margin = new Padding(5);
            before.Name = "before";
            before.PlaceholderText = "до";
            before.Size = new Size(155, 33);
            before.TabIndex = 4;
            before.TextChanged += before_TextChanged;
            before.KeyPress += before_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(19, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 5;
            label1.Text = "Цена";
            label1.Click += label1_Click;
            // 
            // genresBox
            // 
            genresBox.CheckOnClick = true;
            genresBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            genresBox.FormattingEnabled = true;
            genresBox.HorizontalScrollbar = true;
            genresBox.Location = new Point(589, 42);
            genresBox.Margin = new Padding(5);
            genresBox.Name = "genresBox";
            genresBox.Size = new Size(230, 144);
            genresBox.TabIndex = 6;
            genresBox.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(589, 12);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 7;
            label2.Text = "Жанры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(829, 12);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 9;
            label3.Text = "Сайты";
            // 
            // siteBox
            // 
            siteBox.CheckOnClick = true;
            siteBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            siteBox.FormattingEnabled = true;
            siteBox.HorizontalScrollbar = true;
            siteBox.Location = new Point(829, 42);
            siteBox.Margin = new Padding(5);
            siteBox.Name = "siteBox";
            siteBox.Size = new Size(230, 144);
            siteBox.TabIndex = 8;
            siteBox.SelectedIndexChanged += siteBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(349, 12);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 11;
            label4.Text = "Авторы";
            label4.Click += label4_Click;
            // 
            // authorBox
            // 
            authorBox.CheckOnClick = true;
            authorBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            authorBox.FormattingEnabled = true;
            authorBox.HorizontalScrollbar = true;
            authorBox.Location = new Point(349, 42);
            authorBox.Margin = new Padding(5);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(230, 144);
            authorBox.TabIndex = 10;
            authorBox.SelectedIndexChanged += authorBox_SelectedIndexChanged;
            // 
            // buttonPrevious
            // 
            buttonPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPrevious.Location = new Point(3, 3);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(289, 41);
            buttonPrevious.TabIndex = 12;
            buttonPrevious.Text = "<<";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNext.Location = new Point(1184, 3);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(290, 41);
            buttonNext.TabIndex = 13;
            buttonNext.Text = ">>";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // labelPageNumber
            // 
            labelPageNumber.Anchor = AnchorStyles.Bottom;
            labelPageNumber.AutoSize = true;
            labelPageNumber.Location = new Point(680, 22);
            labelPageNumber.Name = "labelPageNumber";
            labelPageNumber.Size = new Size(115, 25);
            labelPageNumber.TabIndex = 14;
            labelPageNumber.Text = "Страница: 1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9984016F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.0012F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0004F));
            tableLayoutPanel1.Controls.Add(buttonPrevious, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonNext, 2, 0);
            tableLayoutPanel1.Controls.Add(labelPageNumber, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 604);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1477, 47);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 651);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(authorBox);
            Controls.Add(label3);
            Controls.Add(siteBox);
            Controls.Add(label2);
            Controls.Add(genresBox);
            Controls.Add(label1);
            Controls.Add(before);
            Controls.Add(from);
            Controls.Add(button_search);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MinimumSize = new Size(1493, 690);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button_search;
        private TextBox from;
        private TextBox before;
        private Label label1;
        private CheckedListBox genresBox;
        private Label label2;
        private Label label3;
        private CheckedListBox siteBox;
        private Label label4;
        private CheckedListBox authorBox;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn price;
        private DataGridViewLinkColumn link;
        private DataGridViewTextBoxColumn genre;
        private DataGridViewTextBoxColumn description;
        private DataGridViewImageColumn preview;
        private DataGridViewTextBoxColumn site_name;
        private Button buttonPrevious;
        private Button buttonNext;
        private Label labelPageNumber;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
