
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbtg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gr = new WindowsFormsApp1.Grafic();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cbtg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 40);
            this.panel1.TabIndex = 0;
            // 
            // cbtg
            // 
            this.cbtg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtg.FormattingEnabled = true;
            this.cbtg.Items.AddRange(new object[] {
            "Bar",
            "Pie",
            "Line"});
            this.cbtg.Location = new System.Drawing.Point(112, 9);
            this.cbtg.Name = "cbtg";
            this.cbtg.Size = new System.Drawing.Size(135, 21);
            this.cbtg.TabIndex = 1;
            this.cbtg.SelectedIndexChanged += new System.EventHandler(this.cbtg_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alege Tip Grafic:";
            // 
            // gr
            // 
            this.gr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr.Location = new System.Drawing.Point(0, 40);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(753, 453);
            this.gr.TabIndex = 1;
            this.gr.Text = "grafic1";
            this.gr.Tip_Grafic = 0;
            this.gr.Valori = null;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 493);
            this.Controls.Add(this.gr);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vizualizarea Grafica a Valorii Materialelor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbtg;
        private System.Windows.Forms.Label label1;
        public Grafic gr;
    }
}