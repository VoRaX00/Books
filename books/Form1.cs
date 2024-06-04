using MySql.Data.MySqlClient;
using System.Data;

namespace books
{
    public partial class Form1 : Form
    {
        List<string> genres = new List<string>();
        List<string> sites = new List<string>();
        List<string> authors = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetAuthorBox();
            SetGenresBox();
            SetSiteBox();
            LoadRecord("");
        }

        private string lineCommand(bool textIsNull)
        {
            List<string> conditions = new List<string>();

            if (genres.Count != 0)
            {
                conditions.Add($"genre IN ({string.Join(",", genres.Select((_, i) => "?genre" + i))})");
            }
            if (sites.Count != 0)
            {
                conditions.Add($"site_name IN ({string.Join(",", sites.Select((_, i) => "?site" + i))})");
            }
            if (authors.Count != 0)
            {
                conditions.Add($"author IN ({string.Join(",", authors.Select((_, i) => "?author" + i))})");
            }

            if (!string.IsNullOrEmpty(from.Text))
            {
                conditions.Add("price >= ?priceFrom");
            }
            if (!string.IsNullOrEmpty(before.Text))
            {
                conditions.Add("price <= ?priceTo");
            }

            string firstWord = textIsNull ? "WHERE" : "AND";

            if (conditions.Count > 0)
            {
                return $"{firstWord} {string.Join(" AND ", conditions)}";
            }

            return "";
        }

        public void LoadRecord(string text)
        {
            DBConnection.ConnectionDB();
            dataGridView1.Rows.Clear();
            var conn = DBConnection.GetConnection();
            MySqlCommand cmd;

            var listsCmd = lineCommand(string.IsNullOrEmpty(text));
            if (string.IsNullOrEmpty(text))
            {
                string query = "SELECT * FROM info " + listsCmd;
                cmd = new MySqlCommand(query, conn);

                for (int i = 0; i < genres.Count; i++)
                {
                    cmd.Parameters.AddWithValue("?genre" + i, genres[i]);
                }
                for (int i = 0; i < sites.Count; i++)
                {
                    cmd.Parameters.AddWithValue("?site" + i, sites[i]);
                }
                for (int i = 0; i < authors.Count; i++)
                {
                    cmd.Parameters.AddWithValue("?author" + i, authors[i]);
                }

                if (!string.IsNullOrEmpty(from.Text) && decimal.TryParse(from.Text, out decimal priceFrom))
                {
                    cmd.Parameters.AddWithValue("?priceFrom", priceFrom);
                }
                if (!string.IsNullOrEmpty(before.Text) && decimal.TryParse(before.Text, out decimal priceTo))
                {
                    cmd.Parameters.AddWithValue("?priceTo", priceTo);
                }
            }
            else
            {
                string query = "SELECT * FROM info WHERE name=@text " + listsCmd;
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@text", text);
                for (int i = 0; i < genres.Count; i++)
                {
                    cmd.Parameters.AddWithValue("?genre" + i, genres[i]);
                }
                for (int i = 0; i < sites.Count; i++)
                {
                    cmd.Parameters.AddWithValue("?site" + i, sites[i]);
                }
                for (int i = 0; i < authors.Count; i++)
                {
                    cmd.Parameters.AddWithValue("?author" + i, authors[i]);
                }

                if (!string.IsNullOrEmpty(from.Text) && decimal.TryParse(from.Text, out decimal priceFrom))
                {
                    cmd.Parameters.AddWithValue("?priceFrom", priceFrom);
                }
                if (!string.IsNullOrEmpty(before.Text) && decimal.TryParse(before.Text, out decimal priceTo))
                {
                    cmd.Parameters.AddWithValue("?priceTo", priceTo);
                }
            }

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var name = reader.GetString("name");
                var author = reader.GetString("author");
                var price = reader["price"].ToString();
                var link = reader.GetString("link");
                var genre = reader["genre"].ToString();
                var description = reader["description"].ToString();
                Image img = null;
                byte[] imageData = reader["preview"] == DBNull.Value ? null : (byte[])reader["preview"];
                if (imageData != null && imageData.Length > 0)
                {
                    using (var memoryStream = new MemoryStream(imageData))
                    {
                        try
                        {
                            img = Image.FromStream(memoryStream);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Error creating image: " + ex.Message);
                        }
                    }
                }
                var site_name = reader["site_name"].ToString();
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, name, author, price, link, genre, description, img, site_name);
            }

            DBConnection.CloseDB();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            LoadRecord(text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetGenresBox()
        {
            DBConnection.ConnectionDB();
            dataGridView1.Rows.Clear();
            var conn = DBConnection.GetConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT genre FROM info", conn);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var genre = reader["genre"].ToString();
                if (!string.IsNullOrEmpty(genre))
                {
                    genresBox.Items.Add(genre);
                }
            }
        }

        private void SetSiteBox()
        {
            DBConnection.ConnectionDB();
            dataGridView1.Rows.Clear();
            var conn = DBConnection.GetConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT site_name FROM info", conn);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var site_name = reader["site_name"].ToString();
                if (!string.IsNullOrEmpty(site_name))
                {
                    siteBox.Items.Add(site_name);
                }
            }
        }

        private void SetAuthorBox()
        {
            DBConnection.ConnectionDB();
            dataGridView1.Rows.Clear();
            var conn = DBConnection.GetConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT author FROM info", conn);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var author = reader["author"].ToString();
                if (!string.IsNullOrEmpty(author))
                {
                    authorBox.Items.Add(author);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genres.Clear();
            foreach (var i in genresBox.CheckedItems)
            {
                genres.Add(i.ToString());
            }
            LoadRecord(textBox1.Text);
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void authorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            authors.Clear();
            foreach (var i in authorBox.CheckedItems)
            {
                authors.Add(i.ToString());
            }
            LoadRecord(textBox1.Text);
        }

        private void siteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sites.Clear();
            foreach (var i in siteBox.CheckedItems)
            {
                sites.Add(i.ToString());
            }
            LoadRecord(textBox1.Text);
        }

        private void from_TextChanged(object sender, EventArgs e)
        {
            LoadRecord(textBox1.Text);
        }

        private void before_TextChanged(object sender, EventArgs e)
        {
            LoadRecord(textBox1.Text);
        }
    }
}
