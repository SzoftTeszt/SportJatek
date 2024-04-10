namespace WinFormsApp
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
            lbNames = new ListBox();
            label1 = new Label();
            label2 = new Label();
            tbTour = new TextBox();
            label3 = new Label();
            tbR1 = new TextBox();
            label4 = new Label();
            tbR2 = new TextBox();
            label5 = new Label();
            tbR3 = new TextBox();
            label6 = new Label();
            tbR4 = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lbNames
            // 
            lbNames.FormattingEnabled = true;
            lbNames.ItemHeight = 15;
            lbNames.Location = new Point(49, 52);
            lbNames.Name = "lbNames";
            lbNames.Size = new Size(120, 139);
            lbNames.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 25);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 25);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Golf Tournament";
            label2.Click += label2_Click;
            // 
            // tbTour
            // 
            tbTour.Location = new Point(189, 52);
            tbTour.Name = "tbTour";
            tbTour.Size = new Size(132, 23);
            tbTour.TabIndex = 3;
            tbTour.TextChanged += tbTour_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 84);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Round 1";
            // 
            // tbR1
            // 
            tbR1.Location = new Point(262, 81);
            tbR1.Name = "tbR1";
            tbR1.Size = new Size(59, 23);
            tbR1.TabIndex = 5;
            tbR1.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 113);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Round 2";
            // 
            // tbR2
            // 
            tbR2.Location = new Point(262, 110);
            tbR2.Name = "tbR2";
            tbR2.Size = new Size(59, 23);
            tbR2.TabIndex = 5;
            tbR2.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 142);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Round 3";
            // 
            // tbR3
            // 
            tbR3.Location = new Point(262, 139);
            tbR3.Name = "tbR3";
            tbR3.Size = new Size(59, 23);
            tbR3.TabIndex = 5;
            tbR3.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(189, 171);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 4;
            label6.Text = "Round 4";
            // 
            // tbR4
            // 
            tbR4.Location = new Point(262, 168);
            tbR4.Name = "tbR4";
            tbR4.Size = new Size(59, 23);
            tbR4.TabIndex = 5;
            tbR4.Text = "0";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(49, 215);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(246, 215);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 284);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(tbR4);
            Controls.Add(tbR2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(tbR3);
            Controls.Add(label5);
            Controls.Add(tbR1);
            Controls.Add(label3);
            Controls.Add(tbTour);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbNames);
            Name = "Form1";
            Text = "Golf";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbNames;
        private Label label1;
        private Label label2;
        private TextBox tbTour;
        private Label label3;
        private TextBox tbR1;
        private Label label4;
        private TextBox tbR2;
        private Label label5;
        private TextBox tbR3;
        private Label label6;
        private TextBox tbR4;
        private Button btnClose;
        private Button btnSave;
    }
}