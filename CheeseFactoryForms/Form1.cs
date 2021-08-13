using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheeseFactory;

namespace CheeseFactoryForms
{
    public partial class frmMain : Form
    {
        CheeseProduction cp = new CheeseProduction();

        public frmMain()
        {
            InitializeComponent();
        }

        private void lblAddTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCheese_Click(object sender, EventArgs e)
        {
            var CheeseName = edtCheeseName.Text;
            var CheeseID = Convert.ToInt32(edtCheeseID.Text);
            var CheeseBatch = Convert.ToInt32(edtBatchNum.Text);
            var CheeseManDate = mDate.Value;
            var CheeseBBDate = bbDate.Value;

            cp.addCheese(CheeseID, CheeseBatch, CheeseName, CheeseManDate, CheeseBBDate);
            printCheeses();
        }

        public void printCheeses()
        {
            redtCheeses.Text = "";
            for (int i = 0; i < cp.ListSize; i++)
            {
                redtCheeses.Text += cp.CheeseList()[i];
                redtCheeses.Text += "================\n";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int iID = Convert.ToInt32(edtFindID.Text);
            if (cp.search(iID) != null)
            {
                MessageBox.Show("Cheese Found!\n" + cp.search(iID).CheeseToString());
            }
            else
            {
                MessageBox.Show("Cheese not Found!");
            }
        }
    }
}
