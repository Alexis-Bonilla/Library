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
    public partial class InitialWindow : Form
    {
        private AddBookWindow addBookWindow;
        private LendBookWindow lendBookWindow;
        
        public InitialWindow()
        {
            InitializeComponent();
            addBookWindow = new AddBookWindow(this);
            lendBookWindow = new LendBookWindow(this);
        }

        private void InitialWindow_Load(object sender, EventArgs e)
        {

        }

        private void butAddBook_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            addBookWindow.Show();
        }

        public void doVisible() {
            this.SetVisibleCore(true);
        }

        internal void addBook(string name, string code, string author, string gender, string editorial, string pubDate, int quantity)
        {
            
        }

        internal void lendBook(string code, int requiredQuantity, string time)
        {
           
        }

        private void butLendBook_Click(object sender, EventArgs e)
        {
            lendBookWindow.Show();
            this.SetVisibleCore(false);
        }
    }
}
