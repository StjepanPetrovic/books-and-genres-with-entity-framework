using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace books_and_genres_with_entity_framework
{
    public partial class BooksAndGenresForm : Form
    {
        public BooksAndGenresForm()
        {
            InitializeComponent();

            dgvBooks.DataSource = getBooks();
            dgvBooks.Columns[5].Visible = false;

            dgvGenres.DataSource = getGenres();
            dgvGenres.Columns[2].Visible = false;
        }

        }

        private List<Books> getBooks()
        {
            List<Books> books = null;

            using (var db = new EF_DBEntities())
            {
                books = db.Books.ToList();
            }

            return books;
        }

        private List<Genres> getGenres()
        {
            List<Genres> genres = null;

            using (var db = new EF_DBEntities())
            {
                genres = db.Genres.ToList();
            }

            return genres;
        }
    }
}
