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
            DirectordataGridView = new DataGridView();
            TypedataGridView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            HulutabControl.SuspendLayout();
            TypesAndDirectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DirectordataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TypedataGridView).BeginInit();
            SuspendLayout();
            // 
            // HulutabControl
            // 
            HulutabControl.Controls.Add(TypesAndDirectors);
            HulutabControl.Controls.Add(tabPage2);
            HulutabControl.Dock = DockStyle.Fill;
            HulutabControl.Location = new Point(0, 0);
            HulutabControl.Name = "HulutabControl";
            HulutabControl.SelectedIndex = 0;
            HulutabControl.Size = new Size(1356, 672);
            HulutabControl.TabIndex = 0;
            // 
            // TypesAndDirectors
            // 
            TypesAndDirectors.Controls.Add(DirectordataGridView);
            TypesAndDirectors.Controls.Add(TypedataGridView);
            TypesAndDirectors.Controls.Add(label2);
            TypesAndDirectors.Controls.Add(label1);
            TypesAndDirectors.Location = new Point(4, 29);
            TypesAndDirectors.Name = "TypesAndDirectors";
            TypesAndDirectors.Padding = new Padding(3);
            TypesAndDirectors.Size = new Size(1348, 639);
            TypesAndDirectors.TabIndex = 0;
            TypesAndDirectors.Text = "Types and Directors";
            TypesAndDirectors.UseVisualStyleBackColor = true;
            // 
            // DirectordataGridView
            // 
            DirectordataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DirectordataGridView.Location = new Point(660, 56);
            DirectordataGridView.Name = "DirectordataGridView";
            DirectordataGridView.RowHeadersWidth = 51;
            DirectordataGridView.RowTemplate.Height = 29;
            DirectordataGridView.Size = new Size(547, 249);
            DirectordataGridView.TabIndex = 3;
            // 
            // TypedataGridView
            // 
            TypedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TypedataGridView.Location = new Point(11, 56);
            TypedataGridView.Name = "TypedataGridView";
            TypedataGridView.RowHeadersWidth = 51;
            TypedataGridView.RowTemplate.Height = 29;
            TypedataGridView.Size = new Size(511, 249);
            TypedataGridView.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(660, 13);
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
            tabPage2.Size = new Size(1348, 639);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 672);
            Controls.Add(HulutabControl);
            Name = "Form1";
            Text = "HuluTV";
            Load += Form1_Load;
            HulutabControl.ResumeLayout(false);
            TypesAndDirectors.ResumeLayout(false);
            TypesAndDirectors.PerformLayout();
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
    }
}