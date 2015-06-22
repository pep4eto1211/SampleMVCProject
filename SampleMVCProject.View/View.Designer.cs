namespace SampleMVCProject.View
{
    partial class View
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.AddUserPanel = new System.Windows.Forms.Panel();
            this.addUserButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.AddUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(678, 329);
            this.dataGrid.TabIndex = 0;
            // 
            // AddUserPanel
            // 
            this.AddUserPanel.Controls.Add(this.errorBox);
            this.AddUserPanel.Controls.Add(this.addUserButton);
            this.AddUserPanel.Controls.Add(this.label3);
            this.AddUserPanel.Controls.Add(this.idBox);
            this.AddUserPanel.Controls.Add(this.label4);
            this.AddUserPanel.Controls.Add(this.ageBox);
            this.AddUserPanel.Controls.Add(this.label2);
            this.AddUserPanel.Controls.Add(this.departmentBox);
            this.AddUserPanel.Controls.Add(this.label1);
            this.AddUserPanel.Controls.Add(this.nameBox);
            this.AddUserPanel.Location = new System.Drawing.Point(12, 347);
            this.AddUserPanel.Name = "AddUserPanel";
            this.AddUserPanel.Size = new System.Drawing.Size(678, 54);
            this.AddUserPanel.TabIndex = 1;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(383, 24);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 8;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(308, 26);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(69, 20);
            this.idBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age:";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(308, 0);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(69, 20);
            this.ageBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department:";
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(75, 26);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(190, 20);
            this.departmentBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(75, 0);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(190, 20);
            this.nameBox.TabIndex = 0;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(SampleMVCProject.Model.Model);
            // 
            // errorBox
            // 
            this.errorBox.Location = new System.Drawing.Point(464, 4);
            this.errorBox.Multiline = true;
            this.errorBox.Name = "errorBox";
            this.errorBox.ReadOnly = true;
            this.errorBox.Size = new System.Drawing.Size(214, 47);
            this.errorBox.TabIndex = 9;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 405);
            this.Controls.Add(this.AddUserPanel);
            this.Controls.Add(this.dataGrid);
            this.Name = "View";
            this.Text = "View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.AddUserPanel.ResumeLayout(false);
            this.AddUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel AddUserPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.TextBox errorBox;

    }
}