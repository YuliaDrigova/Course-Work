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
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form3)
        {
            form1 = form3;
            InitializeComponent();
            Form1 form = new Form1();
        }

        

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ' ' && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text.Length == 0) { MessageBox.Show("You hasn't written title of film!"); }
            else if (cb_Company.Text.Length == 0) { MessageBox.Show("You haven't chosen company of productation!"); }
            else if (tb_Year.Text.Length == 0 || tb_Year.Text.Length != 4) { MessageBox.Show("Wrong year!"); }
            else if (cb_Genre.Text.Length == 0) { MessageBox.Show("You haven't chosen genre of film!"); }
            else if (tb_Duration.Text.Length == 0) { MessageBox.Show("You haven't written duration of film!"); }
            else if (cb_Format.Text.Length == 0) { MessageBox.Show("You haven't chosen format of film!"); }
            else if (cb_Quality.Text.Length == 0) { MessageBox.Show("You haven't chosen quality of film!"); }
            else if (tb_Director.Text.Length == 0) { MessageBox.Show("You haven't written director of film!"); }
            else
            {
                form1.Collection.Addition(tb_Name.Text, cb_Company.Text, tb_Year.Text, cb_Genre.Text, tb_Duration.Text, cb_Format.Text, cb_Quality.Text, tb_Director.Text);
                form1.dgv_films.DataSource = null;
                form1.dgv_films.DataSource = form1.Collection.Movies;
                this.Close();
            }
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            
            int indexRow = form1.dgv_films.CurrentRow.Index;

            form1.dgv_films[0, indexRow].Value = tb_Name.Text;
            form1.dgv_films[1, indexRow].Value = cb_Company.Text;
            form1.dgv_films[2, indexRow].Value = tb_Year.Text;
            form1.dgv_films[4, indexRow].Value = tb_Duration.Text;
            form1.dgv_films[5, indexRow].Value = cb_Format.Text;
            form1.dgv_films[6, indexRow].Value = cb_Quality.Text ;
            form1.dgv_films[7, indexRow].Value = tb_Director.Text;
            form1.dgv_films[3, indexRow].Value = cb_Genre.Text;

            this.Close();
        }


    }
 
}
