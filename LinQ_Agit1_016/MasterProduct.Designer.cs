namespace LinQ_Agit1_016
{
	partial class MasterProduct
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
			this.dt = new System.Windows.Forms.DataGridView();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dateExpired = new System.Windows.Forms.DateTimePicker();
			this.cbColor = new System.Windows.Forms.ComboBox();
			this.txtDesign = new System.Windows.Forms.TextBox();
			this.txtItem = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtSearchDesign = new System.Windows.Forms.TextBox();
			this.txtSearchItem = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
			this.SuspendLayout();
			// 
			// dt
			// 
			this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dt.Location = new System.Drawing.Point(172, 469);
			this.dt.Margin = new System.Windows.Forms.Padding(2);
			this.dt.Name = "dt";
			this.dt.RowTemplate.Height = 24;
			this.dt.Size = new System.Drawing.Size(291, 110);
			this.dt.TabIndex = 25;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(331, 430);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(56, 19);
			this.btnDelete.TabIndex = 24;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(249, 430);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(56, 19);
			this.btnUpdate.TabIndex = 23;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(172, 430);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(56, 19);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(421, 99);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(56, 19);
			this.btnSearch.TabIndex = 21;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dateExpired
			// 
			this.dateExpired.Location = new System.Drawing.Point(249, 379);
			this.dateExpired.Margin = new System.Windows.Forms.Padding(2);
			this.dateExpired.Name = "dateExpired";
			this.dateExpired.Size = new System.Drawing.Size(151, 20);
			this.dateExpired.TabIndex = 20;
			// 
			// cbColor
			// 
			this.cbColor.FormattingEnabled = true;
			this.cbColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "White",
            "Green",
            "Yellow",
            "Black"});
			this.cbColor.Location = new System.Drawing.Point(249, 339);
			this.cbColor.Margin = new System.Windows.Forms.Padding(2);
			this.cbColor.Name = "cbColor";
			this.cbColor.Size = new System.Drawing.Size(92, 21);
			this.cbColor.TabIndex = 19;
			// 
			// txtDesign
			// 
			this.txtDesign.Location = new System.Drawing.Point(249, 302);
			this.txtDesign.Margin = new System.Windows.Forms.Padding(2);
			this.txtDesign.Name = "txtDesign";
			this.txtDesign.Size = new System.Drawing.Size(153, 20);
			this.txtDesign.TabIndex = 17;
			// 
			// txtItem
			// 
			this.txtItem.Location = new System.Drawing.Point(249, 256);
			this.txtItem.Margin = new System.Windows.Forms.Padding(2);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(153, 20);
			this.txtItem.TabIndex = 18;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(249, 209);
			this.txtID.Margin = new System.Windows.Forms.Padding(2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(153, 20);
			this.txtID.TabIndex = 16;
			// 
			// txtSearchDesign
			// 
			this.txtSearchDesign.Location = new System.Drawing.Point(249, 137);
			this.txtSearchDesign.Margin = new System.Windows.Forms.Padding(2);
			this.txtSearchDesign.Name = "txtSearchDesign";
			this.txtSearchDesign.Size = new System.Drawing.Size(153, 20);
			this.txtSearchDesign.TabIndex = 15;
			// 
			// txtSearchItem
			// 
			this.txtSearchItem.Location = new System.Drawing.Point(249, 101);
			this.txtSearchItem.Margin = new System.Windows.Forms.Padding(2);
			this.txtSearchItem.Name = "txtSearchItem";
			this.txtSearchItem.Size = new System.Drawing.Size(153, 20);
			this.txtSearchItem.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(142, 379);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Expired Date";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(142, 341);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Color";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(142, 302);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Design";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(142, 258);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Item Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(142, 214);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Product ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(142, 137);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Design";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(142, 101);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Item Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(288, 53);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "MASTER PRODUCT";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(407, 430);
			this.btnClose.Margin = new System.Windows.Forms.Padding(2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(56, 19);
			this.btnClose.TabIndex = 26;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// MasterProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 633);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dt);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.dateExpired);
			this.Controls.Add(this.cbColor);
			this.Controls.Add(this.txtDesign);
			this.Controls.Add(this.txtItem);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtSearchDesign);
			this.Controls.Add(this.txtSearchItem);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MasterProduct";
			this.Text = "Masters Product";
			this.Load += new System.EventHandler(this.MasterProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dt;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DateTimePicker dateExpired;
		private System.Windows.Forms.ComboBox cbColor;
		private System.Windows.Forms.TextBox txtDesign;
		private System.Windows.Forms.TextBox txtItem;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtSearchDesign;
		private System.Windows.Forms.TextBox txtSearchItem;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
	}
}