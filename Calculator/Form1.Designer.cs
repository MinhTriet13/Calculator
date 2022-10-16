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
            this.lbSoA = new System.Windows.Forms.Label();
            this.lbSoB = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btKetQua = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSoA
            // 
            this.lbSoA.AutoSize = true;
            this.lbSoA.Location = new System.Drawing.Point(34, 76);
            this.lbSoA.Name = "lbSoA";
            this.lbSoA.Size = new System.Drawing.Size(33, 13);
            this.lbSoA.TabIndex = 0;
            this.lbSoA.Text = "Số A:";
            this.lbSoA.Click += new System.EventHandler(this.txtSoA_Click);
            // 
            // lbSoB
            // 
            this.lbSoB.AutoSize = true;
            this.lbSoB.Location = new System.Drawing.Point(34, 111);
            this.lbSoB.Name = "lbSoB";
            this.lbSoB.Size = new System.Drawing.Size(33, 13);
            this.lbSoB.TabIndex = 0;
            this.lbSoB.Text = "Số B:";
            this.lbSoB.Click += new System.EventHandler(this.txtSoA_Click);
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(34, 146);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(47, 13);
            this.lbKQ.TabIndex = 0;
            this.lbKQ.Text = "Kết quả:";
            this.lbKQ.Click += new System.EventHandler(this.txtSoA_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(114, 76);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(239, 20);
            this.txtSoA.TabIndex = 1;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(114, 108);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(239, 20);
            this.txtSoB.TabIndex = 1;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(114, 143);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(239, 20);
            this.txtKetQua.TabIndex = 1;
            // 
            // btKetQua
            // 
            this.btKetQua.Location = new System.Drawing.Point(71, 193);
            this.btKetQua.Name = "btKetQua";
            this.btKetQua.Size = new System.Drawing.Size(130, 36);
            this.btKetQua.TabIndex = 2;
            this.btKetQua.Text = "Cộng";
            this.btKetQua.UseVisualStyleBackColor = true;
            this.btKetQua.Click += new System.EventHandler(this.btKetQua_Click);
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(223, 193);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(130, 36);
            this.btTru.TabIndex = 2;
            this.btTru.Text = "Trừ";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 377);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbSoB);
            this.Controls.Add(this.lbSoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoA;
        private System.Windows.Forms.Label lbSoB;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btKetQua;
        private System.Windows.Forms.Button btTru;
    }
}

