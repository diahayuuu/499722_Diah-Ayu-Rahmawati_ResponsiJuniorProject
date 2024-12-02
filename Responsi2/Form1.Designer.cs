namespace Responsi2
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tbNama = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbDep = new TextBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            btnLoadData = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 44);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 0;
            label1.Text = "logo";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 52);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(167, 108);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(183, 23);
            tbNama.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 108);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 3;
            label2.Text = "Nama Karyawan : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 160);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 4;
            label3.Text = "Dep. Karyawan :";
            // 
            // tbDep
            // 
            tbDep.Location = new Point(167, 160);
            tbDep.Name = "tbDep";
            tbDep.Size = new Size(183, 23);
            tbDep.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(26, 212);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(135, 23);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(201, 212);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(159, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(400, 212);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 259);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(526, 165);
            dataGridView1.TabIndex = 9;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(400, 448);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(152, 23);
            btnLoadData.TabIndex = 10;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Location = new Point(400, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 111);
            textBox1.TabIndex = 11;
            textBox1.Text = "ID Departemen :\r\nHR : HR \r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product Manager\r\nFIN : Finance\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 517);
            Controls.Add(textBox1);
            Controls.Add(btnLoadData);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(tbDep);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbNama);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox tbNama;
        private Label label2;
        private Label label3;
        private TextBox tbDep;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Button btnLoadData;
        private TextBox textBox1;
    }
}
