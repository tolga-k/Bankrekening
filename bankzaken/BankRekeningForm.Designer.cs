namespace bankzaken
{
    partial class BankRekeningForm
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
            this.tbsaldoLinks = new System.Windows.Forms.TextBox();
            this.btStortLinks = new System.Windows.Forms.Button();
            this.btNeemOp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbstortLinks = new System.Windows.Forms.TextBox();
            this.tbopneemLinks = new System.Windows.Forms.TextBox();
            this.btLinks = new System.Windows.Forms.Button();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbopneemRechts = new System.Windows.Forms.TextBox();
            this.tbstortRechts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btNeemOpRechts = new System.Windows.Forms.Button();
            this.btStortRechts = new System.Windows.Forms.Button();
            this.tbsaldoRechts = new System.Windows.Forms.TextBox();
            this.btRechts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbsaldoLinks
            // 
            this.tbsaldoLinks.Location = new System.Drawing.Point(13, 12);
            this.tbsaldoLinks.Name = "tbsaldoLinks";
            this.tbsaldoLinks.ReadOnly = true;
            this.tbsaldoLinks.Size = new System.Drawing.Size(75, 20);
            this.tbsaldoLinks.TabIndex = 0;
            // 
            // btStortLinks
            // 
            this.btStortLinks.Location = new System.Drawing.Point(13, 75);
            this.btStortLinks.Name = "btStortLinks";
            this.btStortLinks.Size = new System.Drawing.Size(75, 23);
            this.btStortLinks.TabIndex = 2;
            this.btStortLinks.Text = "Storten";
            this.btStortLinks.UseVisualStyleBackColor = true;
            this.btStortLinks.Click += new System.EventHandler(this.btStort_Click);
            // 
            // btNeemOp
            // 
            this.btNeemOp.Location = new System.Drawing.Point(113, 75);
            this.btNeemOp.Name = "btNeemOp";
            this.btNeemOp.Size = new System.Drawing.Size(75, 23);
            this.btNeemOp.TabIndex = 3;
            this.btNeemOp.Text = "Opnemen";
            this.btNeemOp.UseVisualStyleBackColor = true;
            this.btNeemOp.Click += new System.EventHandler(this.btNeemOp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bedrag op rekening";
            // 
            // tbstortLinks
            // 
            this.tbstortLinks.Location = new System.Drawing.Point(13, 49);
            this.tbstortLinks.Name = "tbstortLinks";
            this.tbstortLinks.Size = new System.Drawing.Size(75, 20);
            this.tbstortLinks.TabIndex = 5;
            this.tbstortLinks.Text = "0";
            // 
            // tbopneemLinks
            // 
            this.tbopneemLinks.Location = new System.Drawing.Point(113, 49);
            this.tbopneemLinks.Name = "tbopneemLinks";
            this.tbopneemLinks.Size = new System.Drawing.Size(75, 20);
            this.tbopneemLinks.TabIndex = 6;
            this.tbopneemLinks.Text = "0";
            // 
            // btLinks
            // 
            this.btLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLinks.Location = new System.Drawing.Point(113, 149);
            this.btLinks.Name = "btLinks";
            this.btLinks.Size = new System.Drawing.Size(99, 23);
            this.btLinks.TabIndex = 7;
            this.btLinks.Text = "<<";
            this.btLinks.UseVisualStyleBackColor = true;
            this.btLinks.Click += new System.EventHandler(this.btLinks_Click);
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(113, 123);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(195, 20);
            this.tbNaam.TabIndex = 8;
            // 
            // tbopneemRechts
            // 
            this.tbopneemRechts.Location = new System.Drawing.Point(333, 49);
            this.tbopneemRechts.Name = "tbopneemRechts";
            this.tbopneemRechts.Size = new System.Drawing.Size(75, 20);
            this.tbopneemRechts.TabIndex = 14;
            this.tbopneemRechts.Text = "0";
            // 
            // tbstortRechts
            // 
            this.tbstortRechts.Location = new System.Drawing.Point(233, 49);
            this.tbstortRechts.Name = "tbstortRechts";
            this.tbstortRechts.Size = new System.Drawing.Size(75, 20);
            this.tbstortRechts.TabIndex = 13;
            this.tbstortRechts.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bedrag op rekening";
            // 
            // btNeemOpRechts
            // 
            this.btNeemOpRechts.Location = new System.Drawing.Point(333, 75);
            this.btNeemOpRechts.Name = "btNeemOpRechts";
            this.btNeemOpRechts.Size = new System.Drawing.Size(75, 23);
            this.btNeemOpRechts.TabIndex = 11;
            this.btNeemOpRechts.Text = "Opnemen";
            this.btNeemOpRechts.UseVisualStyleBackColor = true;
            this.btNeemOpRechts.Click += new System.EventHandler(this.btNeemOpRechts_Click);
            // 
            // btStortRechts
            // 
            this.btStortRechts.Location = new System.Drawing.Point(233, 75);
            this.btStortRechts.Name = "btStortRechts";
            this.btStortRechts.Size = new System.Drawing.Size(75, 23);
            this.btStortRechts.TabIndex = 10;
            this.btStortRechts.Text = "Storten";
            this.btStortRechts.UseVisualStyleBackColor = true;
            this.btStortRechts.Click += new System.EventHandler(this.btStortRechts_Click);
            // 
            // tbsaldoRechts
            // 
            this.tbsaldoRechts.Location = new System.Drawing.Point(233, 12);
            this.tbsaldoRechts.Name = "tbsaldoRechts";
            this.tbsaldoRechts.ReadOnly = true;
            this.tbsaldoRechts.Size = new System.Drawing.Size(75, 20);
            this.tbsaldoRechts.TabIndex = 9;
            // 
            // btRechts
            // 
            this.btRechts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechts.Location = new System.Drawing.Point(219, 149);
            this.btRechts.Name = "btRechts";
            this.btRechts.Size = new System.Drawing.Size(89, 23);
            this.btRechts.TabIndex = 15;
            this.btRechts.Text = ">>";
            this.btRechts.UseVisualStyleBackColor = true;
            this.btRechts.Click += new System.EventHandler(this.btRechts_Click);
            // 
            // BankRekeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 184);
            this.Controls.Add(this.btRechts);
            this.Controls.Add(this.tbopneemRechts);
            this.Controls.Add(this.tbstortRechts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btNeemOpRechts);
            this.Controls.Add(this.btStortRechts);
            this.Controls.Add(this.tbsaldoRechts);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.btLinks);
            this.Controls.Add(this.tbopneemLinks);
            this.Controls.Add(this.tbstortLinks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNeemOp);
            this.Controls.Add(this.btStortLinks);
            this.Controls.Add(this.tbsaldoLinks);
            this.Name = "BankRekeningForm";
            this.Text = "Bankrekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbsaldoLinks;
        private System.Windows.Forms.Button btStortLinks;
        private System.Windows.Forms.Button btNeemOp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbstortLinks;
        private System.Windows.Forms.TextBox tbopneemLinks;
        private System.Windows.Forms.Button btLinks;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbopneemRechts;
        private System.Windows.Forms.TextBox tbstortRechts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btNeemOpRechts;
        private System.Windows.Forms.Button btStortRechts;
        private System.Windows.Forms.TextBox tbsaldoRechts;
        private System.Windows.Forms.Button btRechts;
    }
}

