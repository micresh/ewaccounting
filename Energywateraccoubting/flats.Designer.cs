namespace Energywateraccoubting
{
    partial class flats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flats));
            this.ewaccountingDataSet = new Energywateraccoubting.ewaccountingDataSet();
            this.flatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flatsTableAdapter = new Energywateraccoubting.ewaccountingDataSetTableAdapters.flatsTableAdapter();
            this.tableAdapterManager = new Energywateraccoubting.ewaccountingDataSetTableAdapters.TableAdapterManager();
            this.eecountsTableAdapter = new Energywateraccoubting.ewaccountingDataSetTableAdapters.eecountsTableAdapter();
            this.flatsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.flatsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.flatsDataGridView = new System.Windows.Forms.DataGridView();
            this.eecountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eecountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cwatcountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cwatcountsTableAdapter = new Energywateraccoubting.ewaccountingDataSetTableAdapters.cwatcountsTableAdapter();
            this.cwatcountsDataGridView = new System.Windows.Forms.DataGridView();
            this.countertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hwatcountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hwatcountsTableAdapter = new Energywateraccoubting.ewaccountingDataSetTableAdapters.hwatcountsTableAdapter();
            this.hwatcountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tempcountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempcountsTableAdapter = new Energywateraccoubting.ewaccountingDataSetTableAdapters.tempcountsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ewaccountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatsBindingNavigator)).BeginInit();
            this.flatsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eecountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eecountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwatcountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwatcountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempcountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ewaccountingDataSet
            // 
            this.ewaccountingDataSet.DataSetName = "ewaccountingDataSet";
            this.ewaccountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatsBindingSource
            // 
            this.flatsBindingSource.DataMember = "flats";
            this.flatsBindingSource.DataSource = this.ewaccountingDataSet;
            // 
            // flatsTableAdapter
            // 
            this.flatsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.buildingsTableAdapter = null;
            this.tableAdapterManager.cwatcountdescribeTableAdapter = null;
            this.tableAdapterManager.cwatcountsTableAdapter = null;
            this.tableAdapterManager.CWdataTableAdapter = null;
            this.tableAdapterManager.eecountdescribeTableAdapter = null;
            this.tableAdapterManager.eecountsTableAdapter = this.eecountsTableAdapter;
            this.tableAdapterManager.EEdataTableAdapter = null;
            this.tableAdapterManager.flatsTableAdapter = this.flatsTableAdapter;
            this.tableAdapterManager.hwatcountdescribeTableAdapter = null;
            this.tableAdapterManager.hwatcountsTableAdapter = null;
            this.tableAdapterManager.HWdataTableAdapter = null;
            this.tableAdapterManager.TEMPcomformityTableAdapter = null;
            this.tableAdapterManager.tempcountersdescribeTableAdapter = null;
            this.tableAdapterManager.tempcountsTableAdapter = null;
            this.tableAdapterManager.TEMPdataTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Energywateraccoubting.ewaccountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eecountsTableAdapter
            // 
            this.eecountsTableAdapter.ClearBeforeFill = true;
            // 
            // flatsBindingNavigator
            // 
            this.flatsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.flatsBindingNavigator.BindingSource = this.flatsBindingSource;
            this.flatsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.flatsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.flatsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.flatsBindingNavigatorSaveItem});
            this.flatsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.flatsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.flatsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.flatsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.flatsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.flatsBindingNavigator.Name = "flatsBindingNavigator";
            this.flatsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.flatsBindingNavigator.Size = new System.Drawing.Size(1143, 25);
            this.flatsBindingNavigator.TabIndex = 0;
            this.flatsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // flatsBindingNavigatorSaveItem
            // 
            this.flatsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flatsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("flatsBindingNavigatorSaveItem.Image")));
            this.flatsBindingNavigatorSaveItem.Name = "flatsBindingNavigatorSaveItem";
            this.flatsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.flatsBindingNavigatorSaveItem.Text = "Save Data";
            this.flatsBindingNavigatorSaveItem.Click += new System.EventHandler(this.flatsBindingNavigatorSaveItem_Click);
            // 
            // flatsDataGridView
            // 
            this.flatsDataGridView.AutoGenerateColumns = false;
            this.flatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flatsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.flatsDataGridView.DataSource = this.flatsBindingSource;
            this.flatsDataGridView.Location = new System.Drawing.Point(22, 29);
            this.flatsDataGridView.Name = "flatsDataGridView";
            this.flatsDataGridView.Size = new System.Drawing.Size(744, 220);
            this.flatsDataGridView.TabIndex = 1;
            // 
            // eecountsBindingSource
            // 
            this.eecountsBindingSource.DataMember = "fk_eecounts_1";
            this.eecountsBindingSource.DataSource = this.flatsBindingSource;
            // 
            // eecountsDataGridView
            // 
            this.eecountsDataGridView.AutoGenerateColumns = false;
            this.eecountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eecountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12});
            this.eecountsDataGridView.DataSource = this.eecountsBindingSource;
            this.eecountsDataGridView.Location = new System.Drawing.Point(26, 283);
            this.eecountsDataGridView.Name = "eecountsDataGridView";
            this.eecountsDataGridView.Size = new System.Drawing.Size(245, 228);
            this.eecountsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "countertype";
            this.dataGridViewTextBoxColumn9.HeaderText = "Тип счетчика";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "countervalue";
            this.dataGridViewTextBoxColumn12.HeaderText = "Показания";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Электросчетчики";
            // 
            // cwatcountsBindingSource
            // 
            this.cwatcountsBindingSource.DataMember = "fk_cwatcounts_2";
            this.cwatcountsBindingSource.DataSource = this.flatsBindingSource;
            // 
            // cwatcountsTableAdapter
            // 
            this.cwatcountsTableAdapter.ClearBeforeFill = true;
            // 
            // cwatcountsDataGridView
            // 
            this.cwatcountsDataGridView.AutoGenerateColumns = false;
            this.cwatcountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cwatcountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countertype,
            this.dataGridViewTextBoxColumn14});
            this.cwatcountsDataGridView.DataSource = this.cwatcountsBindingSource;
            this.cwatcountsDataGridView.Location = new System.Drawing.Point(276, 283);
            this.cwatcountsDataGridView.Name = "cwatcountsDataGridView";
            this.cwatcountsDataGridView.Size = new System.Drawing.Size(243, 228);
            this.cwatcountsDataGridView.TabIndex = 4;
            // 
            // countertype
            // 
            this.countertype.DataPropertyName = "countertype";
            this.countertype.HeaderText = "Тип счетчика";
            this.countertype.Name = "countertype";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "countervalue";
            this.dataGridViewTextBoxColumn14.HeaderText = "Показания";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // hwatcountsBindingSource
            // 
            this.hwatcountsBindingSource.DataMember = "fk_hwatcounts_2";
            this.hwatcountsBindingSource.DataSource = this.flatsBindingSource;
            // 
            // hwatcountsTableAdapter
            // 
            this.hwatcountsTableAdapter.ClearBeforeFill = true;
            // 
            // hwatcountsDataGridView
            // 
            this.hwatcountsDataGridView.AutoGenerateColumns = false;
            this.hwatcountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hwatcountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn19});
            this.hwatcountsDataGridView.DataSource = this.hwatcountsBindingSource;
            this.hwatcountsDataGridView.Location = new System.Drawing.Point(524, 283);
            this.hwatcountsDataGridView.Name = "hwatcountsDataGridView";
            this.hwatcountsDataGridView.Size = new System.Drawing.Size(249, 228);
            this.hwatcountsDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "countertype";
            this.dataGridViewTextBoxColumn16.HeaderText = "Тип счетчика";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "countervalue";
            this.dataGridViewTextBoxColumn19.HeaderText = "Показания";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Счетчики холодной воды";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Счетчики горячей воды";
            // 
            // tempcountsBindingSource
            // 
            this.tempcountsBindingSource.DataMember = "fk_tempcounts_2";
            this.tempcountsBindingSource.DataSource = this.flatsBindingSource;
            // 
            // tempcountsTableAdapter
            // 
            this.tempcountsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idflats";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идентификационный номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "buildingid";
            this.dataGridViewTextBoxColumn2.HeaderText = "Здание";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер квартиры";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "eecountsc";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество потребленной электроэнергии";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cwatcountsc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество потребленной холодной воды";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "hwatcountsc";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количесвто потребленной горячей воды";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tempcountsc";
            this.dataGridViewTextBoxColumn7.HeaderText = "Количесвто потребленного тепла";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // flats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 581);
            this.Controls.Add(this.hwatcountsDataGridView);
            this.Controls.Add(this.cwatcountsDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eecountsDataGridView);
            this.Controls.Add(this.flatsDataGridView);
            this.Controls.Add(this.flatsBindingNavigator);
            this.Name = "flats";
            this.Text = "Квартиры";
            this.Load += new System.EventHandler(this.flats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ewaccountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatsBindingNavigator)).EndInit();
            this.flatsBindingNavigator.ResumeLayout(false);
            this.flatsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eecountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eecountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwatcountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwatcountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempcountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ewaccountingDataSet ewaccountingDataSet;
        private System.Windows.Forms.BindingSource flatsBindingSource;
        private ewaccountingDataSetTableAdapters.flatsTableAdapter flatsTableAdapter;
        private ewaccountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator flatsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton flatsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView flatsDataGridView;
        private ewaccountingDataSetTableAdapters.eecountsTableAdapter eecountsTableAdapter;
        private System.Windows.Forms.BindingSource eecountsBindingSource;
        private System.Windows.Forms.DataGridView eecountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cwatcountsBindingSource;
        private ewaccountingDataSetTableAdapters.cwatcountsTableAdapter cwatcountsTableAdapter;
        private System.Windows.Forms.DataGridView cwatcountsDataGridView;
        private System.Windows.Forms.BindingSource hwatcountsBindingSource;
        private ewaccountingDataSetTableAdapters.hwatcountsTableAdapter hwatcountsTableAdapter;
        private System.Windows.Forms.DataGridView hwatcountsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tempcountsBindingSource;
        private ewaccountingDataSetTableAdapters.tempcountsTableAdapter tempcountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn countertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}