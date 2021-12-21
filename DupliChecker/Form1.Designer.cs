namespace DupliChecker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.originalbtn = new System.Windows.Forms.Button();
            this.original_textBox = new System.Windows.Forms.TextBox();
            this.symlincbtn = new System.Windows.Forms.Button();
            this.symlink_textBox = new System.Windows.Forms.TextBox();
            this.check_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.check_button);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(719, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 16);
            this.label2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.originalbtn);
            this.groupBox1.Controls.Add(this.original_textBox);
            this.groupBox1.Controls.Add(this.symlincbtn);
            this.groupBox1.Controls.Add(this.symlink_textBox);
            this.groupBox1.Location = new System.Drawing.Point(716, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select folder path";
            // 
            // originalbtn
            // 
            this.originalbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.originalbtn.FlatAppearance.BorderSize = 0;
            this.originalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.originalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.originalbtn.Location = new System.Drawing.Point(236, 46);
            this.originalbtn.Name = "originalbtn";
            this.originalbtn.Size = new System.Drawing.Size(142, 32);
            this.originalbtn.TabIndex = 5;
            this.originalbtn.Text = "Original Location";
            this.originalbtn.UseVisualStyleBackColor = false;
            this.originalbtn.Click += new System.EventHandler(this.originalbtn_Click);
            // 
            // original_textBox
            // 
            this.original_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.original_textBox.Location = new System.Drawing.Point(6, 18);
            this.original_textBox.Name = "original_textBox";
            this.original_textBox.Size = new System.Drawing.Size(372, 22);
            this.original_textBox.TabIndex = 3;
            // 
            // symlincbtn
            // 
            this.symlincbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.symlincbtn.FlatAppearance.BorderSize = 0;
            this.symlincbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.symlincbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symlincbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.symlincbtn.Location = new System.Drawing.Point(236, 120);
            this.symlincbtn.Name = "symlincbtn";
            this.symlincbtn.Size = new System.Drawing.Size(142, 32);
            this.symlincbtn.TabIndex = 6;
            this.symlincbtn.Text = "Symlink Location";
            this.symlincbtn.UseVisualStyleBackColor = false;
            this.symlincbtn.Click += new System.EventHandler(this.symlincbtn_Click);
            // 
            // symlink_textBox
            // 
            this.symlink_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symlink_textBox.Location = new System.Drawing.Point(6, 92);
            this.symlink_textBox.Name = "symlink_textBox";
            this.symlink_textBox.Size = new System.Drawing.Size(372, 22);
            this.symlink_textBox.TabIndex = 4;
            // 
            // check_button
            // 
            this.check_button.BackColor = System.Drawing.Color.SlateGray;
            this.check_button.FlatAppearance.BorderSize = 0;
            this.check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.check_button.Location = new System.Drawing.Point(952, 209);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(142, 32);
            this.check_button.TabIndex = 7;
            this.check_button.Text = "Check Duplicate";
            this.check_button.UseVisualStyleBackColor = false;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 28);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(710, 375);
            this.panel4.TabIndex = 2;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(10, 10);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(690, 355);
            this.listBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.delete_button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1112, 47);
            this.panel3.TabIndex = 1;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Salmon;
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_button.Location = new System.Drawing.Point(11, 6);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(142, 32);
            this.delete_button.TabIndex = 8;
            this.delete_button.Text = "Delete All Duplicate ";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 28);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duplicate file name(s)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "DupliChecker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox symlink_textBox;
        private System.Windows.Forms.TextBox original_textBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button symlincbtn;
        private System.Windows.Forms.Button originalbtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

