namespace Energywateraccoubting
{
    partial class EEcounters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EEcounters));
            this.ewaccountingDataSet = new Energywateraccoubting.ewaccountingDataSet();
            this.eecountdescribeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eecountdescribeTableAdapter = new Energywateraccoubting.ewaccountingDataSetTableAdapters.eecountdescribeTableAdapter();
            this.tableAdapterManager = new Energywateraccoubting.ewaccountingDataSetTableAdapters.TableAdapterManager();
            this.eecountdescribeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eecountdescribeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eecountdescribeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ewaccountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eecountdescribeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eecountdescribeBindingNavigator)).BeginInit();
            this.eecountdescribeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eecountdescribeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ewaccountingDataSet
            // 
            this.ewaccountingDataSet.DataSetName = "ewaccountingDataSet";
            this.ewaccountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eecountdescribeBindingSource
            // 
            this.eecountdescribeBindingSource.DataMember = "eecountdescribe";
            this.eecountdescribeBindingSource.DataSource = this.ewaccountingDataSet;
            // 
            // eecountdescribeTableAdapter
            // 
            this.eecountdescribeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.buildingsTableAdapter = null;
            this.tableAdapterManager.cwatcountdescribeTableAdapter = null;
            this.tableAdapterManager.cwatcountsTableAdapter = null;
            this.tableAdapterManager.eecountdescribeTableAdapter = this.eecountdescribeTableAdapter;
            this.tableAdapterManager.eecountsTableAdapter = null;
            this.tableAdapterManager.flatsTableAdapter = null;
            this.tableAdapterManager.hwatcountdescribeTableAdapter = null;
            this.tableAdapterManager.hwatcountsTableAdapter = null;
            this.tableAdapterManager.tempcountersdescribeTableAdapter = null;
            this.tableAdapterManager.tempcountsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Energywateraccoubting.ewaccountingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eecountdescribeBindingNavigator
            // 
            this.eecountdescribeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eecountdescribeBindingNavigator.BindingSource = this.eecountdescribeBindingSource;
            this.eecountdescribeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eecountdescribeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eecountdescribeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eecountdescribeBindingNavigatorSaveItem});
            this.eecountdescribeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eecountdescribeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eecountdescribeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eecountdescribeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eecountdescribeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eecountdescribeBindingNavigator.Name = "eecountdescribeBindingNavigator";
            this.eecountdescribeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eecountdescribeBindingNavigator.Size = new System.Drawing.Size(883, 25);
            this.eecountdescribeBindingNavigator.TabIndex = 0;
            this.eecountdescribeBindingNavigator.Text = "bindingNavigator1";
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
            // eecountdescribeBindingNavigatorSaveItem
            // 
            this.eecountdescribeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eecountdescribeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eecountdescribeBindingNavigatorSaveItem.Image")));
            this.eecountdescribeBindingNavigatorSaveItem.Name = "eecountdescribeBindingNavigatorSaveItem";
            this.eecountdescribeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.eecountdescribeBindingNavigatorSaveItem.Text = "Save Data";
            this.eecountdescribeBindingNavigatorSaveItem.Click += new System.EventHandler(this.eecountdescribeBindingNavigatorSaveItem_Click);
            // 
            // eecountdescribeDataGridView
            // 
            this.eecountdescribeDataGridView.AutoGenerateColumns = false;
            this.eecountdescribeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eecountdescribeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.eecountdescribeDataGridView.DataSource = this.eecountdescribeBindingSource;
            this.eecountdescribeDataGridView.Location = new System.Drawing.Point(12, 28);
            this.eecountdescribeDataGridView.Name = "eecountdescribeDataGridView";
            this.eecountdescribeDataGridView.Size = new System.Drawing.Size(448, 220);
            this.eecountdescribeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ideecountdescribe";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идентификационный номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "producer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kolimppered";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество импульсов на еденицу измерения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tochn";
            this.dataGridViewTextBoxColumn4.HeaderText = "Точность";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // EEcounters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 292);
            this.Controls.Add(this.eecountdescribeDataGridView);
            this.Controls.Add(this.eecountdescribeBindingNavigator);
            this.Name = "EEcounters";
            this.Text = "EEcounters";
            this.Load += new System.EventHandler(this.EEcounters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ewaccountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eecountdescribeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eecountdescribeBindingNavigator)).EndInit();
            this.eecountdescribeBindingNavigator.ResumeLayout(false);
            this.eecountdescribeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eecountdescribeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ewaccountingDataSet ewaccountingDataSet;
        private System.Windows.Forms.BindingSource eecountdescribeBindingSource;
        private ewaccountingDataSetTableAdapters.eecountdescribeTableAdapter eecountdescribeTableAdapter;
        private ewaccountingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eecountdescribeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eecountdescribeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eecountdescribeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}