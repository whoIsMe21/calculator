namespace calculator
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
            btnDiv = new Button();
            btnQuo = new Button();
            btnDiff = new Button();
            btnSum = new Button();
            lblAns = new Label();
            label5 = new Label();
            label4 = new Label();
            txtSnum = new TextBox();
            txtFnum = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(422, 181);
            button1.Name = "button1";
            button1.Size = new Size(88, 29);
            button1.TabIndex = 4;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Teal;
            btnDiv.ForeColor = Color.White;
            btnDiv.Location = new Point(478, 124);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(87, 29);
            btnDiv.TabIndex = 3;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnQuo
            // 
            btnQuo.BackColor = Color.DarkGoldenrod;
            btnQuo.ForeColor = Color.White;
            btnQuo.Location = new Point(476, 68);
            btnQuo.Name = "btnQuo";
            btnQuo.Size = new Size(89, 29);
            btnQuo.TabIndex = 2;
            btnQuo.Text = "X";
            btnQuo.UseVisualStyleBackColor = false;
            btnQuo.Click += btnQuo_Click;
            // 
            // btnDiff
            // 
            btnDiff.BackColor = Color.DarkMagenta;
            btnDiff.ForeColor = Color.White;
            btnDiff.Location = new Point(356, 124);
            btnDiff.Name = "btnDiff";
            btnDiff.Size = new Size(86, 29);
            btnDiff.TabIndex = 1;
            btnDiff.Text = "-";
            btnDiff.UseVisualStyleBackColor = false;
            btnDiff.Click += btnDiff_Click;
            // 
            // btnSum
            // 
            btnSum.BackColor = Color.DarkGreen;
            btnSum.ForeColor = Color.White;
            btnSum.Location = new Point(356, 68);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(84, 29);
            btnSum.TabIndex = 0;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = false;
            btnSum.Click += btnSum_Click;
            // 
            // lblAns
            // 
            lblAns.AutoSize = true;
            lblAns.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAns.Location = new Point(221, 193);
            lblAns.Name = "lblAns";
            lblAns.Size = new Size(23, 17);
            lblAns.TabIndex = 16;
            lblAns.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 193);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 15;
            label5.Text = "RESULT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 148);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 14;
            // 
            // txtSnum
            // 
            txtSnum.Location = new Point(178, 130);
            txtSnum.Name = "txtSnum";
            txtSnum.Size = new Size(116, 23);
            txtSnum.TabIndex = 13;
            txtSnum.TextChanged += txtSnum_TextChanged;
            // 
            // txtFnum
            // 
            txtFnum.Location = new Point(178, 67);
            txtFnum.Name = "txtFnum";
            txtFnum.Size = new Size(116, 23);
            txtFnum.TabIndex = 12;
            txtFnum.TextChanged += txtFnum_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(33, 131);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 11;
            label3.Text = "SECOND NUMBER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 68);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 10;
            label2.Text = "FIRST NUMBER";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 24);
            label1.TabIndex = 9;
            label1.Text = "CALCULATOR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(599, 223);
            Controls.Add(btnDiff);
            Controls.Add(btnDiv);
            Controls.Add(btnSum);
            Controls.Add(button1);
            Controls.Add(lblAns);
            Controls.Add(btnQuo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSnum);
            Controls.Add(txtFnum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDiv;
        private Button btnQuo;
        private Button btnDiff;
        private Button btnSum;
        private Label lblAns;
        private Label label5;
        private Label label4;
        private TextBox txtSnum;
        private TextBox txtFnum;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
