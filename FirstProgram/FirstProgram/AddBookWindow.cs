using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProgram
{
    public partial class AddBookWindow : Form
    {
        private InitialWindow main;


        public AddBookWindow(InitialWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBookWindow_Load(object sender, EventArgs e)
        {

        }

        private void butAddBook_Click(object sender, EventArgs e)
        {
            String name = labName.Text;
            String code = labCode.Text;
            String author = labAuthor.Text;
            String gender = labGender.Text;
            String editorial = labEditorial.Text;
            String pubDate = labPubDate.Text;
            int quantity = int.Parse(jTxtFieldQuantity.Text);
            main.addBook(name, code, author, gender, editorial, pubDate,quantity);
            main.doVisible();
            clearCamps();
            this.SetVisibleCore(false);
        }
        public void clearCamps() {
            jTxtFieldName.Text = "";
            jTxtFieldCode.Text = "";
            jTxtFieldAuthor.Text = "";
            jTxtFieldGender.Text = "";
            jTxtFieldEditorial.Text = "";
            jTxtFieldPubDate.Text = "";
            jTxtFieldQuantity.Text = "";
        }

    }
}