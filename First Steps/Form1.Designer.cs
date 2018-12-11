namespace First_Steps
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCodephrase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioGreek = new System.Windows.Forms.RadioButton();
            this.radioRoman = new System.Windows.Forms.RadioButton();
            this.checkTerms = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This example features text!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkTerms);
            this.groupBox1.Controls.Add(this.radioRoman);
            this.groupBox1.Controls.Add(this.radioGreek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textCodephrase);
            this.groupBox1.Location = new System.Drawing.Point(21, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codephrase";
            // 
            // textCodephrase
            // 
            this.textCodephrase.Location = new System.Drawing.Point(7, 20);
            this.textCodephrase.Name = "textCodephrase";
            this.textCodephrase.Size = new System.Drawing.Size(100, 20);
            this.textCodephrase.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origin:";
            // 
            // radioGreek
            // 
            this.radioGreek.AutoSize = true;
            this.radioGreek.Location = new System.Drawing.Point(7, 64);
            this.radioGreek.Name = "radioGreek";
            this.radioGreek.Size = new System.Drawing.Size(54, 17);
            this.radioGreek.TabIndex = 2;
            this.radioGreek.TabStop = true;
            this.radioGreek.Text = "Greek";
            this.radioGreek.UseVisualStyleBackColor = true;
            // 
            // radioRoman
            // 
            this.radioRoman.AutoSize = true;
            this.radioRoman.Location = new System.Drawing.Point(7, 88);
            this.radioRoman.Name = "radioRoman";
            this.radioRoman.Size = new System.Drawing.Size(59, 17);
            this.radioRoman.TabIndex = 3;
            this.radioRoman.TabStop = true;
            this.radioRoman.Text = "Roman";
            this.radioRoman.UseVisualStyleBackColor = true;
            // 
            // checkTerms
            // 
            this.checkTerms.AutoSize = true;
            this.checkTerms.Location = new System.Drawing.Point(10, 169);
            this.checkTerms.Name = "checkTerms";
            this.checkTerms.Size = new System.Drawing.Size(132, 17);
            this.checkTerms.TabIndex = 4;
            this.checkTerms.Text = "I Agree with the Terms";
            this.checkTerms.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Steps";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCodephrase;
        private System.Windows.Forms.CheckBox checkTerms;
        private System.Windows.Forms.RadioButton radioRoman;
        private System.Windows.Forms.RadioButton radioGreek;
        private System.Windows.Forms.Label label2;
    }
}

