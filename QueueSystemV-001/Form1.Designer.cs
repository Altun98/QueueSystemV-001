namespace QueueSystemV_001
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
            cmbSeries = new ComboBox();
            cmbOperationType = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblOperationTypeName = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            lblInformations = new Label();
            label2 = new Label();
            panel5 = new Panel();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblWhotch = new Label();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // cmbSeries
            // 
            cmbSeries.FormattingEnabled = true;
            cmbSeries.Location = new Point(80, 184);
            cmbSeries.Name = "cmbSeries";
            cmbSeries.Size = new Size(211, 28);
            cmbSeries.TabIndex = 0;
            // 
            // cmbOperationType
            // 
            cmbOperationType.FormattingEnabled = true;
            cmbOperationType.Location = new Point(23, 53);
            cmbOperationType.Name = "cmbOperationType";
            cmbOperationType.Size = new Size(297, 28);
            cmbOperationType.TabIndex = 1;
            cmbOperationType.SelectedIndexChanged += cmbOperationType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(23, 10);
            label1.Name = "label1";
            label1.Size = new Size(297, 40);
            label1.TabIndex = 2;
            label1.Text = "Bankımıza xoş gelmisiniz zehmet olmasa \r\nemeliyyat seçərək növbə götürün.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(cmbSeries);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblOperationTypeName);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(23, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 329);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Növbə məlumatları";
            groupBox1.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(80, 284);
            button1.Name = "button1";
            button1.Size = new Size(211, 29);
            button1.TabIndex = 15;
            button1.Text = "Növbəyə yaz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(80, 251);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(80, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(80, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 254);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 9;
            label8.Text = "FİN:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 221);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 8;
            label7.Text = "Nomresi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 187);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 7;
            label6.Text = "Seriya:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 154);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 6;
            label5.Text = "Ata adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 121);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 5;
            label4.Text = "Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 88);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 4;
            label3.Text = "Adı:";
            // 
            // lblOperationTypeName
            // 
            lblOperationTypeName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOperationTypeName.Location = new Point(4, 34);
            lblOperationTypeName.Name = "lblOperationTypeName";
            lblOperationTypeName.Size = new Size(287, 33);
            lblOperationTypeName.TabIndex = 3;
            lblOperationTypeName.Text = "label2";
            lblOperationTypeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(297, 2);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SandyBrown;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 2);
            panel4.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(4, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 2);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 2);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblInformations);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(panel5);
            groupBox2.Location = new Point(326, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(764, 174);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Əməliyyatların növbəsi";
            // 
            // lblInformations
            // 
            lblInformations.AutoSize = true;
            lblInformations.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInformations.Location = new Point(6, 23);
            lblInformations.Name = "lblInformations";
            lblInformations.Size = new Size(49, 28);
            lblInformations.TabIndex = 6;
            lblInformations.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 90);
            label2.Name = "label2";
            label2.Size = new Size(735, 28);
            label2.TabIndex = 5;
            label2.Text = "Zəhmət olmasa növbəniz üçün ayrılmış vaxt bitmədən operatora yaxınlaşın..";
            // 
            // panel5
            // 
            panel5.Controls.Add(progressBar1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(3, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(758, 46);
            panel5.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(0, 0);
            progressBar1.Maximum = 300;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(758, 46);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblWhotch
            // 
            lblWhotch.AutoSize = true;
            lblWhotch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWhotch.Location = new Point(326, 189);
            lblWhotch.Name = "lblWhotch";
            lblWhotch.Size = new Size(94, 28);
            lblWhotch.TabIndex = 7;
            lblWhotch.Text = "00:00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 565);
            Controls.Add(lblWhotch);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(cmbOperationType);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSeries;
        private ComboBox cmbOperationType;
        private Label label1;
        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblOperationTypeName;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button1;
        private GroupBox groupBox2;
        private Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Label lblInformations;
        private Label label2;
        private Label lblWhotch;
    }
}
