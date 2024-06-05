namespace PASDesktop_Bumi_Bagus_Wiraguna
{
    partial class utama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utama));
            panel1 = new Panel();
            btnTersedia = new Button();
            label3 = new Label();
            btnCrud = new Button();
            btnAbout = new Button();
            btnEXIT = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnTersedia);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnCrud);
            panel1.Controls.Add(btnAbout);
            panel1.Controls.Add(btnEXIT);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 491);
            panel1.TabIndex = 0;
            // 
            // btnTersedia
            // 
            btnTersedia.BackColor = Color.White;
            btnTersedia.Cursor = Cursors.Hand;
            btnTersedia.FlatStyle = FlatStyle.Flat;
            btnTersedia.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTersedia.Location = new Point(30, 147);
            btnTersedia.Margin = new Padding(3, 4, 3, 4);
            btnTersedia.Name = "btnTersedia";
            btnTersedia.Size = new Size(86, 75);
            btnTersedia.TabIndex = 12;
            btnTersedia.Text = "List obat yang tersedia";
            btnTersedia.UseVisualStyleBackColor = false;
            btnTersedia.Click += btnTersedia_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 19);
            label3.Name = "label3";
            label3.Size = new Size(100, 34);
            label3.TabIndex = 4;
            label3.Text = "Home";
            // 
            // btnCrud
            // 
            btnCrud.BackColor = SystemColors.ActiveCaption;
            btnCrud.Cursor = Cursors.Hand;
            btnCrud.FlatStyle = FlatStyle.Flat;
            btnCrud.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrud.Location = new Point(23, 340);
            btnCrud.Margin = new Padding(3, 4, 3, 4);
            btnCrud.Name = "btnCrud";
            btnCrud.Size = new Size(107, 63);
            btnCrud.TabIndex = 11;
            btnCrud.Text = "Database";
            btnCrud.UseVisualStyleBackColor = false;
            btnCrud.Click += btnCrud_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.White;
            btnAbout.Cursor = Cursors.Hand;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.Location = new Point(30, 249);
            btnAbout.Margin = new Padding(3, 4, 3, 4);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(86, 63);
            btnAbout.TabIndex = 10;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnEXIT
            // 
            btnEXIT.BackColor = Color.Red;
            btnEXIT.Cursor = Cursors.Hand;
            btnEXIT.FlatStyle = FlatStyle.Flat;
            btnEXIT.Location = new Point(0, 448);
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(68, 43);
            btnEXIT.TabIndex = 9;
            btnEXIT.Text = "Logout";
            btnEXIT.UseVisualStyleBackColor = false;
            btnEXIT.Click += btnEXIT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(317, 12);
            label1.Name = "label1";
            label1.Size = new Size(348, 34);
            label1.TabIndex = 1;
            label1.Text = "Sumber Waras Apotek";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._360_F_89899105_UN5Bv2hYUx0TFzBdwpi8K1rkPzl3dYLx;
            pictureBox1.Location = new Point(247, 57);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(277, 349);
            label2.Name = "label2";
            label2.Size = new Size(412, 114);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // utama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 489);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "utama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAINFRAME";
            FormClosed += utama_FormClosed;
            Load += utama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnEXIT;
        private Label label2;
        private Button btnAbout;
        private Button btnCrud;
        private Label label3;
        private Button btnTersedia;
    }
}