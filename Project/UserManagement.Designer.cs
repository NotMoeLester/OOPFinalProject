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
        private void InitializeComponent()
        {
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
            dataGridViewUserList.Location = new Point(101, 56);
            dataGridViewUserList.Name = "dataGridViewUserList";
            dataGridViewUserList.Size = new Size(584, 296);
            dataGridViewUserList.TabIndex = 0;
            // 
            // ButtonView
            // 
            ButtonView.Location = new Point(101, 387);
            ButtonView.Name = "ButtonView";
            ButtonView.Size = new Size(142, 44);
            ButtonView.TabIndex = 1;
            ButtonView.Text = "View";
            ButtonView.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(249, 387);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(142, 44);
            ButtonEdit.TabIndex = 2;
            ButtonEdit.Text = "Edit";
            ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(397, 387);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(142, 44);
            ButtonUpdate.TabIndex = 3;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += button3_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(543, 387);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(142, 44);
            ButtonDelete.TabIndex = 4;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 21);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 5;
            label1.Text = "List of Users";
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonUpdate);
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonView);
            Controls.Add(dataGridViewUserList);
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