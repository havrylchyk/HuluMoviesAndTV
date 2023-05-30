namespace HuluMoviesAndTV.WinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HulutabControl = new TabControl();
            TypesAndDirectors = new TabPage();
            groupBoxDirector = new GroupBox();
            label5 = new Label();
            UpdateDirectorbutton = new Button();
            DeleteDirectorbutton = new Button();
            AddDirectorbutton = new Button();
            label6 = new Label();
            DirectortextBox = new TextBox();
            TypegroupBox = new GroupBox();
            label4 = new Label();
            UpdateTypebutton = new Button();
            DeleteTypebutton = new Button();
            AddTypebutton = new Button();
            label3 = new Label();
            NameOfType = new TextBox();
            DirectordataGridView = new DataGridView();
            TypedataGridView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            HulutabControl.SuspendLayout();
            TypesAndDirectors.SuspendLayout();
            groupBoxDirector.SuspendLayout();
            TypegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DirectordataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TypedataGridView).BeginInit();
            SuspendLayout();
            // 
            // HulutabControl
            // 
            HulutabControl.Controls.Add(TypesAndDirectors);
            HulutabControl.Controls.Add(tabPage2);
            HulutabControl.Controls.Add(tabPage1);
            HulutabControl.Controls.Add(tabPage3);
            HulutabControl.Dock = DockStyle.Fill;
            HulutabControl.Location = new Point(0, 0);
            HulutabControl.Name = "HulutabControl";
            HulutabControl.SelectedIndex = 0;
            HulutabControl.Size = new Size(1356, 639);
            HulutabControl.TabIndex = 0;
            // 
            // TypesAndDirectors
            // 
            TypesAndDirectors.Controls.Add(groupBoxDirector);
            TypesAndDirectors.Controls.Add(TypegroupBox);
            TypesAndDirectors.Controls.Add(DirectordataGridView);
            TypesAndDirectors.Controls.Add(TypedataGridView);
            TypesAndDirectors.Controls.Add(label2);
            TypesAndDirectors.Controls.Add(label1);
            TypesAndDirectors.Location = new Point(4, 29);
            TypesAndDirectors.Name = "TypesAndDirectors";
            TypesAndDirectors.Padding = new Padding(3);
            TypesAndDirectors.Size = new Size(1348, 606);
            TypesAndDirectors.TabIndex = 0;
            TypesAndDirectors.Text = "Types and Directors";
            TypesAndDirectors.UseVisualStyleBackColor = true;
            // 
            // groupBoxDirector
            // 
            groupBoxDirector.Controls.Add(label5);
            groupBoxDirector.Controls.Add(UpdateDirectorbutton);
            groupBoxDirector.Controls.Add(DeleteDirectorbutton);
            groupBoxDirector.Controls.Add(AddDirectorbutton);
            groupBoxDirector.Controls.Add(label6);
            groupBoxDirector.Controls.Add(DirectortextBox);
            groupBoxDirector.Location = new Point(507, 419);
            groupBoxDirector.Name = "groupBoxDirector";
            groupBoxDirector.Size = new Size(678, 177);
            groupBoxDirector.TabIndex = 6;
            groupBoxDirector.TabStop = false;
            groupBoxDirector.Text = "Working with director";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(367, 70);
            label5.Name = "label5";
            label5.Size = new Size(155, 20);
            label5.TabIndex = 5;
            label5.Text = "*choose row fo delete";
            // 
            // UpdateDirectorbutton
            // 
            UpdateDirectorbutton.BackColor = Color.DeepSkyBlue;
            UpdateDirectorbutton.Location = new Point(118, 103);
            UpdateDirectorbutton.Name = "UpdateDirectorbutton";
            UpdateDirectorbutton.Size = new Size(134, 29);
            UpdateDirectorbutton.TabIndex = 4;
            UpdateDirectorbutton.Text = "Updata";
            UpdateDirectorbutton.UseVisualStyleBackColor = false;
            UpdateDirectorbutton.Click += UpdateDirectorbutton_Click;
            // 
            // DeleteDirectorbutton
            // 
            DeleteDirectorbutton.BackColor = Color.DeepSkyBlue;
            DeleteDirectorbutton.Location = new Point(367, 98);
            DeleteDirectorbutton.Name = "DeleteDirectorbutton";
            DeleteDirectorbutton.Size = new Size(94, 29);
            DeleteDirectorbutton.TabIndex = 3;
            DeleteDirectorbutton.Text = "Delete";
            DeleteDirectorbutton.UseVisualStyleBackColor = false;
            DeleteDirectorbutton.Click += DeleteDirectorbutton_Click;
            // 
            // AddDirectorbutton
            // 
            AddDirectorbutton.BackColor = Color.DeepSkyBlue;
            AddDirectorbutton.Location = new Point(18, 103);
            AddDirectorbutton.Name = "AddDirectorbutton";
            AddDirectorbutton.Size = new Size(94, 29);
            AddDirectorbutton.TabIndex = 2;
            AddDirectorbutton.Text = "Add";
            AddDirectorbutton.UseVisualStyleBackColor = false;
            AddDirectorbutton.Click += AddDirectorbutton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 36);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 1;
            label6.Text = "Name";
            // 
            // DirectortextBox
            // 
            DirectortextBox.Location = new Point(18, 70);
            DirectortextBox.Name = "DirectortextBox";
            DirectortextBox.Size = new Size(234, 27);
            DirectortextBox.TabIndex = 0;
            // 
            // TypegroupBox
            // 
            TypegroupBox.Controls.Add(label4);
            TypegroupBox.Controls.Add(UpdateTypebutton);
            TypegroupBox.Controls.Add(DeleteTypebutton);
            TypegroupBox.Controls.Add(AddTypebutton);
            TypegroupBox.Controls.Add(label3);
            TypegroupBox.Controls.Add(NameOfType);
            TypegroupBox.Location = new Point(11, 304);
            TypegroupBox.Name = "TypegroupBox";
            TypegroupBox.Size = new Size(413, 292);
            TypegroupBox.TabIndex = 4;
            TypegroupBox.TabStop = false;
            TypegroupBox.Text = "Working with type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(20, 222);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 5;
            label4.Text = "*choose row fo delete";
            // 
            // UpdateTypebutton
            // 
            UpdateTypebutton.BackColor = Color.FromArgb(128, 128, 255);
            UpdateTypebutton.Location = new Point(118, 103);
            UpdateTypebutton.Name = "UpdateTypebutton";
            UpdateTypebutton.Size = new Size(134, 29);
            UpdateTypebutton.TabIndex = 4;
            UpdateTypebutton.Text = "Updata";
            UpdateTypebutton.UseVisualStyleBackColor = false;
            UpdateTypebutton.Click += UpdateTypebutton_Click;
            // 
            // DeleteTypebutton
            // 
            DeleteTypebutton.BackColor = Color.FromArgb(128, 128, 255);
            DeleteTypebutton.Location = new Point(18, 244);
            DeleteTypebutton.Name = "DeleteTypebutton";
            DeleteTypebutton.Size = new Size(94, 29);
            DeleteTypebutton.TabIndex = 3;
            DeleteTypebutton.Text = "Delete";
            DeleteTypebutton.UseVisualStyleBackColor = false;
            DeleteTypebutton.Click += DeleteTypebutton_Click;
            // 
            // AddTypebutton
            // 
            AddTypebutton.BackColor = Color.FromArgb(128, 128, 255);
            AddTypebutton.Location = new Point(18, 103);
            AddTypebutton.Name = "AddTypebutton";
            AddTypebutton.Size = new Size(94, 29);
            AddTypebutton.TabIndex = 2;
            AddTypebutton.Text = "Add";
            AddTypebutton.UseVisualStyleBackColor = false;
            AddTypebutton.Click += AddTypebutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 36);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // NameOfType
            // 
            NameOfType.Location = new Point(18, 70);
            NameOfType.Name = "NameOfType";
            NameOfType.Size = new Size(234, 27);
            NameOfType.TabIndex = 0;
            // 
            // DirectordataGridView
            // 
            DirectordataGridView.BackgroundColor = Color.DeepSkyBlue;
            DirectordataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DirectordataGridView.Location = new Point(491, 39);
            DirectordataGridView.Name = "DirectordataGridView";
            DirectordataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            DirectordataGridView.RowTemplate.Height = 29;
            DirectordataGridView.Size = new Size(720, 362);
            DirectordataGridView.TabIndex = 3;
            // 
            // TypedataGridView
            // 
            TypedataGridView.BackgroundColor = Color.FromArgb(128, 128, 255);
            TypedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TypedataGridView.GridColor = SystemColors.MenuText;
            TypedataGridView.Location = new Point(11, 39);
            TypedataGridView.Name = "TypedataGridView";
            TypedataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            TypedataGridView.RowTemplate.Height = 29;
            TypedataGridView.Size = new Size(413, 249);
            TypedataGridView.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(491, 13);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 1;
            label2.Text = "Director";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1348, 606);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1348, 606);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1348, 606);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 639);
            Controls.Add(HulutabControl);
            Name = "Form1";
            Text = "HuluTV";
            Load += Form1_Load;
            HulutabControl.ResumeLayout(false);
            TypesAndDirectors.ResumeLayout(false);
            TypesAndDirectors.PerformLayout();
            groupBoxDirector.ResumeLayout(false);
            groupBoxDirector.PerformLayout();
            TypegroupBox.ResumeLayout(false);
            TypegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DirectordataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)TypedataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl HulutabControl;
        private TabPage TypesAndDirectors;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private DataGridView DirectordataGridView;
        private DataGridView TypedataGridView;
        private GroupBox TypegroupBox;
        private Label label3;
        private TextBox NameOfType;
        private Button AddTypebutton;
        private Button DeleteTypebutton;
        private Label label4;
        private Button UpdateTypebutton;
        private GroupBox groupBoxDirector;
        private Label label5;
        private Button UpdateDirectorbutton;
        private Button DeleteDirectorbutton;
        private Button AddDirectorbutton;
        private Label label6;
        private TextBox DirectortextBox;
        private TabPage tabPage1;
        private TabPage tabPage3;
    }
}