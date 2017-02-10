namespace Tutorial6OOPObject
{
    partial class Form1
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
            this.txtStudents = new System.Windows.Forms.TextBox();
            this.btShow = new System.Windows.Forms.Button();
            this.txtAgeFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStudents
            // 
            this.txtStudents.Location = new System.Drawing.Point(12, 12);
            this.txtStudents.Multiline = true;
            this.txtStudents.Name = "txtStudents";
            this.txtStudents.Size = new System.Drawing.Size(292, 355);
            this.txtStudents.TabIndex = 0;
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(310, 12);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 23);
            this.btShow.TabIndex = 1;
            this.btShow.Text = "Zobrazit";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // txtAgeFilter
            // 
            this.txtAgeFilter.Location = new System.Drawing.Point(310, 41);
            this.txtAgeFilter.Name = "txtAgeFilter";
            this.txtAgeFilter.Size = new System.Drawing.Size(75, 20);
            this.txtAgeFilter.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 379);
            this.Controls.Add(this.txtAgeFilter);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.txtStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudents;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.TextBox txtAgeFilter;
    }
}

