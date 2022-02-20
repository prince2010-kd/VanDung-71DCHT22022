namespace VanDung_71DCHT22022
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
            this.btnKq = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblx2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKq
            // 
            this.btnKq.Location = new System.Drawing.Point(321, 405);
            this.btnKq.Name = "btnKq";
            this.btnKq.Size = new System.Drawing.Size(138, 42);
            this.btnKq.TabIndex = 15;
            this.btnKq.Text = "Giải";
            this.btnKq.UseVisualStyleBackColor = true;
            this.btnKq.Click += new System.EventHandler(this.btnKq_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "x2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(490, 254);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 34);
            this.txtC.TabIndex = 13;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(427, 268);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 20);
            this.lblX.TabIndex = 12;
            this.lblX.Text = "x";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(321, 256);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 32);
            this.txtB.TabIndex = 11;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Location = new System.Drawing.Point(202, 66);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(0, 16);
            this.lblx2.TabIndex = 10;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(148, 256);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 32);
            this.txtA.TabIndex = 9;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(636, 272);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(24, 16);
            this.lblkq.TabIndex = 16;
            this.lblkq.Text = "= 0";
            this.lblkq.Click += new System.EventHandler(this.lblkq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::VanDung_71DCHT22022.Properties.Resources._271992095_899735600689967_3524612435612824358_n;
            this.ClientSize = new System.Drawing.Size(836, 545);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.btnKq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblx2);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblkq;
    }
}

