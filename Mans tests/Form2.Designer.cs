
namespace Mans_tests
{
    partial class Form2
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
            this.jautajums = new System.Windows.Forms.Label();
            this.labPiemers = new System.Windows.Forms.Label();
            this.butAtbilde1 = new System.Windows.Forms.Button();
            this.butAtbilde2 = new System.Windows.Forms.Button();
            this.butAtbilde3 = new System.Windows.Forms.Button();
            this.butAtbilde4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jautajums
            // 
            this.jautajums.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.jautajums.Location = new System.Drawing.Point(42, 85);
            this.jautajums.Name = "jautajums";
            this.jautajums.Size = new System.Drawing.Size(715, 82);
            this.jautajums.TabIndex = 1;
            this.jautajums.Text = "Jautājums";
            this.jautajums.Click += new System.EventHandler(this.jautajums_Click);
            // 
            // labPiemers
            // 
            this.labPiemers.AutoSize = true;
            this.labPiemers.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labPiemers.Location = new System.Drawing.Point(576, 28);
            this.labPiemers.Name = "labPiemers";
            this.labPiemers.Size = new System.Drawing.Size(192, 26);
            this.labPiemers.TabIndex = 6;
            this.labPiemers.Text = "1. no 10. jautājumiem";
            // 
            // butAtbilde1
            // 
            this.butAtbilde1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butAtbilde1.Location = new System.Drawing.Point(48, 189);
            this.butAtbilde1.Name = "butAtbilde1";
            this.butAtbilde1.Size = new System.Drawing.Size(697, 41);
            this.butAtbilde1.TabIndex = 7;
            this.butAtbilde1.Text = "1. atbilde";
            this.butAtbilde1.UseVisualStyleBackColor = true;
            this.butAtbilde1.Click += new System.EventHandler(this.butAtbilde1_Click);
            // 
            // butAtbilde2
            // 
            this.butAtbilde2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butAtbilde2.Location = new System.Drawing.Point(48, 248);
            this.butAtbilde2.Name = "butAtbilde2";
            this.butAtbilde2.Size = new System.Drawing.Size(697, 41);
            this.butAtbilde2.TabIndex = 8;
            this.butAtbilde2.Text = "2. atbilde";
            this.butAtbilde2.UseVisualStyleBackColor = true;
            this.butAtbilde2.Click += new System.EventHandler(this.butAtbilde2_Click);
            // 
            // butAtbilde3
            // 
            this.butAtbilde3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butAtbilde3.Location = new System.Drawing.Point(48, 309);
            this.butAtbilde3.Name = "butAtbilde3";
            this.butAtbilde3.Size = new System.Drawing.Size(697, 41);
            this.butAtbilde3.TabIndex = 9;
            this.butAtbilde3.Text = "3. atbilde";
            this.butAtbilde3.UseVisualStyleBackColor = true;
            this.butAtbilde3.Click += new System.EventHandler(this.butAtbilde3_Click);
            // 
            // butAtbilde4
            // 
            this.butAtbilde4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butAtbilde4.Location = new System.Drawing.Point(48, 371);
            this.butAtbilde4.Name = "butAtbilde4";
            this.butAtbilde4.Size = new System.Drawing.Size(697, 41);
            this.butAtbilde4.TabIndex = 10;
            this.butAtbilde4.Text = "4. atbilde";
            this.butAtbilde4.UseVisualStyleBackColor = true;
            this.butAtbilde4.Click += new System.EventHandler(this.butAtbilde4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butAtbilde4);
            this.Controls.Add(this.butAtbilde3);
            this.Controls.Add(this.butAtbilde2);
            this.Controls.Add(this.butAtbilde1);
            this.Controls.Add(this.labPiemers);
            this.Controls.Add(this.jautajums);
            this.Name = "Form2";
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jautajums;
        private System.Windows.Forms.Label labPiemers;
        private System.Windows.Forms.Button butAtbilde1;
        private System.Windows.Forms.Button butAtbilde2;
        private System.Windows.Forms.Button butAtbilde3;
        private System.Windows.Forms.Button butAtbilde4;
    }
}