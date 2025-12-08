namespace Project
{
    partial class AdminUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserManagement));
            DataGridViewUserList = new DataGridView();
            ButtonView = new Button();
            ButtonCreate = new Button();
            ButtonUpdate = new Button();
            ButtonDelete = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ButtonBack = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewUserList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewUserList
            // 
            DataGridViewUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewUserList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridViewUserList.BackgroundColor = Color.White;
            DataGridViewUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewUserList.Location = new Point(101, 56);
            DataGridViewUserList.Name = "DataGridViewUserList";
            DataGridViewUserList.RowHeadersWidth = 51;
            DataGridViewUserList.Size = new Size(584, 296);
            DataGridViewUserList.TabIndex = 0;
            DataGridViewUserList.CellClick += DataGridViewUserList_CellClick_1;
            DataGridViewUserList.CellContentClick += DataGridViewUserList_CellContentClick;
            // 
            // ButtonView
            // 
            ButtonView.BackColor = Color.Navy;
            ButtonView.FlatStyle = FlatStyle.Flat;
            ButtonView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonView.ForeColor = Color.White;
            ButtonView.Location = new Point(250, 374);
            ButtonView.Name = "ButtonView";
            ButtonView.Size = new Size(142, 44);
            ButtonView.TabIndex = 1;
            ButtonView.Text = "View";
            ButtonView.UseVisualStyleBackColor = false;
            ButtonView.Click += ButtonView_Click;
            // 
            // ButtonCreate
            // 
            ButtonCreate.BackColor = Color.Navy;
            ButtonCreate.FlatStyle = FlatStyle.Flat;
            ButtonCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCreate.ForeColor = Color.White;
            ButtonCreate.Location = new Point(101, 374);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(142, 44);
            ButtonCreate.TabIndex = 2;
            ButtonCreate.Text = "Create";
            ButtonCreate.UseVisualStyleBackColor = false;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.BackColor = Color.Navy;
            ButtonUpdate.FlatStyle = FlatStyle.Flat;
            ButtonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonUpdate.ForeColor = Color.White;
            ButtonUpdate.Location = new Point(397, 374);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(142, 44);
            ButtonUpdate.TabIndex = 3;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = false;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = Color.Firebrick;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDelete.ForeColor = Color.White;
            ButtonDelete.Location = new Point(543, 374);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(142, 44);
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
            label1.Location = new Point(101, 21);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 5;
            label1.Text = "List of Users";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(587, 330);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 108);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ButtonBack
            // 
            ButtonBack.BackgroundImage = Properties.Resources.left;
            ButtonBack.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonBack.Location = new Point(647, 18);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(38, 32);
            ButtonBack.TabIndex = 7;
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(498, 18);
            button1.Name = "button1";
            button1.Size = new Size(143, 31);
            button1.TabIndex = 8;
            button1.Text = "View Account";
            button1.UseVisualStyleBackColor = true;
            // 
            // AdminUserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ButtonBack);
            Controls.Add(label1);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonUpdate);
            Controls.Add(ButtonCreate);
            Controls.Add(ButtonView);
            Controls.Add(DataGridViewUserList);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AdminUserManagement";
            Load += AdminUserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewUserList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button ButtonBack;
        private Button button1;
    }
}