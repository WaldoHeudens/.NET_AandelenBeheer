namespace AandelenBeheer
{
    partial class fmAandelen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAandelen));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label naamLabel;
            this.dbAandelenDataSet = new AandelenBeheer.dbAandelenDataSet();
            this.aandelenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aandelenTableAdapter = new AandelenBeheer.dbAandelenDataSetTableAdapters.AandelenTableAdapter();
            this.tableAdapterManager = new AandelenBeheer.dbAandelenDataSetTableAdapters.TableAdapterManager();
            this.aandelenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aandelenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.transactiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactiesTableAdapter = new AandelenBeheer.dbAandelenDataSetTableAdapters.TransactiesTableAdapter();
            this.transactiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbAandelenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBindingNavigator)).BeginInit();
            this.aandelenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dbAandelenDataSet
            // 
            this.dbAandelenDataSet.DataSetName = "dbAandelenDataSet";
            this.dbAandelenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aandelenBindingSource
            // 
            this.aandelenBindingSource.DataMember = "Aandelen";
            this.aandelenBindingSource.DataSource = this.dbAandelenDataSet;
            // 
            // aandelenTableAdapter
            // 
            this.aandelenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AandelenTableAdapter = this.aandelenTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TransactiesTableAdapter = this.transactiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = AandelenBeheer.dbAandelenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aandelenBindingNavigator
            // 
            this.aandelenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aandelenBindingNavigator.BindingSource = this.aandelenBindingSource;
            this.aandelenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aandelenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aandelenBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aandelenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aandelenBindingNavigatorSaveItem});
            this.aandelenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aandelenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aandelenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aandelenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aandelenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aandelenBindingNavigator.Name = "aandelenBindingNavigator";
            this.aandelenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aandelenBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.aandelenBindingNavigator.TabIndex = 0;
            this.aandelenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // aandelenBindingNavigatorSaveItem
            // 
            this.aandelenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aandelenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aandelenBindingNavigatorSaveItem.Image")));
            this.aandelenBindingNavigatorSaveItem.Name = "aandelenBindingNavigatorSaveItem";
            this.aandelenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aandelenBindingNavigatorSaveItem.Text = "Save Data";
            this.aandelenBindingNavigatorSaveItem.Click += new System.EventHandler(this.aandelenBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(61, 73);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(20, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aandelenBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(111, 73);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(61, 102);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(44, 15);
            naamLabel.TabIndex = 3;
            naamLabel.Text = "Naam:";
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aandelenBindingSource, "Naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(111, 99);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(139, 20);
            this.naamTextBox.TabIndex = 4;
            // 
            // transactiesBindingSource
            // 
            this.transactiesBindingSource.DataMember = "fk_AandelenTransacties";
            this.transactiesBindingSource.DataSource = this.aandelenBindingSource;
            // 
            // transactiesTableAdapter
            // 
            this.transactiesTableAdapter.ClearBeforeFill = true;
            // 
            // transactiesDataGridView
            // 
            this.transactiesDataGridView.AutoGenerateColumns = false;
            this.transactiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.transactiesDataGridView.DataSource = this.transactiesBindingSource;
            this.transactiesDataGridView.Location = new System.Drawing.Point(293, 73);
            this.transactiesDataGridView.Name = "transactiesDataGridView";
            this.transactiesDataGridView.RowHeadersWidth = 51;
            this.transactiesDataGridView.Size = new System.Drawing.Size(495, 352);
            this.transactiesDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn6.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Aangekocht";
            this.dataGridViewTextBoxColumn3.HeaderText = "Aangekocht";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Verkocht";
            this.dataGridViewTextBoxColumn4.HeaderText = "Verkocht";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prijs";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prijs";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // fmAandelen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transactiesDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.aandelenBindingNavigator);
            this.Name = "fmAandelen";
            this.Text = "Aandelenbeheer";
            this.Load += new System.EventHandler(this.fmAandelen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbAandelenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenBindingNavigator)).EndInit();
            this.aandelenBindingNavigator.ResumeLayout(false);
            this.aandelenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbAandelenDataSet dbAandelenDataSet;
        private System.Windows.Forms.BindingSource aandelenBindingSource;
        private dbAandelenDataSetTableAdapters.AandelenTableAdapter aandelenTableAdapter;
        private dbAandelenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aandelenBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aandelenBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox naamTextBox;
        private dbAandelenDataSetTableAdapters.TransactiesTableAdapter transactiesTableAdapter;
        private System.Windows.Forms.BindingSource transactiesBindingSource;
        private System.Windows.Forms.DataGridView transactiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

