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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopyFirst = new System.Windows.Forms.Button();
            this.btnLog10 = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.BtnSign = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.lblFirstNr = new System.Windows.Forms.Label();
            this.txtbFirstNr = new System.Windows.Forms.TextBox();
            this.lblSecNr = new System.Windows.Forms.Label();
            this.txtbSecondNr = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtbRes = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCopyFirst);
            this.groupBox1.Controls.Add(this.btnLog10);
            this.groupBox1.Controls.Add(this.btnTan);
            this.groupBox1.Controls.Add(this.btnAbs);
            this.groupBox1.Controls.Add(this.btnLog);
            this.groupBox1.Controls.Add(this.btnCos);
            this.groupBox1.Controls.Add(this.btnMax);
            this.groupBox1.Controls.Add(this.btnSqrt);
            this.groupBox1.Controls.Add(this.btnSin);
            this.groupBox1.Controls.Add(this.btnMin);
            this.groupBox1.Controls.Add(this.btnExp);
            this.groupBox1.Controls.Add(this.btnPow);
            this.groupBox1.Controls.Add(this.BtnSign);
            this.groupBox1.Controls.Add(this.btnC);
            this.groupBox1.Location = new System.Drawing.Point(303, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCopyFirst
            // 
            this.btnCopyFirst.AllowDrop = true;
            this.btnCopyFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyFirst.Location = new System.Drawing.Point(118, 187);
            this.btnCopyFirst.Name = "btnCopyFirst";
            this.btnCopyFirst.Size = new System.Drawing.Size(106, 50);
            this.btnCopyFirst.TabIndex = 0;
            this.btnCopyFirst.Text = "Copy Res to First";
            this.btnCopyFirst.UseVisualStyleBackColor = true;
            this.btnCopyFirst.Click += new System.EventHandler(this.btnCopyFirst_Click);
            // 
            // btnLog10
            // 
            this.btnLog10.AllowDrop = true;
            this.btnLog10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog10.Location = new System.Drawing.Point(174, 131);
            this.btnLog10.Name = "btnLog10";
            this.btnLog10.Size = new System.Drawing.Size(50, 50);
            this.btnLog10.TabIndex = 0;
            this.btnLog10.Text = "Log10";
            this.btnLog10.UseVisualStyleBackColor = true;
            this.btnLog10.Click += new System.EventHandler(this.btnLog10_Click);
            // 
            // btnTan
            // 
            this.btnTan.AllowDrop = true;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(174, 75);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(50, 50);
            this.btnTan.TabIndex = 0;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.AllowDrop = true;
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbs.Location = new System.Drawing.Point(174, 19);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(50, 50);
            this.btnAbs.TabIndex = 0;
            this.btnAbs.Text = "Abs";
            this.btnAbs.UseVisualStyleBackColor = true;
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // btnLog
            // 
            this.btnLog.AllowDrop = true;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(118, 131);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(50, 50);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnCos
            // 
            this.btnCos.AllowDrop = true;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(118, 75);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(50, 50);
            this.btnCos.TabIndex = 0;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnMax
            // 
            this.btnMax.AllowDrop = true;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(118, 19);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 50);
            this.btnMax.TabIndex = 0;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.AllowDrop = true;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(62, 131);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(50, 50);
            this.btnSqrt.TabIndex = 0;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSin
            // 
            this.btnSin.AllowDrop = true;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(62, 75);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(50, 50);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnMin
            // 
            this.btnMin.AllowDrop = true;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(62, 19);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 50);
            this.btnMin.TabIndex = 0;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExp
            // 
            this.btnExp.AllowDrop = true;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(6, 187);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(50, 50);
            this.btnExp.TabIndex = 0;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnPow
            // 
            this.btnPow.AllowDrop = true;
            this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow.Location = new System.Drawing.Point(6, 131);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(50, 50);
            this.btnPow.TabIndex = 0;
            this.btnPow.Text = "Pow";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // BtnSign
            // 
            this.BtnSign.AllowDrop = true;
            this.BtnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSign.Location = new System.Drawing.Point(6, 75);
            this.BtnSign.Name = "BtnSign";
            this.BtnSign.Size = new System.Drawing.Size(50, 50);
            this.BtnSign.TabIndex = 0;
            this.BtnSign.Text = "Sign";
            this.BtnSign.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.AllowDrop = true;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(6, 19);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // lblFirstNr
            // 
            this.lblFirstNr.AutoSize = true;
            this.lblFirstNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNr.Location = new System.Drawing.Point(11, 15);
            this.lblFirstNr.Name = "lblFirstNr";
            this.lblFirstNr.Size = new System.Drawing.Size(106, 18);
            this.lblFirstNr.TabIndex = 1;
            this.lblFirstNr.Text = "First Number";
            this.lblFirstNr.Click += new System.EventHandler(this.lblFirstNr_Click);
            // 
            // txtbFirstNr
            // 
            this.txtbFirstNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFirstNr.Location = new System.Drawing.Point(147, 12);
            this.txtbFirstNr.Name = "txtbFirstNr";
            this.txtbFirstNr.Size = new System.Drawing.Size(119, 24);
            this.txtbFirstNr.TabIndex = 2;
            this.txtbFirstNr.TextChanged += new System.EventHandler(this.txtbFirstNr_TextChanged);
            this.txtbFirstNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFirstNr_KeyPress);
            // 
            // lblSecNr
            // 
            this.lblSecNr.AutoSize = true;
            this.lblSecNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecNr.Location = new System.Drawing.Point(11, 60);
            this.lblSecNr.Name = "lblSecNr";
            this.lblSecNr.Size = new System.Drawing.Size(129, 18);
            this.lblSecNr.TabIndex = 1;
            this.lblSecNr.Text = "Second Number";
            this.lblSecNr.Click += new System.EventHandler(this.lblSecNr_Click);
            // 
            // txtbSecondNr
            // 
            this.txtbSecondNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSecondNr.Location = new System.Drawing.Point(147, 57);
            this.txtbSecondNr.Name = "txtbSecondNr";
            this.txtbSecondNr.Size = new System.Drawing.Size(119, 24);
            this.txtbSecondNr.TabIndex = 2;
            this.txtbSecondNr.TextChanged += new System.EventHandler(this.txtbSecondNr_TextChanged);
            this.txtbSecondNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbSecondNr_KeyPress);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(11, 103);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(56, 18);
            this.lblRes.TabIndex = 1;
            this.lblRes.Text = "Result";
            this.lblRes.Click += new System.EventHandler(this.lblRes_Click);
            // 
            // txtbRes
            // 
            this.txtbRes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbRes.Location = new System.Drawing.Point(147, 100);
            this.txtbRes.Name = "txtbRes";
            this.txtbRes.ReadOnly = true;
            this.txtbRes.Size = new System.Drawing.Size(119, 24);
            this.txtbRes.TabIndex = 2;
            this.txtbRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbRes.TextChanged += new System.EventHandler(this.txtbRes_TextChanged);
            this.txtbRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbRes_KeyPress);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(14, 143);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(105, 105);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(161, 144);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(105, 105);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 263);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtbRes);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtbSecondNr);
            this.Controls.Add(this.lblSecNr);
            this.Controls.Add(this.txtbFirstNr);
            this.Controls.Add(this.lblFirstNr);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCopyFirst;
        private System.Windows.Forms.Button btnLog10;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button BtnSign;
        private System.Windows.Forms.Label lblFirstNr;
        private System.Windows.Forms.TextBox txtbFirstNr;
        private System.Windows.Forms.Label lblSecNr;
        private System.Windows.Forms.TextBox txtbSecondNr;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txtbRes;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
    }
}

