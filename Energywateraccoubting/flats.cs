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
    public partial class flats : Form
    {
        public flats()
        {
            InitializeComponent();
        }

        private void flatsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flatsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ewaccountingDataSet);

        }

        private void flats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ewaccountingDataSet.tempcounts' table. You can move, or remove it, as needed.
            this.tempcountsTableAdapter.Fill(this.ewaccountingDataSet.tempcounts);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.hwatcounts' table. You can move, or remove it, as needed.
            this.hwatcountsTableAdapter.Fill(this.ewaccountingDataSet.hwatcounts);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.cwatcounts' table. You can move, or remove it, as needed.
            this.cwatcountsTableAdapter.Fill(this.ewaccountingDataSet.cwatcounts);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.eecounts' table. You can move, or remove it, as needed.
            this.eecountsTableAdapter.Fill(this.ewaccountingDataSet.eecounts);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.flats' table. You can move, or remove it, as needed.
            this.flatsTableAdapter.Fill(this.ewaccountingDataSet.flats);

        }
    }
}
