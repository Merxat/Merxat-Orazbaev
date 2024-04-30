namespace Uyga_vazifa
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
            button1 = new Button();
            t1Name = new TextBox();
            t2UserName = new TextBox();
            t3Passwoed = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(114, 352);
            button1.Name = "button1";
            button1.Size = new Size(449, 57);
            button1.TabIndex = 3;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // t1Name
            // 
            t1Name.Font = new Font("Segoe UI", 13.8F);
            t1Name.Location = new Point(286, 54);
            t1Name.Name = "t1Name";
            t1Name.Size = new Size(345, 38);
            t1Name.TabIndex = 4;
            // 
            // t2UserName
            // 
            t2UserName.Font = new Font("Segoe UI", 13.8F);
            t2UserName.Location = new Point(286, 168);
            t2UserName.Name = "t2UserName";
            t2UserName.Size = new Size(345, 38);
            t2UserName.TabIndex = 5;
            // 
            // t3Passwoed
            // 
            t3Passwoed.Font = new Font("Segoe UI", 13.8F);
            t3Passwoed.Location = new Point(286, 275);
            t3Passwoed.Name = "t3Passwoed";
            t3Passwoed.Size = new Size(345, 38);
            t3Passwoed.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F);
            label1.Location = new Point(68, 46);
            label1.Name = "label1";
            label1.Size = new Size(72, 46);
            label1.TabIndex = 7;
            label1.Text = "FIO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F);
            label2.Location = new Point(68, 160);
            label2.Name = "label2";
            label2.Size = new Size(176, 46);
            label2.TabIndex = 8;
            label2.Text = "UserName";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F);
            label3.Location = new Point(68, 267);
            label3.Name = "label3";
            label3.Size = new Size(160, 46);
            label3.TabIndex = 9;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(t3Passwoed);
            Controls.Add(t2UserName);
            Controls.Add(t1Name);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox t1Name;
        private TextBox t2UserName;
        private TextBox t3Passwoed;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
