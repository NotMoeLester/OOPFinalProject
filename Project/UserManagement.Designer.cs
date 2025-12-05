namespace Project
{
    partial class UserManagement
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
        private void InitializeComponent() {
            dataGridViewUserList = new DataGridView();
            ButtonView = new Button();
            ButtonEdit = new Button();
            ButtonUpdate = new Button();
            ButtonDelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserList).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUserList
            // 
            dataGridViewUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserList.Location = new Point(115, 75);
            dataGridViewUserList.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUserList.Name = "dataGridViewUserList";
            dataGridViewUserList.RowHeadersWidth = 51;
            dataGridViewUserList.Size = new Size(667, 395);
            dataGridViewUserList.TabIndex = 0;
            dataGridViewUserList.CellContentClick += dataGridViewUserList_CellContentClick;
            // 
            // ButtonView
            // 
            ButtonView.BackColor = Color.SteelBlue;
            ButtonView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonView.Location = new Point(115, 516);
            ButtonView.Margin = new Padding(3, 4, 3, 4);
            ButtonView.Name = "ButtonView";
            ButtonView.Size = new Size(162, 59);
            ButtonView.TabIndex = 1;
            ButtonView.Text = "View";
            ButtonView.UseVisualStyleBackColor = false;
            // 
            // ButtonEdit
            // 
            ButtonEdit.BackColor = Color.SteelBlue;
            ButtonEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEdit.Location = new Point(285, 516);
            ButtonEdit.Margin = new Padding(3, 4, 3, 4);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(162, 59);
            ButtonEdit.TabIndex = 2;
            ButtonEdit.Text = "Edit";
            ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.BackColor = Color.SteelBlue;
            ButtonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonUpdate.ForeColor = Color.Black;
            ButtonUpdate.Location = new Point(454, 516);
            ButtonUpdate.Margin = new Padding(3, 4, 3, 4);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(162, 59);
            ButtonUpdate.TabIndex = 3;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = false;
            ButtonUpdate.Click += button3_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = Color.DarkRed;
            ButtonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDelete.ForeColor = Color.White;
            ButtonDelete.Location = new Point(621, 516);
            ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(162, 59);
            ButtonDelete.TabIndex = 4;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(115, 28);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 5;
            label1.Text = "List of Users";
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonUpdate);
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonView);
            Controls.Add(dataGridViewUserList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUserList;
        private Button ButtonView;
        private Button ButtonEdit;
        private Button ButtonUpdate;
        private Button ButtonDelete;
        private Label label1;
    }
}