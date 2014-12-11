namespace SQLiteDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.geometryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._4bandDataSet = new SQLiteDemo._4bandDataSet();
            this.geometryTableAdapter = new SQLiteDemo._4bandDataSetTableAdapters.GeometryTableAdapter();
            this.compactnessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borderlengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borderindexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asymmetryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geometryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._4bandDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(608, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // geometryBindingSource
            // 
            this.geometryBindingSource.DataMember = "Geometry";
            this.geometryBindingSource.DataSource = this._4bandDataSet;
            // 
            // _4bandDataSet
            // 
            this._4bandDataSet.DataSetName = "_4bandDataSet";
            this._4bandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // geometryTableAdapter
            // 
            this.geometryTableAdapter.ClearBeforeFill = true;
            // 
            // compactnessDataGridViewTextBoxColumn
            // 
            this.compactnessDataGridViewTextBoxColumn.DataPropertyName = "compactness";
            this.compactnessDataGridViewTextBoxColumn.HeaderText = "compactness";
            this.compactnessDataGridViewTextBoxColumn.Name = "compactnessDataGridViewTextBoxColumn";
            // 
            // borderlengthDataGridViewTextBoxColumn
            // 
            this.borderlengthDataGridViewTextBoxColumn.DataPropertyName = "border_length";
            this.borderlengthDataGridViewTextBoxColumn.HeaderText = "border_length";
            this.borderlengthDataGridViewTextBoxColumn.Name = "borderlengthDataGridViewTextBoxColumn";
            // 
            // borderindexDataGridViewTextBoxColumn
            // 
            this.borderindexDataGridViewTextBoxColumn.DataPropertyName = "border_index";
            this.borderindexDataGridViewTextBoxColumn.HeaderText = "border_index";
            this.borderindexDataGridViewTextBoxColumn.Name = "borderindexDataGridViewTextBoxColumn";
            // 
            // asymmetryDataGridViewTextBoxColumn
            // 
            this.asymmetryDataGridViewTextBoxColumn.DataPropertyName = "asymmetry";
            this.asymmetryDataGridViewTextBoxColumn.HeaderText = "asymmetry";
            this.asymmetryDataGridViewTextBoxColumn.Name = "asymmetryDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // objectIDDataGridViewTextBoxColumn
            // 
            this.objectIDDataGridViewTextBoxColumn.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.HeaderText = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.Name = "objectIDDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectIDDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.asymmetryDataGridViewTextBoxColumn,
            this.borderindexDataGridViewTextBoxColumn,
            this.borderlengthDataGridViewTextBoxColumn,
            this.compactnessDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.geometryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(608, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 344);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByToolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geometryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._4bandDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _4bandDataSet _4bandDataSet;
        private System.Windows.Forms.BindingSource geometryBindingSource;
        private _4bandDataSetTableAdapters.GeometryTableAdapter geometryTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn compactnessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borderlengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borderindexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asymmetryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

