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
            groupBoxReleaseYear = new GroupBox();
            label13 = new Label();
            UpdateReleaseYearbutton = new Button();
            DeleteReleaseYearbutton = new Button();
            AddReleaseYearbutton = new Button();
            label14 = new Label();
            ReleaseYeartextBox = new TextBox();
            groupBox1 = new GroupBox();
            groupBoxRating = new GroupBox();
            label11 = new Label();
            UpdataRatingbutton = new Button();
            DeleteRatingbutton = new Button();
            AddRatingbutton = new Button();
            label12 = new Label();
            RatingtextBox = new TextBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label10 = new Label();
            textBox1 = new TextBox();
            ReleaseYeardataGridView = new DataGridView();
            RatingdataGridView = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            label19 = new Label();
            UpdateListenedbutton = new Button();
            DeleteListenedbutton = new Button();
            AddListenedbutton = new Button();
            label20 = new Label();
            ListenedtextBox = new TextBox();
            CountrygroupBox = new GroupBox();
            label17 = new Label();
            UpdateCountrybutton = new Button();
            DeleteCountrybutton = new Button();
            AddCountrybutton = new Button();
            label18 = new Label();
            CountrytextBox = new TextBox();
            ListeneddataGridView = new DataGridView();
            CountriesdataGridView = new DataGridView();
            label15 = new Label();
            label16 = new Label();
            tabPage3 = new TabPage();
            HulutabControl.SuspendLayout();
            TypesAndDirectors.SuspendLayout();
            groupBoxDirector.SuspendLayout();
            TypegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DirectordataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TypedataGridView).BeginInit();
            tabPage2.SuspendLayout();
            groupBoxReleaseYear.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReleaseYeardataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RatingdataGridView).BeginInit();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            CountrygroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListeneddataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountriesdataGridView).BeginInit();
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
            UpdateTypebutton.Click += UpdateTypebutton_Click_1;
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
            tabPage2.Controls.Add(groupBoxReleaseYear);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(ReleaseYeardataGridView);
            tabPage2.Controls.Add(RatingdataGridView);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1348, 606);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rating and ReleaseYear";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxReleaseYear
            // 
            groupBoxReleaseYear.Controls.Add(label13);
            groupBoxReleaseYear.Controls.Add(UpdateReleaseYearbutton);
            groupBoxReleaseYear.Controls.Add(DeleteReleaseYearbutton);
            groupBoxReleaseYear.Controls.Add(AddReleaseYearbutton);
            groupBoxReleaseYear.Controls.Add(label14);
            groupBoxReleaseYear.Controls.Add(ReleaseYeartextBox);
            groupBoxReleaseYear.Location = new Point(488, 291);
            groupBoxReleaseYear.Name = "groupBoxReleaseYear";
            groupBoxReleaseYear.Size = new Size(420, 292);
            groupBoxReleaseYear.TabIndex = 9;
            groupBoxReleaseYear.TabStop = false;
            groupBoxReleaseYear.Text = "Working with Release Year";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(20, 222);
            label13.Name = "label13";
            label13.Size = new Size(155, 20);
            label13.TabIndex = 5;
            label13.Text = "*choose row fo delete";
            // 
            // UpdateReleaseYearbutton
            // 
            UpdateReleaseYearbutton.BackColor = Color.Tomato;
            UpdateReleaseYearbutton.Location = new Point(118, 103);
            UpdateReleaseYearbutton.Name = "UpdateReleaseYearbutton";
            UpdateReleaseYearbutton.Size = new Size(134, 29);
            UpdateReleaseYearbutton.TabIndex = 4;
            UpdateReleaseYearbutton.Text = "Updata";
            UpdateReleaseYearbutton.UseVisualStyleBackColor = false;
            UpdateReleaseYearbutton.Click += UpdataReleaseYearbutton_Click;
            // 
            // DeleteReleaseYearbutton
            // 
            DeleteReleaseYearbutton.BackColor = Color.Tomato;
            DeleteReleaseYearbutton.Location = new Point(18, 244);
            DeleteReleaseYearbutton.Name = "DeleteReleaseYearbutton";
            DeleteReleaseYearbutton.Size = new Size(94, 29);
            DeleteReleaseYearbutton.TabIndex = 3;
            DeleteReleaseYearbutton.Text = "Delete";
            DeleteReleaseYearbutton.UseVisualStyleBackColor = false;
            DeleteReleaseYearbutton.Click += DeleteReleaseYearbutton_Click;
            // 
            // AddReleaseYearbutton
            // 
            AddReleaseYearbutton.BackColor = Color.Tomato;
            AddReleaseYearbutton.Location = new Point(18, 103);
            AddReleaseYearbutton.Name = "AddReleaseYearbutton";
            AddReleaseYearbutton.Size = new Size(94, 29);
            AddReleaseYearbutton.TabIndex = 2;
            AddReleaseYearbutton.Text = "Add";
            AddReleaseYearbutton.UseVisualStyleBackColor = false;
            AddReleaseYearbutton.Click += AddReleaseYearbutton_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 36);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 1;
            label14.Text = "Name";
            // 
            // ReleaseYeartextBox
            // 
            ReleaseYeartextBox.Location = new Point(18, 70);
            ReleaseYeartextBox.Name = "ReleaseYeartextBox";
            ReleaseYeartextBox.Size = new Size(234, 27);
            ReleaseYeartextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBoxRating);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(8, 291);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 292);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Working with Rating";
            // 
            // groupBoxRating
            // 
            groupBoxRating.Controls.Add(label11);
            groupBoxRating.Controls.Add(UpdataRatingbutton);
            groupBoxRating.Controls.Add(DeleteRatingbutton);
            groupBoxRating.Controls.Add(AddRatingbutton);
            groupBoxRating.Controls.Add(label12);
            groupBoxRating.Controls.Add(RatingtextBox);
            groupBoxRating.Location = new Point(0, 0);
            groupBoxRating.Name = "groupBoxRating";
            groupBoxRating.Size = new Size(443, 292);
            groupBoxRating.TabIndex = 8;
            groupBoxRating.TabStop = false;
            groupBoxRating.Text = "Working with Rating";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(20, 222);
            label11.Name = "label11";
            label11.Size = new Size(155, 20);
            label11.TabIndex = 5;
            label11.Text = "*choose row fo delete";
            // 
            // UpdataRatingbutton
            // 
            UpdataRatingbutton.BackColor = Color.LimeGreen;
            UpdataRatingbutton.Location = new Point(118, 103);
            UpdataRatingbutton.Name = "UpdataRatingbutton";
            UpdataRatingbutton.Size = new Size(134, 29);
            UpdataRatingbutton.TabIndex = 4;
            UpdataRatingbutton.Text = "Updata";
            UpdataRatingbutton.UseVisualStyleBackColor = false;
            UpdataRatingbutton.Click += UpdataRatingbutton_Click;
            // 
            // DeleteRatingbutton
            // 
            DeleteRatingbutton.BackColor = Color.LimeGreen;
            DeleteRatingbutton.Location = new Point(18, 244);
            DeleteRatingbutton.Name = "DeleteRatingbutton";
            DeleteRatingbutton.Size = new Size(94, 29);
            DeleteRatingbutton.TabIndex = 3;
            DeleteRatingbutton.Text = "Delete";
            DeleteRatingbutton.UseVisualStyleBackColor = false;
            DeleteRatingbutton.Click += DeleteRatingbutton_Click;
            // 
            // AddRatingbutton
            // 
            AddRatingbutton.BackColor = Color.LimeGreen;
            AddRatingbutton.Location = new Point(18, 103);
            AddRatingbutton.Name = "AddRatingbutton";
            AddRatingbutton.Size = new Size(94, 29);
            AddRatingbutton.TabIndex = 2;
            AddRatingbutton.Text = "Add";
            AddRatingbutton.UseVisualStyleBackColor = false;
            AddRatingbutton.Click += AddRatingbutton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 36);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 1;
            label12.Text = "Name";
            // 
            // RatingtextBox
            // 
            RatingtextBox.Location = new Point(18, 70);
            RatingtextBox.Name = "RatingtextBox";
            RatingtextBox.Size = new Size(234, 27);
            RatingtextBox.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(20, 222);
            label9.Name = "label9";
            label9.Size = new Size(155, 20);
            label9.TabIndex = 5;
            label9.Text = "*choose row fo delete";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(118, 103);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 4;
            button1.Text = "Updata";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Location = new Point(18, 244);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Location = new Point(18, 103);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 36);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 1;
            label10.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 0;
            // 
            // ReleaseYeardataGridView
            // 
            ReleaseYeardataGridView.BackgroundColor = Color.Tomato;
            ReleaseYeardataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReleaseYeardataGridView.Location = new Point(488, 36);
            ReleaseYeardataGridView.Name = "ReleaseYeardataGridView";
            ReleaseYeardataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            ReleaseYeardataGridView.RowTemplate.Height = 29;
            ReleaseYeardataGridView.Size = new Size(425, 249);
            ReleaseYeardataGridView.TabIndex = 7;
            // 
            // RatingdataGridView
            // 
            RatingdataGridView.BackgroundColor = Color.LimeGreen;
            RatingdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RatingdataGridView.GridColor = SystemColors.MenuText;
            RatingdataGridView.Location = new Point(8, 36);
            RatingdataGridView.Name = "RatingdataGridView";
            RatingdataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            RatingdataGridView.RowTemplate.Height = 29;
            RatingdataGridView.Size = new Size(443, 249);
            RatingdataGridView.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(488, 10);
            label7.Name = "label7";
            label7.Size = new Size(154, 23);
            label7.TabIndex = 5;
            label7.Text = "Release Year";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(8, 10);
            label8.Name = "label8";
            label8.Size = new Size(82, 23);
            label8.TabIndex = 4;
            label8.Text = "Rating";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(CountrygroupBox);
            tabPage1.Controls.Add(ListeneddataGridView);
            tabPage1.Controls.Add(CountriesdataGridView);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label16);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1348, 606);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "County And Listened";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(UpdateListenedbutton);
            groupBox2.Controls.Add(DeleteListenedbutton);
            groupBox2.Controls.Add(AddListenedbutton);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(ListenedtextBox);
            groupBox2.Location = new Point(617, 292);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(513, 292);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Working with Listened";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Red;
            label19.Location = new Point(20, 222);
            label19.Name = "label19";
            label19.Size = new Size(155, 20);
            label19.TabIndex = 5;
            label19.Text = "*choose row fo delete";
            // 
            // UpdateListenedbutton
            // 
            UpdateListenedbutton.BackColor = Color.Maroon;
            UpdateListenedbutton.ForeColor = SystemColors.Window;
            UpdateListenedbutton.Location = new Point(118, 103);
            UpdateListenedbutton.Name = "UpdateListenedbutton";
            UpdateListenedbutton.Size = new Size(134, 29);
            UpdateListenedbutton.TabIndex = 4;
            UpdateListenedbutton.Text = "Updata";
            UpdateListenedbutton.UseVisualStyleBackColor = false;
            UpdateListenedbutton.Click += UpdateListenedbutton_Click;
            // 
            // DeleteListenedbutton
            // 
            DeleteListenedbutton.BackColor = Color.Maroon;
            DeleteListenedbutton.ForeColor = SystemColors.Window;
            DeleteListenedbutton.Location = new Point(18, 244);
            DeleteListenedbutton.Name = "DeleteListenedbutton";
            DeleteListenedbutton.Size = new Size(94, 29);
            DeleteListenedbutton.TabIndex = 3;
            DeleteListenedbutton.Text = "Delete";
            DeleteListenedbutton.UseVisualStyleBackColor = false;
            DeleteListenedbutton.Click += this.DeleteListenedbutton_Click;
            // 
            // AddListenedbutton
            // 
            AddListenedbutton.BackColor = Color.Maroon;
            AddListenedbutton.ForeColor = SystemColors.Window;
            AddListenedbutton.Location = new Point(18, 103);
            AddListenedbutton.Name = "AddListenedbutton";
            AddListenedbutton.Size = new Size(94, 29);
            AddListenedbutton.TabIndex = 2;
            AddListenedbutton.Text = "Add";
            AddListenedbutton.UseVisualStyleBackColor = false;
            AddListenedbutton.Click += AddListenedbutton_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(18, 36);
            label20.Name = "label20";
            label20.Size = new Size(49, 20);
            label20.TabIndex = 1;
            label20.Text = "Name";
            // 
            // ListenedtextBox
            // 
            ListenedtextBox.Location = new Point(18, 70);
            ListenedtextBox.Name = "ListenedtextBox";
            ListenedtextBox.Size = new Size(234, 27);
            ListenedtextBox.TabIndex = 0;
            // 
            // CountrygroupBox
            // 
            CountrygroupBox.Controls.Add(label17);
            CountrygroupBox.Controls.Add(UpdateCountrybutton);
            CountrygroupBox.Controls.Add(DeleteCountrybutton);
            CountrygroupBox.Controls.Add(AddCountrybutton);
            CountrygroupBox.Controls.Add(label18);
            CountrygroupBox.Controls.Add(CountrytextBox);
            CountrygroupBox.Location = new Point(8, 292);
            CountrygroupBox.Name = "CountrygroupBox";
            CountrygroupBox.Size = new Size(513, 292);
            CountrygroupBox.TabIndex = 12;
            CountrygroupBox.TabStop = false;
            CountrygroupBox.Text = "Working with Country";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(20, 222);
            label17.Name = "label17";
            label17.Size = new Size(155, 20);
            label17.TabIndex = 5;
            label17.Text = "*choose row fo delete";
            // 
            // UpdateCountrybutton
            // 
            UpdateCountrybutton.BackColor = Color.Violet;
            UpdateCountrybutton.Location = new Point(118, 103);
            UpdateCountrybutton.Name = "UpdateCountrybutton";
            UpdateCountrybutton.Size = new Size(134, 29);
            UpdateCountrybutton.TabIndex = 4;
            UpdateCountrybutton.Text = "Updata";
            UpdateCountrybutton.UseVisualStyleBackColor = false;
            UpdateCountrybutton.Click += UpdateCountrybutton_Click;
            // 
            // DeleteCountrybutton
            // 
            DeleteCountrybutton.BackColor = Color.Violet;
            DeleteCountrybutton.Location = new Point(18, 244);
            DeleteCountrybutton.Name = "DeleteCountrybutton";
            DeleteCountrybutton.Size = new Size(94, 29);
            DeleteCountrybutton.TabIndex = 3;
            DeleteCountrybutton.Text = "Delete";
            DeleteCountrybutton.UseVisualStyleBackColor = false;
            DeleteCountrybutton.Click += DeleteCountrybutton_Click;
            // 
            // AddCountrybutton
            // 
            AddCountrybutton.BackColor = Color.Violet;
            AddCountrybutton.Location = new Point(18, 103);
            AddCountrybutton.Name = "AddCountrybutton";
            AddCountrybutton.Size = new Size(94, 29);
            AddCountrybutton.TabIndex = 2;
            AddCountrybutton.Text = "Add";
            AddCountrybutton.UseVisualStyleBackColor = false;
            AddCountrybutton.Click += AddCountrybutton_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 36);
            label18.Name = "label18";
            label18.Size = new Size(49, 20);
            label18.TabIndex = 1;
            label18.Text = "Name";
            // 
            // CountrytextBox
            // 
            CountrytextBox.Location = new Point(18, 70);
            CountrytextBox.Name = "CountrytextBox";
            CountrytextBox.Size = new Size(234, 27);
            CountrytextBox.TabIndex = 0;
            // 
            // ListeneddataGridView
            // 
            ListeneddataGridView.BackgroundColor = Color.Maroon;
            ListeneddataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListeneddataGridView.Location = new Point(613, 37);
            ListeneddataGridView.Name = "ListeneddataGridView";
            ListeneddataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            ListeneddataGridView.RowTemplate.Height = 29;
            ListeneddataGridView.Size = new Size(517, 249);
            ListeneddataGridView.TabIndex = 11;
            // 
            // CountriesdataGridView
            // 
            CountriesdataGridView.BackgroundColor = Color.Violet;
            CountriesdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CountriesdataGridView.GridColor = SystemColors.MenuText;
            CountriesdataGridView.Location = new Point(8, 37);
            CountriesdataGridView.Name = "CountriesdataGridView";
            CountriesdataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            CountriesdataGridView.RowTemplate.Height = 29;
            CountriesdataGridView.Size = new Size(513, 249);
            CountriesdataGridView.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(613, 11);
            label15.Name = "label15";
            label15.Size = new Size(142, 23);
            label15.TabIndex = 9;
            label15.Text = "Listened In";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(8, 11);
            label16.Name = "label16";
            label16.Size = new Size(106, 23);
            label16.TabIndex = 8;
            label16.Text = "Counties";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBoxReleaseYear.ResumeLayout(false);
            groupBoxReleaseYear.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxRating.ResumeLayout(false);
            groupBoxRating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReleaseYeardataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)RatingdataGridView).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            CountrygroupBox.ResumeLayout(false);
            CountrygroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListeneddataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountriesdataGridView).EndInit();
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
        private DataGridView ReleaseYeardataGridView;
        private DataGridView RatingdataGridView;
        private Label label7;
        private Label label8;
        private GroupBox groupBoxReleaseYear;
        private Label label13;
        private Button UpdateReleaseYearbutton;
        private Button DeleteReleaseYearbutton;
        private Button AddReleaseYearbutton;
        private Label label14;
        private TextBox ReleaseYeartextBox;
        private GroupBox groupBox1;
        private GroupBox groupBoxRating;
        private Label label11;
        private Button UpdataRatingbutton;
        private Button DeleteRatingbutton;
        private Button AddRatingbutton;
        private Label label12;
        private TextBox RatingtextBox;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label10;
        private TextBox textBox1;
        private DataGridView ListeneddataGridView;
        private DataGridView CountriesdataGridView;
        private Label label15;
        private Label label16;
        private GroupBox CountrygroupBox;
        private Label label17;
        private Button UpdateCountrybutton;
        private Button DeleteCountrybutton;
        private Button AddCountrybutton;
        private Label label18;
        private TextBox CountrytextBox;
        private GroupBox groupBox2;
        private Label label19;
        private Button UpdateListenedbutton;
        private Button DeleteListenedbutton;
        private Button AddListenedbutton;
        private Label label20;
        private TextBox ListenedtextBox;
    }
}