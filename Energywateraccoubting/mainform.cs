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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wmgr.ShowFlatsForm();
            
        }

        private void buildingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buildings newMDichild = new buildings();
            newMDichild.MdiParent = this;
            newMDichild.Show();
        }

        private void flatsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            flats newMDichild = new flats();
            newMDichild.MdiParent = this;
            newMDichild.Show();
        }

        private void ecountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EEcounters newMDichild = new EEcounters();
            newMDichild.MdiParent = this;
            newMDichild.Show();
        }

        private void cWcountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CWcounters newMDichild = new CWcounters();
            newMDichild.MdiParent = this;
            newMDichild.Show();
        }

        private void hWcountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HWcounters newMDichild = new HWcounters();
            newMDichild.MdiParent = this;
            newMDichild.Show();
        }

        private void tempcountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tempcounters newMDichild = new Tempcounters();
            newMDichild.MdiParent = this;
            newMDichild.Show();
        }
    }
}
