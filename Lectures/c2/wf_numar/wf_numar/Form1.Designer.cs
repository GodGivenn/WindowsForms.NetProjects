namespace wf_numar
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce un numar:";
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(175, 38);
            this.tbn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(116, 22);
            this.tbn.TabIndex = 0;
            this.tbn.Text = "0";
            this.tbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbn_KeyPress);
            this.tbn.Validating += new System.ComponentModel.CancelEventHandler(this.tbn_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patratul:";
            // 
            // tbpn
            // 
            this.tbpn.Location = new System.Drawing.Point(175, 160);
            this.tbpn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpn.Name = "tbpn";
            this.tbpn.ReadOnly = true;
            this.tbpn.Size = new System.Drawing.Size(115, 22);
            this.tbpn.TabIndex = 3;
            this.tbpn.Text = "0";
            this.tbpn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get valoare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(353, 59);
            this.lv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(344, 185);
            this.lv.TabIndex = 5;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nrc";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numar";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Patratul";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 288);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbpn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "App WF1";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ErrorProvider err;
    }
}

