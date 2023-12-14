namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._1234DataSet = new WindowsFormsApp2._1234DataSet();
            this.typeEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeEquipmentTableAdapter = new WindowsFormsApp2._1234DataSetTableAdapters.TypeEquipmentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._1234DataSet1 = new WindowsFormsApp2._1234DataSet1();
            this.typeEquipmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typeEquipmentTableAdapter1 = new WindowsFormsApp2._1234DataSet1TableAdapters.TypeEquipmentTableAdapter();
            this.nameEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._1234DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1234DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEquipmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // _1234DataSet
            // 
            this._1234DataSet.DataSetName = "_1234DataSet";
            this._1234DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeEquipmentBindingSource
            // 
            this.typeEquipmentBindingSource.DataMember = "TypeEquipment";
            this.typeEquipmentBindingSource.DataSource = this._1234DataSet;
            // 
            // typeEquipmentTableAdapter
            // 
            this.typeEquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Типы оборудования";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameEquipmentDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.typeEquipmentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(260, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // _1234DataSet1
            // 
            this._1234DataSet1.DataSetName = "_1234DataSet1";
            this._1234DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeEquipmentBindingSource1
            // 
            this.typeEquipmentBindingSource1.DataMember = "TypeEquipment";
            this.typeEquipmentBindingSource1.DataSource = this._1234DataSet1;
            // 
            // typeEquipmentTableAdapter1
            // 
            this.typeEquipmentTableAdapter1.ClearBeforeFill = true;
            // 
            // nameEquipmentDataGridViewTextBoxColumn
            // 
            this.nameEquipmentDataGridViewTextBoxColumn.DataPropertyName = "NameEquipment";
            this.nameEquipmentDataGridViewTextBoxColumn.HeaderText = "NameEquipment";
            this.nameEquipmentDataGridViewTextBoxColumn.Name = "nameEquipmentDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 273);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._1234DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1234DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEquipmentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private _1234DataSet _1234DataSet;
        private System.Windows.Forms.BindingSource typeEquipmentBindingSource;
        private _1234DataSetTableAdapters.TypeEquipmentTableAdapter typeEquipmentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _1234DataSet1 _1234DataSet1;
        private System.Windows.Forms.BindingSource typeEquipmentBindingSource1;
        private _1234DataSet1TableAdapters.TypeEquipmentTableAdapter typeEquipmentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}

