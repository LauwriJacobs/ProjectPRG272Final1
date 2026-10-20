namespace ProjectPRG272Final1
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
            this.txtUpID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.CAnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSpecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRecovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHousing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecoveryscore = new System.Windows.Forms.Label();
            this.txtRecovery = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.txtOldValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSummery = new System.Windows.Forms.Button();
            this.lblDSummery = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUpID
            // 
            this.txtUpID.Location = new System.Drawing.Point(85, 19);
            this.txtUpID.Name = "txtUpID";
            this.txtUpID.Size = new System.Drawing.Size(100, 20);
            this.txtUpID.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(347, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(231, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CAnimalID,
            this.CName,
            this.CSpecies,
            this.CAge,
            this.CRecovery,
            this.CStatus,
            this.CHousing});
            this.dgvAnimals.Location = new System.Drawing.Point(242, 44);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.ReadOnly = true;
            this.dgvAnimals.Size = new System.Drawing.Size(745, 204);
            this.dgvAnimals.TabIndex = 14;
            // 
            // CAnimalID
            // 
            this.CAnimalID.DataPropertyName = "AnimalID";
            this.CAnimalID.HeaderText = "AnimalID";
            this.CAnimalID.Name = "CAnimalID";
            this.CAnimalID.ReadOnly = true;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "Name";
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            // 
            // CSpecies
            // 
            this.CSpecies.DataPropertyName = "Species";
            this.CSpecies.HeaderText = "Species";
            this.CSpecies.Name = "CSpecies";
            this.CSpecies.ReadOnly = true;
            // 
            // CAge
            // 
            this.CAge.DataPropertyName = "Age";
            this.CAge.HeaderText = "Age";
            this.CAge.Name = "CAge";
            this.CAge.ReadOnly = true;
            // 
            // CRecovery
            // 
            this.CRecovery.DataPropertyName = "Recoverystat";
            this.CRecovery.HeaderText = "Recovery Score";
            this.CRecovery.Name = "CRecovery";
            this.CRecovery.ReadOnly = true;
            // 
            // CStatus
            // 
            this.CStatus.DataPropertyName = "Status";
            this.CStatus.HeaderText = "Status";
            this.CStatus.Name = "CStatus";
            this.CStatus.ReadOnly = true;
            // 
            // CHousing
            // 
            this.CHousing.DataPropertyName = "Housing";
            this.CHousing.HeaderText = "Housing Unit";
            this.CHousing.Name = "CHousing";
            this.CHousing.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(121, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecoveryscore);
            this.groupBox1.Controls.Add(this.txtRecovery);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtSpecies);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAnimalID);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblSpecies);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblAnimalID);
            this.groupBox1.Location = new System.Drawing.Point(27, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Animal";
            // 
            // lblRecoveryscore
            // 
            this.lblRecoveryscore.AutoSize = true;
            this.lblRecoveryscore.Location = new System.Drawing.Point(1, 174);
            this.lblRecoveryscore.Name = "lblRecoveryscore";
            this.lblRecoveryscore.Size = new System.Drawing.Size(87, 13);
            this.lblRecoveryscore.TabIndex = 9;
            this.lblRecoveryscore.Text = "Recovery Score:";
            // 
            // txtRecovery
            // 
            this.txtRecovery.Location = new System.Drawing.Point(94, 171);
            this.txtRecovery.Name = "txtRecovery";
            this.txtRecovery.Size = new System.Drawing.Size(100, 20);
            this.txtRecovery.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(94, 133);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 7;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(94, 101);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(100, 20);
            this.txtSpecies.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(94, 35);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(100, 20);
            this.txtAnimalID.TabIndex = 4;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(59, 136);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age:";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(40, 101);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(48, 13);
            this.lblSpecies.TabIndex = 2;
            this.lblSpecies.Text = "Species:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.Location = new System.Drawing.Point(33, 38);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(55, 13);
            this.lblAnimalID.TabIndex = 0;
            this.lblAnimalID.Text = "Animal ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "AnimalID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNewValue);
            this.groupBox2.Controls.Add(this.txtOldValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtUpID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(121, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(85, 72);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewValue.TabIndex = 22;
            // 
            // txtOldValue
            // 
            this.txtOldValue.Location = new System.Drawing.Point(85, 47);
            this.txtOldValue.Name = "txtOldValue";
            this.txtOldValue.Size = new System.Drawing.Size(100, 20);
            this.txtOldValue.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Change Value:";
            // 
            // btnSummery
            // 
            this.btnSummery.Location = new System.Drawing.Point(483, 264);
            this.btnSummery.Name = "btnSummery";
            this.btnSummery.Size = new System.Drawing.Size(133, 23);
            this.btnSummery.TabIndex = 20;
            this.btnSummery.Text = "Generate Summery";
            this.btnSummery.UseVisualStyleBackColor = true;
            this.btnSummery.Click += new System.EventHandler(this.btnSummery_Click);
            // 
            // lblDSummery
            // 
            this.lblDSummery.AutoSize = true;
            this.lblDSummery.Location = new System.Drawing.Point(492, 334);
            this.lblDSummery.Name = "lblDSummery";
            this.lblDSummery.Size = new System.Drawing.Size(35, 13);
            this.lblDSummery.TabIndex = 21;
            this.lblDSummery.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 561);
            this.Controls.Add(this.lblDSummery);
            this.Controls.Add(this.btnSummery);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvAnimals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSpecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRecovery;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHousing;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecoveryscore;
        private System.Windows.Forms.TextBox txtRecovery;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAnimalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.TextBox txtOldValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSummery;
        private System.Windows.Forms.Label lblDSummery;
    }
}

