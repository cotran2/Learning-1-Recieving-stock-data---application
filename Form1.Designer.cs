namespace StockRequest
{
    partial class Form1
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
            System.Windows.Forms.Label stockNameLabel;
            System.Windows.Forms.Label askLabel;
            System.Windows.Forms.Label bidLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.stockDatabaseDataSet = new StockRequest.StockDatabaseDataSet();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new StockRequest.StockDatabaseDataSetTableAdapters.StocksTableAdapter();
            this.tableAdapterManager = new StockRequest.StockDatabaseDataSetTableAdapters.TableAdapterManager();
            this.stocksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stocksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stockNameTextBox = new System.Windows.Forms.TextBox();
            this.askTextBox = new System.Windows.Forms.TextBox();
            this.bidTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            stockNameLabel = new System.Windows.Forms.Label();
            askLabel = new System.Windows.Forms.Label();
            bidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingNavigator)).BeginInit();
            this.stocksBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockNameLabel
            // 
            stockNameLabel.AutoSize = true;
            stockNameLabel.Location = new System.Drawing.Point(153, 121);
            stockNameLabel.Name = "stockNameLabel";
            stockNameLabel.Size = new System.Drawing.Size(88, 17);
            stockNameLabel.TabIndex = 2;
            stockNameLabel.Text = "Stock Name:";
            // 
            // askLabel
            // 
            askLabel.AutoSize = true;
            askLabel.Location = new System.Drawing.Point(153, 166);
            askLabel.Name = "askLabel";
            askLabel.Size = new System.Drawing.Size(35, 17);
            askLabel.TabIndex = 4;
            askLabel.Text = "Ask:";
            // 
            // bidLabel
            // 
            bidLabel.AutoSize = true;
            bidLabel.Location = new System.Drawing.Point(153, 208);
            bidLabel.Name = "bidLabel";
            bidLabel.Size = new System.Drawing.Size(32, 17);
            bidLabel.TabIndex = 6;
            bidLabel.Text = "Bid:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stockDatabaseDataSet
            // 
            this.stockDatabaseDataSet.DataSetName = "StockDatabaseDataSet";
            this.stockDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.stockDatabaseDataSet;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StocksTableAdapter = this.stocksTableAdapter;
            this.tableAdapterManager.UpdateOrder = StockRequest.StockDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stocksBindingNavigator
            // 
            this.stocksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stocksBindingNavigator.BindingSource = this.stocksBindingSource;
            this.stocksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stocksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stocksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stocksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stocksBindingNavigatorSaveItem});
            this.stocksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stocksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stocksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stocksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stocksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stocksBindingNavigator.Name = "stocksBindingNavigator";
            this.stocksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stocksBindingNavigator.Size = new System.Drawing.Size(1104, 27);
            this.stocksBindingNavigator.TabIndex = 1;
            this.stocksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // stocksBindingNavigatorSaveItem
            // 
            this.stocksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stocksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stocksBindingNavigatorSaveItem.Image")));
            this.stocksBindingNavigatorSaveItem.Name = "stocksBindingNavigatorSaveItem";
            this.stocksBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.stocksBindingNavigatorSaveItem.Text = "Save Data";
            this.stocksBindingNavigatorSaveItem.Click += new System.EventHandler(this.stocksBindingNavigatorSaveItem_Click);
            // 
            // stockNameTextBox
            // 
            this.stockNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksBindingSource, "StockName", true));
            this.stockNameTextBox.Location = new System.Drawing.Point(282, 121);
            this.stockNameTextBox.Name = "stockNameTextBox";
            this.stockNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.stockNameTextBox.TabIndex = 3;
            // 
            // askTextBox
            // 
            this.askTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksBindingSource, "Ask", true));
            this.askTextBox.Location = new System.Drawing.Point(282, 161);
            this.askTextBox.Name = "askTextBox";
            this.askTextBox.Size = new System.Drawing.Size(100, 22);
            this.askTextBox.TabIndex = 5;
            // 
            // bidTextBox
            // 
            this.bidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksBindingSource, "Bid", true));
            this.bidTextBox.Location = new System.Drawing.Point(282, 208);
            this.bidTextBox.Name = "bidTextBox";
            this.bidTextBox.Size = new System.Drawing.Size(100, 22);
            this.bidTextBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 68);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Enabled=false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(449, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 86);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Please type in the name of company stock and hit the Submit button. \r\nAfter consi" +
    "dering the ask and bit values, if you want to save data into database, please hi" +
    "t the\r\n Save button.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(bidLabel);
            this.Controls.Add(this.bidTextBox);
            this.Controls.Add(askLabel);
            this.Controls.Add(this.askTextBox);
            this.Controls.Add(stockNameLabel);
            this.Controls.Add(this.stockNameTextBox);
            this.Controls.Add(this.stocksBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingNavigator)).EndInit();
            this.stocksBindingNavigator.ResumeLayout(false);
            this.stocksBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private StockDatabaseDataSet stockDatabaseDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private StockDatabaseDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        private StockDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stocksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stocksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stockNameTextBox;
        private System.Windows.Forms.TextBox askTextBox;
        private System.Windows.Forms.TextBox bidTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

