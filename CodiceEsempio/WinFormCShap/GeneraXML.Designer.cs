namespace WinFormCShap
{
    partial class GeneraXML
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneraXML));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtPercorsoFile = new System.Windows.Forms.TextBox();
            this.BtnEseguiCodice = new System.Windows.Forms.Button();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.TxtPercorsoFile);
            this.GroupBox1.Controls.Add(this.BtnEseguiCodice);
            this.GroupBox1.Controls.Add(this.RichTextBox1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(528, 447);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Informazioni preliminari";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 401);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(190, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Percorso e nome del file XML generato";
            // 
            // TxtPercorsoFile
            // 
            this.TxtPercorsoFile.Location = new System.Drawing.Point(6, 417);
            this.TxtPercorsoFile.Name = "TxtPercorsoFile";
            this.TxtPercorsoFile.ReadOnly = true;
            this.TxtPercorsoFile.Size = new System.Drawing.Size(516, 20);
            this.TxtPercorsoFile.TabIndex = 2;
            // 
            // BtnEseguiCodice
            // 
            this.BtnEseguiCodice.Location = new System.Drawing.Point(2, 360);
            this.BtnEseguiCodice.Name = "BtnEseguiCodice";
            this.BtnEseguiCodice.Size = new System.Drawing.Size(520, 23);
            this.BtnEseguiCodice.TabIndex = 1;
            this.BtnEseguiCodice.Text = "ESEGUI IL CODICE";
            this.BtnEseguiCodice.UseVisualStyleBackColor = true;
            this.BtnEseguiCodice.Click += new System.EventHandler(this.BtnEseguiCodice_Click);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(7, 20);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(515, 320);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = resources.GetString("RichTextBox1.Text");
            // 
            // GeneraXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 458);
            this.Controls.Add(this.GroupBox1);
            this.Name = "GeneraXML";
            this.Text = "Genera XML";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtPercorsoFile;
        internal System.Windows.Forms.Button BtnEseguiCodice;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
    }
}

