using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EikonSxSClassLibrary;

namespace TestEikonSxS
{
    public partial class ModifyContextUI : Form
    {
        public EikonApp EIKONAPP { get; set; }


        public ModifyContextUI()
        {
            InitializeComponent();
        }

        private void ModifyContextUI_Load(object sender, EventArgs e)
        {

            // Add list to entities to the listbox
            lsbContext.Items.Clear();

            foreach (JsonEntities entities in EIKONAPP.APP.context.entities)
            {
                lsbContext.Items.Add(entities.RIC);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Clear the list and re-add the modified list 
            EIKONAPP.APP.context.entities.Clear();

            foreach (string strRic in lsbContext.Items)
            {
                EIKONAPP.APP.context.entities.Add(new JsonEntities(strRic));
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddContext_Click(object sender, EventArgs e)
        {
            lsbContext.Items.Add(cmbAddContext.Text);
        }

        private void btnDelContext_Click(object sender, EventArgs e)
        {
            lsbContext.Items.Remove(lsbContext.SelectedItem);
        }

        private void btnClearContext_Click(object sender, EventArgs e)
        {    
            lsbContext.Items.Clear();
    
        }

        private void cmbAddContext_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddContext_Click(sender, e);
            }
        }

        private void lsbContext_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelContext_Click(sender, e);
            }
        }
    }
}
