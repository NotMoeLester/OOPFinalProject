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
            ButtonView = new Button();
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
            DataGridViewUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DataGridViewUserList.BackgroundColor = Color.White;
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
            ButtonView.BackColor = Color.DodgerBlue;
            ButtonView.FlatStyle = FlatStyle.Flat;
            ButtonView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonView.ForeColor = Color.White;
            ButtonView.Location = new Point(286, 499);
            ButtonView.Margin = new Padding(3, 4, 3, 4);
            ButtonView.Name = "ButtonView";
            ButtonView.Size = new Size(162, 59);
            ButtonView.TabIndex = 1;
            ButtonView.Text = "🔄 Refresh List";
            ButtonView.UseVisualStyleBackColor = false;
            ButtonView.Click += ButtonView_Click;
            // 
            // ButtonCreate
            // 
            ButtonCreate.BackColor = Color.Green;
            ButtonCreate.FlatStyle = FlatStyle.Flat;
            ButtonCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCreate.ForeColor = Color.White;
            ButtonCreate.Location = new Point(115, 499);
            ButtonCreate.Margin = new Padding(3, 4, 3, 4);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(162, 59);
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
            ButtonUpdate.Location = new Point(454, 499);
            ButtonUpdate.Margin = new Padding(3, 4, 3, 4);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(162, 59);
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
            ButtonDelete.Location = new Point(621, 499);
            ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(162, 59);
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
            label1.Location = new Point(115, 28);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 5;
            label1.Text = "List of Users";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(671, 440);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 144);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ButtonBack
            // 
            ButtonBack.BackgroundImage = Properties.Resources.left;
            ButtonBack.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonBack.Location = new Point(739, 24);
            ButtonBack.Margin = new Padding(3, 4, 3, 4);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(43, 43);
            ButtonBack.TabIndex = 7;
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonViewAccountInformation
            // 
            ButtonViewAccountInformation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonViewAccountInformation.Location = new Point(494, 24);
            ButtonViewAccountInformation.Margin = new Padding(3, 4, 3, 4);
            ButtonViewAccountInformation.Name = "ButtonViewAccountInformation";
            ButtonViewAccountInformation.Size = new Size(239, 41);
            ButtonViewAccountInformation.TabIndex = 8;
            ButtonViewAccountInformation.Text = "View Account Information";
            ButtonViewAccountInformation.UseVisualStyleBackColor = true;
            ButtonViewAccountInformation.Click += ButtonViewAccountInformation_Click_1;
            // 
            // AdminStudentManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Navy;
            ClientSize = new Size(914, 600);
            Controls.Add(ButtonViewAccountInformation);
            Controls.Add(ButtonBack);
            Controls.Add(label1);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonUpdate);
            Controls.Add(ButtonCreate);
            Controls.Add(ButtonView);
            Controls.Add(DataGridViewUserList);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminStudentManagement";
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
        private Button ButtonViewAccountInformation;
    }
}