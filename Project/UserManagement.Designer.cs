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
            DataGridViewUserList = new DataGridView();
            ButtonView = new Button();
            ButtonCreate = new Button();
            ButtonUpdate = new Button();
            ButtonDelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewUserList).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewUserList
            // 
            DataGridViewUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewUserList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridViewUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewUserList.Location = new Point(115, 75);
            DataGridViewUserList.Margin = new Padding(3, 4, 3, 4);
            DataGridViewUserList.Name = "DataGridViewUserList";
            DataGridViewUserList.RowHeadersWidth = 51;
            DataGridViewUserList.Size = new Size(667, 395);
            DataGridViewUserList.TabIndex = 0;
            DataGridViewUserList.CellClick += DataGridViewUserList_CellClick_1;
            // 
            // ButtonView
            // 
            ButtonView.BackColor = Color.SteelBlue;
            ButtonView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonView.Location = new Point(286, 516);
            ButtonView.Margin = new Padding(3, 4, 3, 4);
            ButtonView.Name = "ButtonView";
            ButtonView.Size = new Size(162, 59);
            ButtonView.TabIndex = 1;
            ButtonView.Text = "View";
            ButtonView.UseVisualStyleBackColor = false;
            ButtonView.Click += ButtonView_Click;
            // 
            // ButtonCreate
            // 
            ButtonCreate.BackColor = Color.SteelBlue;
            ButtonCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCreate.Location = new Point(115, 516);
            ButtonCreate.Margin = new Padding(3, 4, 3, 4);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(162, 59);
            ButtonCreate.TabIndex = 2;
            ButtonCreate.Text = "Create";
            ButtonCreate.UseVisualStyleBackColor = false;
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
            ButtonUpdate.Click += ButtonUpdate_Click;
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
            ButtonDelete.Click += ButtonDelete_Click;
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
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Navy;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonUpdate);
            Controls.Add(ButtonCreate);
            Controls.Add(ButtonView);
            Controls.Add(DataGridViewUserList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserManagement";
            Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)DataGridViewUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewUserList;
        private Button ButtonView;
        private Button ButtonCreate;
        private Button ButtonUpdate;
        private Button ButtonDelete;
        private Label label1;
    }
}