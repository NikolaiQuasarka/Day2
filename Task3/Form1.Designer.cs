namespace Task3
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
            textBox_a = new TextBox();
            textBox_b = new TextBox();
            textBox_c = new TextBox();
            textBox_startx = new TextBox();
            textBox_endx = new TextBox();
            textBox_dX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(155, 374);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_a
            // 
            textBox_a.Location = new Point(155, 48);
            textBox_a.Name = "textBox_a";
            textBox_a.Size = new Size(125, 27);
            textBox_a.TabIndex = 1;
            // 
            // textBox_b
            // 
            textBox_b.Location = new Point(155, 85);
            textBox_b.Name = "textBox_b";
            textBox_b.Size = new Size(125, 27);
            textBox_b.TabIndex = 2;
            // 
            // textBox_c
            // 
            textBox_c.Location = new Point(155, 126);
            textBox_c.Name = "textBox_c";
            textBox_c.Size = new Size(125, 27);
            textBox_c.TabIndex = 3;
            // 
            // textBox_startx
            // 
            textBox_startx.Location = new Point(155, 175);
            textBox_startx.Name = "textBox_startx";
            textBox_startx.Size = new Size(125, 27);
            textBox_startx.TabIndex = 4;
            // 
            // textBox_endx
            // 
            textBox_endx.Location = new Point(155, 236);
            textBox_endx.Name = "textBox_endx";
            textBox_endx.Size = new Size(125, 27);
            textBox_endx.TabIndex = 5;
            // 
            // textBox_dX
            // 
            textBox_dX.Location = new Point(155, 287);
            textBox_dX.Name = "textBox_dX";
            textBox_dX.Size = new Size(125, 27);
            textBox_dX.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(88, 48);
            label1.Name = "label1";
            label1.Size = new Size(61, 284);
            label1.TabIndex = 7;
            label1.Text = "a\r\n\r\nb\r\n\r\nc\r\n\r\nНач. знач. x\r\n\r\nКон. знач. x\r\n\r\nШаг dX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 9);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 8;
            label2.Text = "Вычисление фукнции";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridView1.Location = new Point(363, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(469, 284);
            dataGridView1.TabIndex = 9;
            // 
            // X
            // 
            X.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 47;
            // 
            // F
            // 
            F.HeaderText = "F(x)";
            F.MinimumWidth = 6;
            F.Name = "F";
            F.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_dX);
            Controls.Add(textBox_endx);
            Controls.Add(textBox_startx);
            Controls.Add(textBox_c);
            Controls.Add(textBox_b);
            Controls.Add(textBox_a);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox_a;
        private TextBox textBox_b;
        private TextBox textBox_c;
        private TextBox textBox_startx;
        private TextBox textBox_endx;
        private TextBox textBox_dX;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
    }
}
