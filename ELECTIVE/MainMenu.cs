using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELECTIVE
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void aDMINFORMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                AdminForm adminForm = new AdminForm();
                adminForm.MdiParent = this;
                adminForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Admin Form: " + ex.Message);
            }
        }

        private void dISPLAYFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayForm displayForm = new DisplayForm();
                displayForm.MdiParent = this;
                displayForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Display Form: " + ex.Message);
            }
        }

        private void cAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CashierInterface cashierForm = new CashierInterface();
                cashierForm.MdiParent = this;
                cashierForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Cashier Form: " + ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to exit?",
               "Exit Application",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Close all windows?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
            }
        }
    }
}
