using Project.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.presentation
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        private CustomerListingForm customerListForm;
        private CustomerController customerController;

        public MDIParent1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            customerController = new CustomerController();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #region Create a New ChildForm 
      
        public void CreateNewCustomerListForm()
        {
            customerListForm = new CustomerListingForm(customerController);
            customerListForm.MdiParent = this;        // Setting the MDI Parent
            customerListForm.StartPosition = FormStartPosition.CenterParent;
        }

        #endregion

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }


        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerListForm == null)
            {
                CreateNewCustomerListForm();
            }
            if (customerListForm.listFormClosed)
            {
                CreateNewCustomerListForm();
            }
            customerListForm.setUpCustomerListView();
            customerListForm.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerListForm == null)
            {
                CreateNewCustomerListForm();
            }
            if (customerListForm.listFormClosed)
            {
                CreateNewCustomerListForm();
            }
            customerListForm.setUpCustomerListView();
            customerListForm.Show();
        }
    }
}
