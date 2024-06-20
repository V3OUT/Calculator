namespace Calculator
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bAns = new System.Windows.Forms.Button();
            this.bCLR = new System.Windows.Forms.Button();
            this.bp = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bper = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 72);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseWaitCursor = true;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(27, 129);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(54, 23);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.UseWaitCursor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(87, 129);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(52, 23);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.UseWaitCursor = true;
            this.b2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(145, 129);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(54, 23);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.UseWaitCursor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(27, 158);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(54, 23);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.UseWaitCursor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(87, 158);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(52, 23);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.UseWaitCursor = true;
            this.b5.Click += new System.EventHandler(this.button5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(145, 158);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(54, 23);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.UseWaitCursor = true;
            this.b6.Click += new System.EventHandler(this.button6_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(27, 187);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(54, 23);
            this.b7.TabIndex = 7;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.UseWaitCursor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(87, 187);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(52, 23);
            this.b8.TabIndex = 8;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.UseWaitCursor = true;
            this.b8.Click += new System.EventHandler(this.button8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(145, 187);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(54, 23);
            this.b9.TabIndex = 9;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.UseWaitCursor = true;
            this.b9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bAns
            // 
            this.bAns.Location = new System.Drawing.Point(27, 245);
            this.bAns.Name = "bAns";
            this.bAns.Size = new System.Drawing.Size(172, 23);
            this.bAns.TabIndex = 10;
            this.bAns.Text = "Ans";
            this.bAns.UseVisualStyleBackColor = true;
            this.bAns.UseWaitCursor = true;
            this.bAns.Click += new System.EventHandler(this.button10_Click);
            // 
            // bCLR
            // 
            this.bCLR.Location = new System.Drawing.Point(27, 216);
            this.bCLR.Name = "bCLR";
            this.bCLR.Size = new System.Drawing.Size(54, 23);
            this.bCLR.TabIndex = 11;
            this.bCLR.Text = "Clr";
            this.bCLR.UseVisualStyleBackColor = true;
            this.bCLR.UseWaitCursor = true;
            this.bCLR.Click += new System.EventHandler(this.bCLR_Click);
            // 
            // bp
            // 
            this.bp.Location = new System.Drawing.Point(145, 216);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(54, 23);
            this.bp.TabIndex = 12;
            this.bp.Text = ".";
            this.bp.UseVisualStyleBackColor = true;
            this.bp.UseWaitCursor = true;
            this.bp.Click += new System.EventHandler(this.bp_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(87, 214);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(52, 23);
            this.b0.TabIndex = 13;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.UseWaitCursor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bper
            // 
            this.bper.Location = new System.Drawing.Point(205, 131);
            this.bper.Name = "bper";
            this.bper.Size = new System.Drawing.Size(54, 23);
            this.bper.TabIndex = 14;
            this.bper.Text = "%";
            this.bper.UseVisualStyleBackColor = true;
            this.bper.UseWaitCursor = true;
            this.bper.Click += new System.EventHandler(this.button11_Click);
            // 
            // bsub
            // 
            this.bsub.Location = new System.Drawing.Point(205, 216);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(54, 23);
            this.bsub.TabIndex = 15;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.UseWaitCursor = true;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // badd
            // 
            this.badd.Location = new System.Drawing.Point(205, 245);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(54, 23);
            this.badd.TabIndex = 16;
            this.badd.Text = "+";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.UseWaitCursor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(205, 187);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(54, 23);
            this.bdiv.TabIndex = 17;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.UseWaitCursor = true;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bmul
            // 
            this.bmul.Location = new System.Drawing.Point(205, 160);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(54, 23);
            this.bmul.TabIndex = 18;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = true;
            this.bmul.UseWaitCursor = true;
            this.bmul.Click += new System.EventHandler(this.bmul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(291, 289);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bper);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bp);
            this.Controls.Add(this.bCLR);
            this.Controls.Add(this.bAns);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bAns;
        private System.Windows.Forms.Button bCLR;
        private System.Windows.Forms.Button bp;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bper;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bmul;
    }
}

