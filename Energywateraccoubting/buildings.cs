using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Energywateraccoubting
{
    public partial class buildings : Form
    {
        public buildings()
        {
            InitializeComponent();
        }

        private void buildingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.buildingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ewaccountingDataSet);

        }

        private void buildings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ewaccountingDataSet.flatsdescribe' table. You can move, or remove it, as needed.
            this.flatsdescribeTableAdapter.Fill(this.ewaccountingDataSet.flatsdescribe);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.flats' table. You can move, or remove it, as needed.
            this.flatsTableAdapter.Fill(this.ewaccountingDataSet.flats);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.flats' table. You can move, or remove it, as needed.
            this.flatsTableAdapter.Fill(this.ewaccountingDataSet.flats);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.buildings' table. You can move, or remove it, as needed.
            this.buildingsTableAdapter.Fill(this.ewaccountingDataSet.buildings);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] flatsids = dbdatahandler.retdb("flats", "idflats", null);
            
            // now we try get data from eecounts
             
            int[] eecounters = dbdatahandler.retdb("eecounts", "ideecounts", null);
                       
                for (int j = 0; j < eecounters.Length; j++)
                {
                    //now we get data from EEdata to compute; here we update data for all electric counters
                    int[] eecountval = dbdatahandler.retdb("EEdata", "value", "counterid=" + Convert.ToString(eecounters[j]));
                    int k = eecountval[eecountval.Length - 1] - eecountval[0];
                    int[] eeckimp = dbdatahandler.retdb("eecountdescribe", "kolimppered", "ideecountdescribe=" + Convert.ToString(eecounters[j]));
                    // here we compute the results of data to need (kw*h)
                    k = k / eeckimp[0];
                    eecountsTableAdapter1.UpdateQuery(k, eecounters[j]);
                }
            
            //here we're compute results and prepare data to paste that to the flats table
            
            // In this cicles j save the flatid, i - counterid in flat
            for (int j = 0; j < flatsids.Length; j++)
            {
                int[] eecountflat = dbdatahandler.retdb("eecounts", "countervalue", "counterflat=" + Convert.ToString(flatsids[j]));
            int sum = 0;
                for (int i = 0; i < eecountflat.Length; i++)
                {
                 sum += eecountflat[i];
                }
            flatsTableAdapter.UpdateQuery(sum, flatsids[j]);

            }
            // here we get data for cold water counters
            int[] cwcountersid  = dbdatahandler.retdb("cwatcounts","idcwatcounts",null);
            int[] cwcounterstype = dbdatahandler.retdb("cwatcounts", "countertype", null);
            
                for (int j = 0; j < cwcountersid.Length; j++)
                {
                    //now we get data from CWdata to compute; here we update data for all cold water counters
                    int[] cwcountval = dbdatahandler.retdb("CWdata", "value", "counterid=" + Convert.ToString(cwcountersid[j]));
                    int k = cwcountval[cwcountval.Length - 1] - cwcountval[0];
                    int[] cwcimp = dbdatahandler.retdb("cwatcountdescribe", "kolimppered", "idcwatcountdescribe=" + Convert.ToString(cwcounterstype[j]));
                    // here we compute the results of data to need (kw*h)
                    k = k / cwcimp[0];
                    cwatcountsTableAdapter1.UpdateQuery(k, cwcountersid[j]);
                }
            
            //here we're compute results and prepare data to paste that to the flats table
            // In this cicles j save the flatid, i - counterid in flat
            for (int j = 0; j < flatsids.Length; j++)
            {
                int[] cwcountflat = dbdatahandler.retdb("cwatcounts", "countervalue", "counterflat=" + Convert.ToString(flatsids[j]));
                int sum = 0;
                for (int i = 0; i < cwcountflat.Length; i++)
                {
                    sum += cwcountflat[i];
                }
                flatsTableAdapter.UpdateQueryCW(sum, flatsids[j]);

            }


            // in this section we count a heat water consumpsion
            int[] hwcountersid = dbdatahandler.retdb("hwatcounts", "idhwatcounts", "hwatacc=0;");
            int[] hwcounterstype = dbdatahandler.retdb("hwatcounts", "countertype", "hwatacc=0;");
           
                for (int j = 0; j < hwcountersid.Length; j++)
                {
                    //now we get data from CWdata to compute; here we update data for all cold water counters
                    int[] hwcountval = dbdatahandler.retdb("HWdata", "value", "counterid=" + Convert.ToString(hwcountersid[j]));
                    int k = hwcountval[hwcountval.Length - 1] - hwcountval[0];
                    int[] hwcimp = dbdatahandler.retdb("hwatcountdescribe", "kolimppered", "idhwatcountdesscribe=" + Convert.ToString(hwcounterstype[j]));
                    // here we compute the results of data to need (kw*h)
                    k = k / hwcimp[0];
                    hwatcountsTableAdapter1.UpdateQuery(k, hwcountersid[j]);
                }
            
            //here we're compute results and prepare data to paste that to the flats table
            // In this cicles j save the flatid, i - counterid in flat
            for (int j = 0; j < flatsids.Length; j++)
            {
                int[] hwcountflat = dbdatahandler.retdb("hwatcounts", "countervalue", "counterflat=" + Convert.ToString(flatsids[j]) + " and hwatacc=0");
                int sum = 0;
                for (int i = 0; i < hwcountflat.Length; i++)
                {
                    sum += hwcountflat[i];
                }
                flatsTableAdapter.UpdateQueryHW(sum, flatsids[j]);

            }
            // in this section we count a heat energy consumpsion
            int[] hecountersid = dbdatahandler.retdb("hwatcounts", "idhwatcounts", "hwatacc=1;");
            int[] hecounterstype = dbdatahandler.retdb("hwatcounts", "countertype", "hwatacc=1;"); ;
            
                for (int j = 0; j < hecountersid.Length; j++)
                {
                    //now we get data from HWdata to compute; here we update data heat water counters, which using in heat energy system
                    // here we need to select a previous and current temperature conditions
                    int[] hecountval = dbdatahandler.retdb("HWdata", "value", "counterid=" + Convert.ToString(hecountersid[j]));
                    // from this state starts a really magic
                    int[] hecimp = dbdatahandler.retdb("hwatcountdescribe", "kolimppered", "idhwatcountdesscribe=" + Convert.ToString(hecounterstype[j]));
                    int[] prevtempcounterid = dbdatahandler.retdb("TEMPcomformity", "prevtempcountid", "HWcountid=" + Convert.ToString(hecountersid[j]));
                    int[] curenttempcounterid = dbdatahandler.retdb("TEMPcomformity", "Tempcountid", "HWcountid=" + Convert.ToString(hecountersid[j]));
                    int[] tempvalsprevcount = dbdatahandler.retdb("TEMPdata", "value", "counterid=" + Convert.ToString(prevtempcounterid[0]));
                    int[] tempvalspcurrentcount = dbdatahandler.retdb("TEMPdata", "value", "counterid=" + Convert.ToString(curenttempcounterid[0]));
                    double energy = 0;
                    for (int n = 1; n < hecountval.Length; n++)
                    {
                        //here we realise a compute of heat energy, which counting such as Q=G(t2-t1)
                        energy += (hecountval[n] - hecountval[n - 1]) * (Math.Abs(tempvalsprevcount[n] - tempvalspcurrentcount[n]));
                    }
                    energy /= hecimp[0];
                    int k = Convert.ToInt32(energy);
                    hwatcountsTableAdapter1.UpdateQuery(k, hecountersid[j]);
                }
            
            //here we're compute results and prepare data to paste that to the flats table
            // In this cicles j save the flatid, i - counterid in flat
            for (int j = 0; j < flatsids.Length; j++)
            {
                int[] hwcountflat = dbdatahandler.retdb("hwatcounts", "countervalue", "counterflat=" + Convert.ToString(flatsids[j]) + " and hwatacc=1");
                int sum = 0;
                for (int i = 0; i < hwcountflat.Length; i++)
                {
                    sum += hwcountflat[i];
                }
                flatsTableAdapter.UpdateQueryHE(sum, flatsids[j]);
            }

            //now we update data to correct in the form
            this.tableAdapterManager.UpdateAll(this.ewaccountingDataSet);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.flats' table. You can move, or remove it, as needed.
            this.flatsTableAdapter.Fill(this.ewaccountingDataSet.flats);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.flats' table. You can move, or remove it, as needed.
            this.flatsTableAdapter.Fill(this.ewaccountingDataSet.flats);
            // TODO: This line of code loads data into the 'ewaccountingDataSet.buildings' table. You can move, or remove it, as needed.
            this.buildingsTableAdapter.Fill(this.ewaccountingDataSet.buildings);
            MessageBox.Show("Данные успешно обновлены");
  
        }

        
    }
}
