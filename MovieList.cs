using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApplication
{
    public partial class MovieList : Form
    {
        public MovieList()
        {
            InitializeComponent();
        }
        public static string movieName;
        private void book_b1_Click(object sender, EventArgs e)
        {
            movieName = "Deadpool";
            MovieTiming m = new MovieTiming();
            m.Show();
        }

        private void book_b2_Click(object sender, EventArgs e)
        {
            movieName = "X-MEN Apocalypse";
            MovieTiming m = new MovieTiming();
            m.Show();
        }

        private void book_b3_Click(object sender, EventArgs e)
        {
            movieName = "I Can only Imagine";
            MovieTiming m = new MovieTiming();
            m.Show();
        }

        private void book_b4_Click(object sender, EventArgs e)
        {
            movieName = "Raazi";
            MovieTiming m = new MovieTiming();
            m.Show();
        }
    }
}
