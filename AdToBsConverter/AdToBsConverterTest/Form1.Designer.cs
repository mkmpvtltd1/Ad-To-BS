namespace AdToBsConverterTest
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
            this.dtpAd = new System.Windows.Forms.DateTimePicker();
            this.btnAdToBsConverte = new System.Windows.Forms.Button();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpAd
            // 
            this.dtpAd.Location = new System.Drawing.Point(23, 13);
            this.dtpAd.Name = "dtpAd";
            this.dtpAd.Size = new System.Drawing.Size(200, 20);
            this.dtpAd.TabIndex = 0;
            // 
            // btnAdToBsConverte
            // 
            this.btnAdToBsConverte.Location = new System.Drawing.Point(23, 52);
            this.btnAdToBsConverte.Name = "btnAdToBsConverte";
            this.btnAdToBsConverte.Size = new System.Drawing.Size(130, 23);
            this.btnAdToBsConverte.TabIndex = 1;
            this.btnAdToBsConverte.Text = "Ad To Bs Converter";
            this.btnAdToBsConverte.UseVisualStyleBackColor = true;
            this.btnAdToBsConverte.Click += new System.EventHandler(this.btnAdToBsConverte_Click);
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(23, 94);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(200, 20);
            this.txtBS.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 136);
            this.Controls.Add(this.txtBS);
            this.Controls.Add(this.btnAdToBsConverte);
            this.Controls.Add(this.dtpAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpAd;
        private System.Windows.Forms.Button btnAdToBsConverte;
        private System.Windows.Forms.TextBox txtBS;
    }
}

