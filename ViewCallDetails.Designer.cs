namespace CallLogManager
{
    partial class ViewCallDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgId,
            this.dgFirstName,
            this.dgSurname,
            this.dgTime,
            this.dgAddress,
            this.dgMobile,
            this.dgDate,
            this.dgStatus,
            this.dgDuration,
            this.dgRemarks});
            this.dataGridView1.Location = new System.Drawing.Point(1, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(720, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(303, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgId
            // 
            this.dgId.HeaderText = "Id";
            this.dgId.MinimumWidth = 6;
            this.dgId.Name = "dgId";
            this.dgId.Width = 125;
            // 
            // dgFirstName
            // 
            this.dgFirstName.HeaderText = "FirstName";
            this.dgFirstName.MinimumWidth = 6;
            this.dgFirstName.Name = "dgFirstName";
            this.dgFirstName.Width = 125;
            // 
            // dgSurname
            // 
            this.dgSurname.HeaderText = "Surname";
            this.dgSurname.MinimumWidth = 6;
            this.dgSurname.Name = "dgSurname";
            this.dgSurname.Width = 125;
            // 
            // dgTime
            // 
            this.dgTime.HeaderText = "Time";
            this.dgTime.MinimumWidth = 6;
            this.dgTime.Name = "dgTime";
            this.dgTime.Width = 125;
            // 
            // dgAddress
            // 
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.MinimumWidth = 6;
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.Width = 125;
            // 
            // dgMobile
            // 
            this.dgMobile.HeaderText = "Mobile";
            this.dgMobile.MinimumWidth = 6;
            this.dgMobile.Name = "dgMobile";
            this.dgMobile.Width = 125;
            // 
            // dgDate
            // 
            this.dgDate.HeaderText = "Date";
            this.dgDate.MinimumWidth = 6;
            this.dgDate.Name = "dgDate";
            this.dgDate.Width = 125;
            // 
            // dgStatus
            // 
            this.dgStatus.HeaderText = "Status";
            this.dgStatus.MinimumWidth = 6;
            this.dgStatus.Name = "dgStatus";
            this.dgStatus.Width = 125;
            // 
            // dgDuration
            // 
            this.dgDuration.HeaderText = "Duration";
            this.dgDuration.MinimumWidth = 6;
            this.dgDuration.Name = "dgDuration";
            this.dgDuration.Width = 125;
            // 
            // dgRemarks
            // 
            this.dgRemarks.HeaderText = "Remarks";
            this.dgRemarks.MinimumWidth = 6;
            this.dgRemarks.Name = "dgRemarks";
            this.dgRemarks.Width = 125;
            // 
            // ViewCallDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewCallDetails";
            this.Text = "ViewCallDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRemarks;
    }
}