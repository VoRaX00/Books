using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books
{
    internal class Record
    {
        public Record(string name, string author, string price, string link, string genre, string description, Image image, string site_name)
        {
            m_name = name;
            m_author = author;
            m_price = price;
            m_link = link;
            m_genre = genre;
            m_description = description;
            m_image = image;
            m_site_name = site_name;
        }

        public string Name
        {
            get {  return m_name; }
            set { m_name = value; }
        }

        public string Author
        {
            get { return m_author; }
            set { m_author = value; }
        }

        public string Price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        public string Link
        {
            get { return m_link; }
            set { m_link = value; }
        }

        public string Genre
        {
            get { return m_genre; }
            set { m_genre = value; }
        }

        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        public Image Image
        {
            get { return m_image; }
            set { m_image = value; }
        }

        public string SiteName
        {
            get { return m_site_name; }
            set { m_site_name = value; }
        }

        private string m_name;
        private string m_author;
        private string m_price;
        private string m_link;
        private string m_genre;
        private string m_description;
        private Image m_image;
        private string m_site_name;
    }
}
