namespace CarsDataBase
{
    partial class FrmCars
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
            this.lbl_Bowman = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet = new CarsDataBase.HireDataSet();
            this.txtRentalPerDay = new System.Windows.Forms.TextBox();
            this.TxtDateReg = new System.Windows.Forms.TextBox();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.chkbx1 = new System.Windows.Forms.CheckBox();
            this.lbl_RegNo = new System.Windows.Forms.Label();
            this.lbl_Make = new System.Windows.Forms.Label();
            this.lbl_engineSize = new System.Windows.Forms.Label();
            this.lbl_DateReg = new System.Windows.Forms.Label();
            this.lbl_RentPerDay = new System.Windows.Forms.Label();
            this.lbl_Available = new System.Windows.Forms.Label();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tblCarTableAdapter = new CarsDataBase.HireDataSetTableAdapters.TblCarTableAdapter();
            this.tableAdapterManager = new CarsDataBase.HireDataSetTableAdapters.TableAdapterManager();
            this.txt_Timer = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new CarsDataBase.HireDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Bowman
            // 
            this.lbl_Bowman.AutoSize = true;
            this.lbl_Bowman.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bowman.Location = new System.Drawing.Point(237, 37);
            this.lbl_Bowman.Name = "lbl_Bowman";
            this.lbl_Bowman.Size = new System.Drawing.Size(186, 26);
            this.lbl_Bowman.TabIndex = 1;
            this.lbl_Bowman.Text = "Bowman Car Hire";
            // 
            // txtReg
            // 
            this.txtReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "Vehicle Registration Number", true));
            this.txtReg.Location = new System.Drawing.Point(242, 90);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(137, 20);
            this.txtReg.TabIndex = 2;
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
            // txtRentalPerDay
            // 
            this.txtRentalPerDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "RentalPerDay", true));
            this.txtRentalPerDay.Location = new System.Drawing.Point(242, 241);
            this.txtRentalPerDay.Name = "txtRentalPerDay";
            this.txtRentalPerDay.Size = new System.Drawing.Size(137, 20);
            this.txtRentalPerDay.TabIndex = 3;
            // 
            // TxtDateReg
            // 
            this.TxtDateReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "DateRegistered", true));
            this.TxtDateReg.Location = new System.Drawing.Point(242, 200);
            this.TxtDateReg.Name = "TxtDateReg";
            this.TxtDateReg.Size = new System.Drawing.Size(137, 20);
            this.TxtDateReg.TabIndex = 4;
            this.TxtDateReg.TextChanged += new System.EventHandler(this.TxtDateReg_TextChanged);
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "EngineSize", true));
            this.txtEngineSize.Location = new System.Drawing.Point(242, 160);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(137, 20);
            this.txtEngineSize.TabIndex = 5;
            // 
            // txtMake
            // 
            this.txtMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "Make", true));
            this.txtMake.Location = new System.Drawing.Point(242, 123);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(137, 20);
            this.txtMake.TabIndex = 6;
            // 
            // chkbx1
            // 
            this.chkbx1.AutoSize = true;
            this.chkbx1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCarBindingSource, "Available", true));
            this.chkbx1.Location = new System.Drawing.Point(221, 280);
            this.chkbx1.Name = "chkbx1";
            this.chkbx1.Size = new System.Drawing.Size(15, 14);
            this.chkbx1.TabIndex = 7;
            this.chkbx1.UseVisualStyleBackColor = true;
            // 
            // lbl_RegNo
            // 
            this.lbl_RegNo.AutoSize = true;
            this.lbl_RegNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegNo.Location = new System.Drawing.Point(71, 92);
            this.lbl_RegNo.Name = "lbl_RegNo";
            this.lbl_RegNo.Size = new System.Drawing.Size(164, 13);
            this.lbl_RegNo.TabIndex = 8;
            this.lbl_RegNo.Text = "Vehicle registration number";
            // 
            // lbl_Make
            // 
            this.lbl_Make.AutoSize = true;
            this.lbl_Make.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Make.Location = new System.Drawing.Point(71, 126);
            this.lbl_Make.Name = "lbl_Make";
            this.lbl_Make.Size = new System.Drawing.Size(37, 13);
            this.lbl_Make.TabIndex = 9;
            this.lbl_Make.Text = "Make";
            // 
            // lbl_engineSize
            // 
            this.lbl_engineSize.AutoSize = true;
            this.lbl_engineSize.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_engineSize.Location = new System.Drawing.Point(71, 163);
            this.lbl_engineSize.Name = "lbl_engineSize";
            this.lbl_engineSize.Size = new System.Drawing.Size(71, 13);
            this.lbl_engineSize.TabIndex = 10;
            this.lbl_engineSize.Text = "Engine size";
            // 
            // lbl_DateReg
            // 
            this.lbl_DateReg.AutoSize = true;
            this.lbl_DateReg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateReg.Location = new System.Drawing.Point(71, 200);
            this.lbl_DateReg.Name = "lbl_DateReg";
            this.lbl_DateReg.Size = new System.Drawing.Size(99, 13);
            this.lbl_DateReg.TabIndex = 11;
            this.lbl_DateReg.Text = "Date Registered";
            // 
            // lbl_RentPerDay
            // 
            this.lbl_RentPerDay.AutoSize = true;
            this.lbl_RentPerDay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RentPerDay.Location = new System.Drawing.Point(71, 241);
            this.lbl_RentPerDay.Name = "lbl_RentPerDay";
            this.lbl_RentPerDay.Size = new System.Drawing.Size(91, 13);
            this.lbl_RentPerDay.TabIndex = 12;
            this.lbl_RentPerDay.Text = "Rental per day";
            // 
            // lbl_Available
            // 
            this.lbl_Available.AutoSize = true;
            this.lbl_Available.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Available.Location = new System.Drawing.Point(71, 284);
            this.lbl_Available.Name = "lbl_Available";
            this.lbl_Available.Size = new System.Drawing.Size(59, 13);
            this.lbl_Available.TabIndex = 13;
            this.lbl_Available.Text = "Available";
            // 
            // btn_First
            // 
            this.btn_First.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_First.Location = new System.Drawing.Point(79, 354);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(75, 23);
            this.btn_First.TabIndex = 14;
            this.btn_First.Text = "First";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Last.Location = new System.Drawing.Point(426, 354);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(75, 23);
            this.btn_Last.TabIndex = 15;
            this.btn_Last.Text = "Last";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(345, 354);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 16;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.Location = new System.Drawing.Point(160, 354);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.btn_Previous.TabIndex = 17;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(485, 284);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 34);
            this.btn_Exit.TabIndex = 18;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(485, 241);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 37);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "&Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(485, 198);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 37);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "&Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(485, 157);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 35);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "&Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(485, 107);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 32);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "&Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(485, 65);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 36);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "&Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TblCarTableAdapter = this.tblCarTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarsDataBase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_Timer
            // 
            this.txt_Timer.Location = new System.Drawing.Point(242, 354);
            this.txt_Timer.Name = "txt_Timer";
            this.txt_Timer.Size = new System.Drawing.Size(100, 20);
            this.txt_Timer.TabIndex = 24;
            this.txt_Timer.TextChanged += new System.EventHandler(this.txt_Timer_TextChanged_1);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.TblCarTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CarsDataBase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(626, 425);
            this.Controls.Add(this.txt_Timer);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_First);
            this.Controls.Add(this.lbl_Available);
            this.Controls.Add(this.lbl_RentPerDay);
            this.Controls.Add(this.lbl_DateReg);
            this.Controls.Add(this.lbl_engineSize);
            this.Controls.Add(this.lbl_Make);
            this.Controls.Add(this.lbl_RegNo);
            this.Controls.Add(this.chkbx1);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtEngineSize);
            this.Controls.Add(this.TxtDateReg);
            this.Controls.Add(this.txtRentalPerDay);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.lbl_Bowman);
            this.Name = "FrmCars";
            this.Text = "Task A: Akhona Khanyile 02 October 2024";
            this.Load += new System.EventHandler(this.FrmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bowman;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.TextBox txtRentalPerDay;
        private System.Windows.Forms.TextBox TxtDateReg;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.CheckBox chkbx1;
        private System.Windows.Forms.Label lbl_RegNo;
        private System.Windows.Forms.Label lbl_Make;
        private System.Windows.Forms.Label lbl_engineSize;
        private System.Windows.Forms.Label lbl_DateReg;
        private System.Windows.Forms.Label lbl_RentPerDay;
        private System.Windows.Forms.Label lbl_Available;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private HireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private HireDataSetTableAdapters.TblCarTableAdapter tblCarTableAdapter;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_Timer;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}