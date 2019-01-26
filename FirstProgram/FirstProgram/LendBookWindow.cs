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
    public partial class LendBookWindow : Form
    {
        private InitialWindow main;
        public LendBookWindow(InitialWindow initialWindow)
        {
            InitializeComponent();
            main = initialWindow;
        }

        private void LendBookWindow_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String code = jTxtFieldCodeToSearch.Text;
            int requiredQuantity = int.Parse(jTextFieldRequiredQuantity.Text);
            String time = comboBoxTime.SelectedText;
            main.lendBook(code, requiredQuantity,time);
            main.doVisible();
            this.SetVisibleCore(false);
            clearCamps();
        }

        private void clearCamps()
        {
            jTxtFieldCodeToSearch.Text = "";
            jTextFieldRequiredQuantity.Text = "";
            comboBoxTime.Text = "";
        }
    }
}
