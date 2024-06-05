namespace PASDesktop_Bumi_Bagus_Wiraguna
{
    partial class listobat
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
            btnEXIT = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            btnSearch = new Button();
            txtSEARCH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEXIT
            // 
            btnEXIT.BackColor = Color.Red;
            btnEXIT.Cursor = Cursors.Hand;
            btnEXIT.FlatStyle = FlatStyle.Flat;
            btnEXIT.Location = new Point(-2, 0);
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(56, 43);
            btnEXIT.TabIndex = 34;
            btnEXIT.Text = "Back";
            btnEXIT.UseVisualStyleBackColor = false;
            btnEXIT.Click += btnEXIT_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 65);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(962, 396);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(157, 26);
            label8.Name = "label8";
            label8.Size = new Size(192, 28);
            label8.TabIndex = 40;
            label8.Text = "Obat yang tersedia";
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(902, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 42;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSEARCH
            // 
            txtSEARCH.Location = new Point(711, 31);
            txtSEARCH.Name = "txtSEARCH";
            txtSEARCH.Size = new Size(185, 27);
            txtSEARCH.TabIndex = 41;
            // 
            // listobat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 486);
            Controls.Add(btnSearch);
            Controls.Add(txtSEARCH);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(btnEXIT);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listobat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "listobat";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEXIT;
        private DataGridView dataGridView1;
        private Label label8;
        private Button btnSearch;
        private TextBox txtSEARCH;
    }
}