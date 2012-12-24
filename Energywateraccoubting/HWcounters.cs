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
    public partial class HWcounters : Form
    {
        public HWcounters()
        {
            InitializeComponent();
        }

        private void hwatcountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hwatcountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ewaccountingDataSet);

        }

        private void HWcounters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ewaccountingDataSet.hwatcountdescribe' table. You can move, or remove it, as needed.
            this.hwatcountdescribeTableAdapter.Fill(this.ewaccountingDataSet.hwatcountdescribe);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.hwatcounts' table. You can move, or remove it, as needed.
            this.hwatcountsTableAdapter.Fill(this.ewaccountingDataSet.hwatcounts);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.hwatcounts' table. You can move, or remove it, as needed.
            this.hwatcountsTableAdapter.Fill(this.ewaccountingDataSet.hwatcounts);

        }

        private void hwatcountsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hwatcountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ewaccountingDataSet);

        }
    }
}
