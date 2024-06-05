namespace PASDesktop_Bumi_Bagus_Wiraguna
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
            txtUSERNAME = new TextBox();
            txtPASSWORD = new TextBox();
            btnLOGIN = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            checkBox1 = new CheckBox();
            btnEXIT = new Button();
            SuspendLayout();
            // 
            // txtUSERNAME
            // 
            txtUSERNAME.Location = new Point(298, 188);
            txtUSERNAME.Name = "txtUSERNAME";
            txtUSERNAME.Size = new Size(196, 27);
            txtUSERNAME.TabIndex = 0;
            // 
            // txtPASSWORD
            // 
            txtPASSWORD.Location = new Point(298, 236);
            txtPASSWORD.Name = "txtPASSWORD";
            txtPASSWORD.Size = new Size(196, 27);
            txtPASSWORD.TabIndex = 1;
            txtPASSWORD.UseSystemPasswordChar = true;
            // 
            // btnLOGIN
            // 
            btnLOGIN.BackColor = Color.Lime;
            btnLOGIN.Cursor = Cursors.Hand;
            btnLOGIN.Location = new Point(401, 375);
            btnLOGIN.Name = "btnLOGIN";
            btnLOGIN.Size = new Size(94, 45);
            btnLOGIN.TabIndex = 2;
            btnLOGIN.Text = "Login";
            btnLOGIN.UseVisualStyleBackColor = false;
            btnLOGIN.Click += btnLOGIN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 188);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 240);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Password: ";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Location = new Point(-9, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 476);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(168, 40);
            label3.Name = "label3";
            label3.Size = new Size(376, 46);
            label3.TabIndex = 6;
            label3.Text = "Sumber Waras Apotek";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(321, 296);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnEXIT
            // 
            btnEXIT.BackColor = Color.Crimson;
            btnEXIT.Cursor = Cursors.Hand;
            btnEXIT.Location = new Point(202, 375);
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(94, 45);
            btnEXIT.TabIndex = 8;
            btnEXIT.Text = "Exit";
            btnEXIT.UseVisualStyleBackColor = false;
            btnEXIT.Click += btnEXIT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 469);
            Controls.Add(btnEXIT);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLOGIN);
            Controls.Add(txtPASSWORD);
            Controls.Add(txtUSERNAME);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUSERNAME;
        private TextBox txtPASSWORD;
        private Button btnLOGIN;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private CheckBox checkBox1;
        private Button btnEXIT;
    }
}