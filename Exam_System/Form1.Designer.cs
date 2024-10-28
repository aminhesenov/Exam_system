namespace Exam_System
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            maskedTextBox5 = new MaskedTextBox();
            label6 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label5 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label4 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            errorProvider7 = new ErrorProvider(components);
            notifyIcon1 = new NotifyIcon(components);
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(527, 35);
            label1.Name = "label1";
            label1.Size = new Size(208, 29);
            label1.TabIndex = 1;
            label1.Text = "İmtahan Sistemi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(maskedTextBox5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(maskedTextBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(maskedTextBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 257);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(190, 206);
            button3.Name = "button3";
            button3.Size = new Size(214, 36);
            button3.TabIndex = 16;
            button3.Text = "Proqramdan çıxış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 59);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "İxtisas";
            textBox2.Size = new Size(214, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tələbənin ad və soyadı";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(448, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(357, 231);
            dataGridView1.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(190, 153);
            button2.Name = "button2";
            button2.Size = new Size(214, 36);
            button2.TabIndex = 12;
            button2.Text = "Xanaları sıfırla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(190, 104);
            button1.Name = "button1";
            button1.Size = new Size(214, 36);
            button1.TabIndex = 11;
            button1.Text = "Nəticəni hesabla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(64, 211);
            maskedTextBox5.Mask = "00";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(74, 23);
            maskedTextBox5.TabIndex = 9;
            toolTip5.SetToolTip(maskedTextBox5, "0-50 arasında qiymət daxil edilir");
            maskedTextBox5.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 214);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 8;
            label6.Text = "SSİ:";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(64, 162);
            maskedTextBox4.Mask = "00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(74, 23);
            maskedTextBox4.TabIndex = 7;
            toolTip4.SetToolTip(maskedTextBox4, "0-10 arasında qiymət daxil edilir");
            maskedTextBox4.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 165);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 6;
            label5.Text = "DVM:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(64, 113);
            maskedTextBox3.Mask = "00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(74, 23);
            maskedTextBox3.TabIndex = 5;
            toolTip3.SetToolTip(maskedTextBox3, "0-10 arasında qiymət daxil edilir");
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 113);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 4;
            label4.Text = "TSİ:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(64, 59);
            maskedTextBox2.Mask = "00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(74, 23);
            maskedTextBox2.TabIndex = 3;
            toolTip2.SetToolTip(maskedTextBox2, "0-15 arasında qiymət daxil edilir");
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "SDF2:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(64, 11);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(74, 23);
            maskedTextBox1.TabIndex = 1;
            toolTip1.SetToolTip(maskedTextBox1, "0-15 arasında qiymət daxil edilir");
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "SDF1:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            errorProvider7.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "SDF1";
            // 
            // toolTip2
            // 
            toolTip2.ToolTipTitle = "SDF2";
            // 
            // toolTip3
            // 
            toolTip3.ToolTipTitle = "TSI";
            // 
            // toolTip4
            // 
            toolTip4.ToolTipTitle = "DVM";
            // 
            // toolTip5
            // 
            toolTip5.ToolTipTitle = "SSI";
            // 
            // Column1
            // 
            Column1.HeaderText = "Ad və soyad";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "İxtisas";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Nəticə";
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kategory";
            Column4.Name = "Column4";
            Column4.Width = 60;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(817, 367);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İmtahan sistemi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Button button1;
        private MaskedTextBox maskedTextBox5;
        private Label label6;
        private MaskedTextBox maskedTextBox4;
        private Label label5;
        private MaskedTextBox maskedTextBox3;
        private Label label4;
        private MaskedTextBox maskedTextBox2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private NotifyIcon notifyIcon1;
        private ToolTip toolTip1;
        private ToolTip toolTip5;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
