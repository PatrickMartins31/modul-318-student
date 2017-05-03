namespace Swisstransport
{
    partial class StandortsFahrplan
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbStandort = new System.Windows.Forms.ComboBox();
            this.StandortsFahrplanListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StandortSucheBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbStandort
            // 
            this.CbStandort.FormattingEnabled = true;
            this.CbStandort.Location = new System.Drawing.Point(86, 90);
            this.CbStandort.Name = "CbStandort";
            this.CbStandort.Size = new System.Drawing.Size(121, 21);
            this.CbStandort.TabIndex = 0;
            this.CbStandort.TextUpdate += new System.EventHandler(this.CbStandort_TextUpdate);
            // 
            // StandortsFahrplanListbox
            // 
            this.StandortsFahrplanListbox.FormattingEnabled = true;
            this.StandortsFahrplanListbox.Location = new System.Drawing.Point(213, 89);
            this.StandortsFahrplanListbox.Name = "StandortsFahrplanListbox";
            this.StandortsFahrplanListbox.Size = new System.Drawing.Size(383, 121);
            this.StandortsFahrplanListbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Standorts Fahrplan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dein Standort";
            // 
            // StandortSucheBtn
            // 
            this.StandortSucheBtn.Location = new System.Drawing.Point(86, 127);
            this.StandortSucheBtn.Name = "StandortSucheBtn";
            this.StandortSucheBtn.Size = new System.Drawing.Size(120, 23);
            this.StandortSucheBtn.TabIndex = 4;
            this.StandortSucheBtn.Text = "Suchen";
            this.StandortSucheBtn.UseVisualStyleBackColor = true;
            this.StandortSucheBtn.Click += new System.EventHandler(this.StandortSucheBtn_Click);
            // 
            // StandortsFahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StandortSucheBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StandortsFahrplanListbox);
            this.Controls.Add(this.CbStandort);
            this.Name = "StandortsFahrplan";
            this.Size = new System.Drawing.Size(599, 235);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbStandort;
        private System.Windows.Forms.ListBox StandortsFahrplanListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StandortSucheBtn;
    }
}
