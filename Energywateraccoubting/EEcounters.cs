using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Energywateraccoubting
{
    public partial class EEcounters : Form
    {
        public EEcounters()
        {
            InitializeComponent();
        }

        private void eecountdescribeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eecountdescribeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ewaccountingDataSet);

        }

        private void EEcounters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ewaccountingDataSet.eecountdescribe' table. You can move, or remove it, as needed.
            this.eecountdescribeTableAdapter.Fill(this.ewaccountingDataSet.eecountdescribe);

        }
    }
}
