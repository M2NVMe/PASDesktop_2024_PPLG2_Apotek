namespace PASDesktop_Bumi_Bagus_Wiraguna
{
    partial class CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            txtSEARCH = new TextBox();
            btnPRINT = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCLEAR = new Button();
            btnCREATE = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpick = new DateTimePicker();
            rdYA = new RadioButton();
            rdTIDAK = new RadioButton();
            btnEXIT = new Button();
            txID = new TextBox();
            txObat = new TextBox();
            txdosis = new TextBox();
            txjenisobat = new TextBox();
            txprodusen = new TextBox();
            label8 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(546, 107);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(962, 396);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(1415, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSEARCH
            // 
            txtSEARCH.Location = new Point(1224, 51);
            txtSEARCH.Name = "txtSEARCH";
            txtSEARCH.Size = new Size(185, 27);
            txtSEARCH.TabIndex = 16;
            // 
            // btnPRINT
            // 
            btnPRINT.BackColor = Color.RosyBrown;
            btnPRINT.Cursor = Cursors.Hand;
            btnPRINT.Location = new Point(1112, 39);
            btnPRINT.Name = "btnPRINT";
            btnPRINT.Size = new Size(94, 52);
            btnPRINT.TabIndex = 22;
            btnPRINT.Text = "Print PDF";
            btnPRINT.UseVisualStyleBackColor = false;
            btnPRINT.Click += btnPRINT_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(371, 467);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 64);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(271, 467);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 64);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCLEAR
            // 
            btnCLEAR.BackColor = Color.Yellow;
            btnCLEAR.Cursor = Cursors.Hand;
            btnCLEAR.Location = new Point(169, 467);
            btnCLEAR.Name = "btnCLEAR";
            btnCLEAR.Size = new Size(94, 64);
            btnCLEAR.TabIndex = 19;
            btnCLEAR.Text = "Clear";
            btnCLEAR.UseVisualStyleBackColor = false;
            btnCLEAR.Click += btnCLEAR_Click;
            // 
            // btnCREATE
            // 
            btnCREATE.BackColor = Color.Lime;
            btnCREATE.Cursor = Cursors.Hand;
            btnCREATE.Location = new Point(69, 467);
            btnCREATE.Name = "btnCREATE";
            btnCREATE.Size = new Size(94, 64);
            btnCREATE.TabIndex = 18;
            btnCREATE.Text = "Create";
            btnCREATE.UseVisualStyleBackColor = false;
            btnCREATE.Click += btnCREATE_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 91);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 23;
            label1.Text = "ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 135);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 24;
            label2.Text = "Obat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 180);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 25;
            label3.Text = "Dosis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 227);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 26;
            label4.Text = "Jenis Obat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 277);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 27;
            label5.Text = "Produsen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 327);
            label6.Name = "label6";
            label6.Size = new Size(202, 28);
            label6.TabIndex = 28;
            label6.Text = "Menggunakan BPJS:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 375);
            label7.Name = "label7";
            label7.Size = new Size(201, 28);
            label7.TabIndex = 29;
            label7.Text = "Tanggal Kadaluarsa:";
            // 
            // dtpick
            // 
            dtpick.Location = new Point(261, 375);
            dtpick.Margin = new Padding(3, 4, 3, 4);
            dtpick.Name = "dtpick";
            dtpick.Size = new Size(254, 27);
            dtpick.TabIndex = 30;
            // 
            // rdYA
            // 
            rdYA.AutoSize = true;
            rdYA.Location = new Point(271, 327);
            rdYA.Margin = new Padding(3, 4, 3, 4);
            rdYA.Name = "rdYA";
            rdYA.Size = new Size(45, 24);
            rdYA.TabIndex = 31;
            rdYA.TabStop = true;
            rdYA.Text = "Ya";
            rdYA.UseVisualStyleBackColor = true;
            // 
            // rdTIDAK
            // 
            rdTIDAK.AutoSize = true;
            rdTIDAK.Location = new Point(433, 327);
            rdTIDAK.Margin = new Padding(3, 4, 3, 4);
            rdTIDAK.Name = "rdTIDAK";
            rdTIDAK.Size = new Size(66, 24);
            rdTIDAK.TabIndex = 32;
            rdTIDAK.TabStop = true;
            rdTIDAK.Text = "Tidak";
            rdTIDAK.UseVisualStyleBackColor = true;
            // 
            // btnEXIT
            // 
            btnEXIT.BackColor = Color.Red;
            btnEXIT.Cursor = Cursors.Hand;
            btnEXIT.FlatStyle = FlatStyle.Flat;
            btnEXIT.Location = new Point(-2, 0);
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(56, 43);
            btnEXIT.TabIndex = 33;
            btnEXIT.Text = "Back";
            btnEXIT.UseVisualStyleBackColor = false;
            btnEXIT.Click += btnEXIT_Click;
            // 
            // txID
            // 
            txID.Location = new Point(271, 93);
            txID.Margin = new Padding(3, 4, 3, 4);
            txID.Name = "txID";
            txID.Size = new Size(114, 27);
            txID.TabIndex = 34;
            txID.KeyPress += txID_KeyPress;
            // 
            // txObat
            // 
            txObat.Location = new Point(271, 132);
            txObat.Margin = new Padding(3, 4, 3, 4);
            txObat.Name = "txObat";
            txObat.Size = new Size(228, 27);
            txObat.TabIndex = 35;
            // 
            // txdosis
            // 
            txdosis.Location = new Point(271, 177);
            txdosis.Margin = new Padding(3, 4, 3, 4);
            txdosis.Name = "txdosis";
            txdosis.Size = new Size(228, 27);
            txdosis.TabIndex = 36;
            // 
            // txjenisobat
            // 
            txjenisobat.Location = new Point(271, 224);
            txjenisobat.Margin = new Padding(3, 4, 3, 4);
            txjenisobat.Name = "txjenisobat";
            txjenisobat.Size = new Size(228, 27);
            txjenisobat.TabIndex = 37;
            // 
            // txprodusen
            // 
            txprodusen.Location = new Point(271, 275);
            txprodusen.Margin = new Padding(3, 4, 3, 4);
            txprodusen.Name = "txprodusen";
            txprodusen.Size = new Size(228, 27);
            txprodusen.TabIndex = 38;
            txprodusen.TextChanged += txprodusen_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(113, 9);
            label8.Name = "label8";
            label8.Size = new Size(222, 28);
            label8.TabIndex = 39;
            label8.Text = "Sumber Waras Apotek";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1464, 525);
            button1.Name = "button1";
            button1.Size = new Size(56, 31);
            button1.TabIndex = 40;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 555);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(txprodusen);
            Controls.Add(txjenisobat);
            Controls.Add(txdosis);
            Controls.Add(txObat);
            Controls.Add(txID);
            Controls.Add(btnEXIT);
            Controls.Add(rdTIDAK);
            Controls.Add(rdYA);
            Controls.Add(dtpick);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPRINT);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCLEAR);
            Controls.Add(btnCREATE);
            Controls.Add(btnSearch);
            Controls.Add(txtSEARCH);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD";
            Load += CRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSearch;
        private TextBox txtSEARCH;
        private Button btnPRINT;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCLEAR;
        private Button btnCREATE;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpick;
        private RadioButton rdYA;
        private RadioButton rdTIDAK;
        private Button btnEXIT;
        private TextBox txID;
        private TextBox txObat;
        private TextBox txdosis;
        private TextBox txjenisobat;
        private TextBox txprodusen;
        private Label label8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button button1;
    }
}