
namespace SeleniumWD
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
            this.OpenBrowser = new System.Windows.Forms.Button();
            this.CloseBrowser = new System.Windows.Forms.Button();
            this.DepartmentFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExperienceFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RegionFilter = new System.Windows.Forms.ComboBox();
            this.NumberVacancies = new System.Windows.Forms.Button();
            this.dNumberVacancies = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LanguagesFilter = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenBrowser
            // 
            this.OpenBrowser.Location = new System.Drawing.Point(48, 231);
            this.OpenBrowser.Name = "OpenBrowser";
            this.OpenBrowser.Size = new System.Drawing.Size(113, 50);
            this.OpenBrowser.TabIndex = 0;
            this.OpenBrowser.Text = "Open browser";
            this.OpenBrowser.UseVisualStyleBackColor = true;
            this.OpenBrowser.Click += new System.EventHandler(this.OpenBrowser_Click);
            // 
            // CloseBrowser
            // 
            this.CloseBrowser.Location = new System.Drawing.Point(210, 231);
            this.CloseBrowser.Name = "CloseBrowser";
            this.CloseBrowser.Size = new System.Drawing.Size(114, 50);
            this.CloseBrowser.TabIndex = 1;
            this.CloseBrowser.Text = "Exit";
            this.CloseBrowser.UseVisualStyleBackColor = true;
            this.CloseBrowser.Click += new System.EventHandler(this.CloseBrowser_Click);
            // 
            // DepartmentFilter
            // 
            this.DepartmentFilter.Enabled = false;
            this.DepartmentFilter.FormattingEnabled = true;
            this.DepartmentFilter.Location = new System.Drawing.Point(98, 58);
            this.DepartmentFilter.Name = "DepartmentFilter";
            this.DepartmentFilter.Size = new System.Drawing.Size(121, 23);
            this.DepartmentFilter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keyword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department";
            // 
            // KeyWord
            // 
            this.KeyWord.Location = new System.Drawing.Point(98, 24);
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.ReadOnly = true;
            this.KeyWord.Size = new System.Drawing.Size(121, 23);
            this.KeyWord.TabIndex = 5;
            this.KeyWord.TextChanged += new System.EventHandler(this.KeyWord_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Languages";
            // 
            // ExperienceFilter
            // 
            this.ExperienceFilter.Enabled = false;
            this.ExperienceFilter.FormattingEnabled = true;
            this.ExperienceFilter.Location = new System.Drawing.Point(98, 133);
            this.ExperienceFilter.Name = "ExperienceFilter";
            this.ExperienceFilter.Size = new System.Drawing.Size(121, 23);
            this.ExperienceFilter.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Experience";
            // 
            // RegionFilter
            // 
            this.RegionFilter.Enabled = false;
            this.RegionFilter.FormattingEnabled = true;
            this.RegionFilter.Location = new System.Drawing.Point(98, 169);
            this.RegionFilter.Name = "RegionFilter";
            this.RegionFilter.Size = new System.Drawing.Size(121, 23);
            this.RegionFilter.TabIndex = 9;
            // 
            // NumberVacancies
            // 
            this.NumberVacancies.Enabled = false;
            this.NumberVacancies.Location = new System.Drawing.Point(252, 120);
            this.NumberVacancies.Name = "NumberVacancies";
            this.NumberVacancies.Size = new System.Drawing.Size(111, 57);
            this.NumberVacancies.TabIndex = 10;
            this.NumberVacancies.Text = "Number of vacancies";
            this.NumberVacancies.UseVisualStyleBackColor = true;
            this.NumberVacancies.Click += new System.EventHandler(this.NumberVacancies_Click);
            // 
            // dNumberVacancies
            // 
            this.dNumberVacancies.AutoSize = true;
            this.dNumberVacancies.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dNumberVacancies.Location = new System.Drawing.Point(292, 48);
            this.dNumberVacancies.Name = "dNumberVacancies";
            this.dNumberVacancies.Size = new System.Drawing.Size(0, 37);
            this.dNumberVacancies.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LanguagesFilter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DepartmentFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RegionFilter);
            this.groupBox1.Controls.Add(this.KeyWord);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ExperienceFilter);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // LanguagesFilter
            // 
            this.LanguagesFilter.Enabled = false;
            this.LanguagesFilter.FormattingEnabled = true;
            this.LanguagesFilter.Location = new System.Drawing.Point(98, 88);
            this.LanguagesFilter.Name = "LanguagesFilter";
            this.LanguagesFilter.Size = new System.Drawing.Size(120, 40);
            this.LanguagesFilter.TabIndex = 11;
            this.LanguagesFilter.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LanguageFilter_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Region";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dNumberVacancies);
            this.Controls.Add(this.NumberVacancies);
            this.Controls.Add(this.CloseBrowser);
            this.Controls.Add(this.OpenBrowser);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenBrowser;
        private System.Windows.Forms.Button CloseBrowser;
        private System.Windows.Forms.ComboBox DepartmentFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ExperienceFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RegionFilter;
        private System.Windows.Forms.Button NumberVacancies;
        private System.Windows.Forms.Label dNumberVacancies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox LanguagesFilter;
    }
}

