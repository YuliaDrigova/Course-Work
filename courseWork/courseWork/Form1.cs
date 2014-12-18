using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace courseWork
{
    public partial class Form1 : Form
    {
        public List_of_films Collection = new List_of_films();

        public Form1()
        {
            InitializeComponent();
            Collection.Read_from_XML();
            dgv_films.DataSource = Collection.Movies;
        }


        private void bn_add_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.bn_save.Enabled = false;
            f.ShowDialog();

        }

        private void bn_Edit_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.bn_Add.Enabled = false;
            int indexRow = dgv_films.CurrentRow.Index;


            f.tb_Name.Text = dgv_films[0, indexRow].Value.ToString();
            f.cb_Company.Text = dgv_films[1, indexRow].Value.ToString();
            f.tb_Year.Text = dgv_films[2, indexRow].Value.ToString();
            f.cb_Genre.Text = dgv_films[3, indexRow].Value.ToString();
            f.tb_Duration.Text = dgv_films[4, indexRow].Value.ToString();
            f.cb_Format.Text = dgv_films[5, indexRow].Value.ToString();
            f.cb_Quality.Text = dgv_films[6, indexRow].Value.ToString();
            f.tb_Director.Text = dgv_films[7, indexRow].Value.ToString();

            f.ShowDialog();
        }

        private void bn_Search_Click(object sender, EventArgs e)
        {
            Collection.Search(tb_search.Text);
            dgv_films.DataSource = null;
            dgv_films.DataSource = Collection.searched;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to exit?", "WARNING!!!", MessageBoxButtons.YesNo) != DialogResult.Yes)
            { e.Cancel = true; }
            else
            {
                if (MessageBox.Show("Do you want to save changes?", "WARNING!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Collection.Save_to_XML();
                }
            }
        }

        private void bn_Delete_Click(object sender, EventArgs e)
        {
            Collection.Movies.RemoveAt(dgv_films.CurrentRow.Index);
            dgv_films.DataSource = null;
            dgv_films.DataSource = Collection.Movies;
        }

        private void bn_Show_Click(object sender, EventArgs e)
        {
            dgv_films.DataSource = null;
            dgv_films.DataSource = Collection.Movies;
        }


        private void bn_save_Click(object sender, EventArgs e)
        {
            Collection.Save_to_XML();
            MessageBox.Show("Saving done successefully!");
        }

        private void dgv_films_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0: { Collection.Sort(0); break; }
                case 1: { Collection.Sort(1); break; }
                case 2: { Collection.Sort(2); break; }
                case 3: { Collection.Sort(3); break; }
                case 4: { Collection.Sort(4); break; }
                case 5: { Collection.Sort(5); break; }
                case 6: { Collection.Sort(6); break; }
                case 7: { Collection.Sort(7); break; }
            }
            dgv_films.DataSource = null;
            dgv_films.DataSource = Collection.Movies;
        }

    }
}
