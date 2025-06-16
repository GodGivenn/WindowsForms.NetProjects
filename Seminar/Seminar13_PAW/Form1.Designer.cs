namespace Seminar13_PAW
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
            this.tv = new System.Windows.Forms.TreeView();
            this.tb = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_fv = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(27, 30);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(787, 673);
            this.tv.TabIndex = 2;
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(870, 159);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(208, 26);
            this.tb.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(1108, 135);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(106, 75);
            this.btn.TabIndex = 1;
            this.btn.Text = "Adauga";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(870, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frecventa:";
            // 
            // tb_fv
            // 
            this.tb_fv.Location = new System.Drawing.Point(968, 252);
            this.tb_fv.Name = "tb_fv";
            this.tb_fv.ReadOnly = true;
            this.tb_fv.Size = new System.Drawing.Size(357, 26);
            this.tb_fv.TabIndex = 4;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(846, 328);
            this.textB.Name = "textB";
            this.textB.ReadOnly = true;
            this.textB.Size = new System.Drawing.Size(444, 26);
            this.textB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(981, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "S-R-D";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 757);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.tb_fv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.tv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_fv;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Button button1;
    }
}

