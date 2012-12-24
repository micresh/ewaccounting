namespace Energywateraccoubting
{
    partial class HWcounters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HWcounters));
            System.Windows.Forms.Label producerLabel;
            this.ewaccountingDataSet = new Energywateraccoubting.ewaccountingDataSet();
            this.hwatcountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hwatcountsTableAdapter = new Energywateraccoubting.ewaccountingDataSetTableAdapters.hwatcountsTableAdapter();
            this.tableAdapterManager = new Energywateraccoubting.ewaccountingDataSetTableAdapters.TableAdapterManager();
            this.hwatcountsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.hwatcountsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hwatcountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hwatcountdescribeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hwatcountdescribeTableAdapter = new Energywateraccoubting.ewaccountingDataSetTableAdapters.hwatcountdescribeTableAdapter();
            this.producerTextBox = new System.Windows.Forms.TextBox();
            producerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ewaccountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountsBindingNavigator)).BeginInit();
            this.hwatcountsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountdescribeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ewaccountingDataSet
            // 
            this.ewaccountingDataSet.DataSetName = "ewaccountingDataSet";
            this.ewaccountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hwatcountsBindingSource
            // 
            this.hwatcountsBindingSource.DataMember = "hwatcounts";
            this.hwatcountsBindingSource.DataSource = this.ewaccountingDataSet;
            // 
            // hwatcountsTableAdapter
            // 
            this.hwatcountsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.buildingsTableAdapter = null;
            this.tableAdapterManager.cwatcountdescribeTableAdapter = null;
            this.tableAdapterManager.cwatcountsTableAdapter = null;
            this.tableAdapterManager.CWdataTableAdapter = null;
            this.tableAdapterManager.eecountdescribeTableAdapter = null;
            this.tableAdapterManager.eecountsTableAdapter = null;
            this.tableAdapterManager.EEdataTableAdapter = null;
            this.tableAdapterManager.flatsTableAdapter = null;
            this.tableAdapterManager.hwatcountdescribeTableAdapter = this.hwatcountdescribeTableAdapter;
            this.tableAdapterManager.hwatcountsTableAdapter = this.hwatcountsTableAdapter;
            this.tableAdapterManager.HWdataTableAdapter = null;
            this.tableAdapterManager.TEMPcomformityTableAdapter = null;
            this.tableAdapterManager.tempcountersdescribeTableAdapter = null;
            this.tableAdapterManager.tempcountsTableAdapter = null;
            this.tableAdapterManager.TEMPdataTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Energywateraccoubting.ewaccountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hwatcountsBindingNavigator
            // 
            this.hwatcountsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hwatcountsBindingNavigator.BindingSource = this.hwatcountsBindingSource;
            this.hwatcountsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hwatcountsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hwatcountsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hwatcountsBindingNavigatorSaveItem});
            this.hwatcountsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hwatcountsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hwatcountsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hwatcountsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hwatcountsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hwatcountsBindingNavigator.Name = "hwatcountsBindingNavigator";
            this.hwatcountsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hwatcountsBindingNavigator.Size = new System.Drawing.Size(693, 25);
            this.hwatcountsBindingNavigator.TabIndex = 0;
            this.hwatcountsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // hwatcountsBindingNavigatorSaveItem
            // 
            this.hwatcountsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hwatcountsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hwatcountsBindingNavigatorSaveItem.Image")));
            this.hwatcountsBindingNavigatorSaveItem.Name = "hwatcountsBindingNavigatorSaveItem";
            this.hwatcountsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.hwatcountsBindingNavigatorSaveItem.Text = "Save Data";
            this.hwatcountsBindingNavigatorSaveItem.Click += new System.EventHandler(this.hwatcountsBindingNavigatorSaveItem_Click_1);
            // 
            // hwatcountsDataGridView
            // 
            this.hwatcountsDataGridView.AutoGenerateColumns = false;
            this.hwatcountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hwatcountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.hwatcountsDataGridView.DataSource = this.hwatcountsBindingSource;
            this.hwatcountsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.hwatcountsDataGridView.Name = "hwatcountsDataGridView";
            this.hwatcountsDataGridView.Size = new System.Drawing.Size(645, 220);
            this.hwatcountsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idhwatcounts";
            this.dataGridViewTextBoxColumn1.HeaderText = "idhwatcounts";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "countertype";
            this.dataGridViewTextBoxColumn2.HeaderText = "countertype";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "counterbuild";
            this.dataGridViewTextBoxColumn3.HeaderText = "counterbuild";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "counterflat";
            this.dataGridViewTextBoxColumn4.HeaderText = "counterflat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "countervalue";
            this.dataGridViewTextBoxColumn5.HeaderText = "countervalue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "hwatacc";
            this.dataGridViewTextBoxColumn6.HeaderText = "hwatacc";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // hwatcountdescribeBindingSource
            // 
            this.hwatcountdescribeBindingSource.DataMember = "hwatcountdescribe";
            this.hwatcountdescribeBindingSource.DataSource = this.ewaccountingDataSet;
            // 
            // hwatcountdescribeTableAdapter
            // 
            this.hwatcountdescribeTableAdapter.ClearBeforeFill = true;
            // 
            // producerLabel
            // 
            producerLabel.AutoSize = true;
            producerLabel.Location = new System.Drawing.Point(12, 271);
            producerLabel.Name = "producerLabel";
            producerLabel.Size = new System.Drawing.Size(86, 13);
            producerLabel.TabIndex = 2;
            producerLabel.Text = "Производитель";
            // 
            // producerTextBox
            // 
            this.producerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hwatcountdescribeBindingSource, "producer", true));
            this.producerTextBox.Location = new System.Drawing.Point(99, 268);
            this.producerTextBox.Name = "producerTextBox";
            this.producerTextBox.Size = new System.Drawing.Size(100, 20);
            this.producerTextBox.TabIndex = 3;
            // 
            // HWcounters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 466);
            this.Controls.Add(producerLabel);
            this.Controls.Add(this.producerTextBox);
            this.Controls.Add(this.hwatcountsDataGridView);
            this.Controls.Add(this.hwatcountsBindingNavigator);
            this.Name = "HWcounters";
            this.Text = "Подключенные датчики горячей воды";
            this.Load += new System.EventHandler(this.HWcounters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ewaccountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountsBindingNavigator)).EndInit();
            this.hwatcountsBindingNavigator.ResumeLayout(false);
            this.hwatcountsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hwatcountdescribeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ewaccountingDataSet ewaccountingDataSet;
        private System.Windows.Forms.BindingSource hwatcountsBindingSource;
        private ewaccountingDataSetTableAdapters.hwatcountsTableAdapter hwatcountsTableAdapter;
        private ewaccountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hwatcountsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hwatcountsBindingNavigatorSaveItem;
        private ewaccountingDataSetTableAdapters.hwatcountdescribeTableAdapter hwatcountdescribeTableAdapter;
        private System.Windows.Forms.DataGridView hwatcountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource hwatcountdescribeBindingSource;
        private System.Windows.Forms.TextBox producerTextBox;

    }
}