namespace CarsDataBase
{
    partial class FrmSearch
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
            this.DataGridViewSearchResults = new System.Windows.Forms.DataGridView();
            this.vehicleRegistrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegisteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet = new CarsDataBase.HireDataSet();
            this.tblCarTableAdapter = new CarsDataBase.HireDataSetTableAdapters.TblCarTableAdapter();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.cboOperater = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Field = new System.Windows.Forms.Label();
            this.lbl_Operator = new System.Windows.Forms.Label();
            this.lbl_Value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewSearchResults
            // 
            this.DataGridViewSearchResults.AutoGenerateColumns = false;
            this.DataGridViewSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleRegistrationNumberDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.engineSizeDataGridViewTextBoxColumn,
            this.dateRegisteredDataGridViewTextBoxColumn,
            this.rentalPerDayDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn});
            this.DataGridViewSearchResults.DataSource = this.tblCarBindingSource;
            this.DataGridViewSearchResults.Location = new System.Drawing.Point(12, 161);
            this.DataGridViewSearchResults.Name = "DataGridViewSearchResults";
            this.DataGridViewSearchResults.Size = new System.Drawing.Size(646, 150);
            this.DataGridViewSearchResults.TabIndex = 0;
            // 
            // vehicleRegistrationNumberDataGridViewTextBoxColumn
            // 
            this.vehicleRegistrationNumberDataGridViewTextBoxColumn.DataPropertyName = "Vehicle Registration Number";
            this.vehicleRegistrationNumberDataGridViewTextBoxColumn.HeaderText = "Vehicle Registration Number";
            this.vehicleRegistrationNumberDataGridViewTextBoxColumn.Name = "vehicleRegistrationNumberDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // engineSizeDataGridViewTextBoxColumn
            // 
            this.engineSizeDataGridViewTextBoxColumn.DataPropertyName = "EngineSize";
            this.engineSizeDataGridViewTextBoxColumn.HeaderText = "EngineSize";
            this.engineSizeDataGridViewTextBoxColumn.Name = "engineSizeDataGridViewTextBoxColumn";
            // 
            // dateRegisteredDataGridViewTextBoxColumn
            // 
            this.dateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.HeaderText = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.Name = "dateRegisteredDataGridViewTextBoxColumn";
            // 
            // rentalPerDayDataGridViewTextBoxColumn
            // 
            this.rentalPerDayDataGridViewTextBoxColumn.DataPropertyName = "RentalPerDay";
            this.rentalPerDayDataGridViewTextBoxColumn.HeaderText = "RentalPerDay";
            this.rentalPerDayDataGridViewTextBoxColumn.Name = "rentalPerDayDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewCheckBoxColumn
            // 
            this.availableDataGridViewCheckBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewCheckBoxColumn.HeaderText = "Available";
            this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
            // 
            // tblCarBindingSource
            // 
            this.tblCarBindingSource.DataMember = "TblCar";
            this.tblCarBindingSource.DataSource = this.hireDataSet;
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "HireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // cboField
            // 
            this.cboField.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboField.FormattingEnabled = true;
            this.cboField.Items.AddRange(new object[] {
            "Make",
            "EngineSize",
            "RentalPerDay",
            "Available"});
            this.cboField.Location = new System.Drawing.Point(43, 92);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 1;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // cboOperater
            // 
            this.cboOperater.FormattingEnabled = true;
            this.cboOperater.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">="});
            this.cboOperater.Location = new System.Drawing.Point(211, 92);
            this.cboOperater.Name = "cboOperater";
            this.cboOperater.Size = new System.Drawing.Size(74, 21);
            this.cboOperater.TabIndex = 2;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(310, 93);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(126, 20);
            this.txtValue.TabIndex = 3;
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(465, 50);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(86, 37);
            this.btn_Run.TabIndex = 4;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(465, 92);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(86, 40);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Field
            // 
            this.lbl_Field.AutoSize = true;
            this.lbl_Field.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Field.Location = new System.Drawing.Point(40, 55);
            this.lbl_Field.Name = "lbl_Field";
            this.lbl_Field.Size = new System.Drawing.Size(33, 13);
            this.lbl_Field.TabIndex = 6;
            this.lbl_Field.Text = "Field";
            // 
            // lbl_Operator
            // 
            this.lbl_Operator.AutoSize = true;
            this.lbl_Operator.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Operator.Location = new System.Drawing.Point(208, 55);
            this.lbl_Operator.Name = "lbl_Operator";
            this.lbl_Operator.Size = new System.Drawing.Size(58, 13);
            this.lbl_Operator.TabIndex = 7;
            this.lbl_Operator.Text = "Operator";
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Value.Location = new System.Drawing.Point(307, 55);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(38, 13);
            this.lbl_Value.TabIndex = 8;
            this.lbl_Value.Text = "Value";
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.lbl_Operator);
            this.Controls.Add(this.lbl_Field);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cboOperater);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.DataGridViewSearchResults);
            this.Name = "FrmSearch";
            this.Text = "Task B:Akhona Khanyile 02 October 2024";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewSearchResults;
        private HireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private HireDataSetTableAdapters.TblCarTableAdapter tblCarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegistrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegisteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalPerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.ComboBox cboOperater;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Field;
        private System.Windows.Forms.Label lbl_Operator;
        private System.Windows.Forms.Label lbl_Value;
    }
}