namespace Project
{
    partial class AdminStudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStudentManagement));
            DataGridViewUserList = new DataGridView();
            ButtonRefresh = new Button();
            ButtonCreate = new Button();
            ButtonUpdate = new Button();
            ButtonDelete = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ButtonBack = new Button();
            ButtonViewAccountInformation = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewUserList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewUserList
            // 
            DataGridViewUserList.AllowUserToAddRows = false;
            DataGridViewUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DataGridViewUserList.BackgroundColor = Color.White;
            DataGridViewUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewUserList.ImeMode = ImeMode.NoControl;
            DataGridViewUserList.Location = new Point(101, 56);
            DataGridViewUserList.Name = "DataGridViewUserList";
            DataGridViewUserList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewUserList.Size = new Size(584, 296);
            DataGridViewUserList.TabIndex = 0;
            DataGridViewUserList.CellClick += DataGridViewUserList_CellClick_1;
            // 
            // ButtonRefresh
            // 
            ButtonRefresh.BackColor = Color.DodgerBlue;
            ButtonRefresh.FlatStyle = FlatStyle.Flat;
            ButtonRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonRefresh.ForeColor = Color.White;
            ButtonRefresh.Location = new Point(250, 374);
            ButtonRefresh.Name = "ButtonRefresh";
            ButtonRefresh.Size = new Size(142, 44);
            ButtonRefresh.TabIndex = 1;
            ButtonRefresh.Text = "🔄 Refresh List";
            ButtonRefresh.UseVisualStyleBackColor = false;
            ButtonRefresh.Click += ButtonRefresh_Click;
            // 
            // ButtonCreate
            // 
            ButtonCreate.BackColor = Color.Green;
            ButtonCreate.FlatStyle = FlatStyle.Flat;
            ButtonCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCreate.ForeColor = Color.White;
            ButtonCreate.Location = new Point(101, 374);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(142, 44);
            ButtonCreate.TabIndex = 2;
            ButtonCreate.Text = "+ Add New User";
            ButtonCreate.UseVisualStyleBackColor = false;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.BackColor = Color.Orange;
            ButtonUpdate.FlatStyle = FlatStyle.Flat;
            ButtonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonUpdate.ForeColor = Color.White;
            ButtonUpdate.Location = new Point(397, 374);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(142, 44);
            ButtonUpdate.TabIndex = 3;
            ButtonUpdate.Text = "✎ Update Selected";
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
            ButtonDelete.Text = "🗑 Delete Selected";
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
            // ButtonViewAccountInformation
            // 
            ButtonViewAccountInformation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonViewAccountInformation.Location = new Point(432, 18);
            ButtonViewAccountInformation.Name = "ButtonViewAccountInformation";
            ButtonViewAccountInformation.Size = new Size(209, 31);
            ButtonViewAccountInformation.TabIndex = 8;
            ButtonViewAccountInformation.Text = "View Account Information";
            ButtonViewAccountInformation.UseVisualStyleBackColor = true;
            ButtonViewAccountInformation.Click += ButtonViewAccountInformation_Click_1;
            // 
            // AdminStudentManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonViewAccountInformation);
            Controls.Add(ButtonBack);
            Controls.Add(label1);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonUpdate);
            Controls.Add(ButtonCreate);
            Controls.Add(ButtonRefresh);
            Controls.Add(DataGridViewUserList);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AdminStudentManagement";
            Load += AdminUserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewUserList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewUserList;
        private Button ButtonRefresh;
        private Button ButtonCreate;
        private Button ButtonUpdate;
        private Button ButtonDelete;
        private Label label1;
        private PictureBox pictureBox1;
        private Button ButtonBack;
        private Button ButtonViewAccountInformation;
    }
}