namespace Swisstransport
{
    partial class Fahrplan
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
            this.CbAbfahrtsOrt = new System.Windows.Forms.ComboBox();
            this.CbAnkunftsort = new System.Windows.Forms.ComboBox();
            this.SuchenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.FahrplanListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // CbAbfahrtsOrt
            // 
            this.CbAbfahrtsOrt.FormattingEnabled = true;
            this.CbAbfahrtsOrt.Location = new System.Drawing.Point(43, 70);
            this.CbAbfahrtsOrt.Name = "CbAbfahrtsOrt";
            this.CbAbfahrtsOrt.Size = new System.Drawing.Size(151, 21);
            this.CbAbfahrtsOrt.TabIndex = 0;
            this.CbAbfahrtsOrt.TextUpdate += new System.EventHandler(this.CbAbfahrtsOrt_TextUpdate);
            // 
            // CbAnkunftsort
            // 
            this.CbAnkunftsort.FormattingEnabled = true;
            this.CbAnkunftsort.Location = new System.Drawing.Point(43, 101);
            this.CbAnkunftsort.Name = "CbAnkunftsort";
            this.CbAnkunftsort.Size = new System.Drawing.Size(151, 21);
            this.CbAnkunftsort.TabIndex = 1;
            this.CbAnkunftsort.TextUpdate += new System.EventHandler(this.CbAnkunftsort_TextUpdate);
            // 
            // SuchenBtn
            // 
            this.SuchenBtn.Location = new System.Drawing.Point(43, 128);
            this.SuchenBtn.Name = "SuchenBtn";
            this.SuchenBtn.Size = new System.Drawing.Size(151, 38);
            this.SuchenBtn.TabIndex = 2;
            this.SuchenBtn.Text = "Suchen";
            this.SuchenBtn.UseVisualStyleBackColor = true;
            this.SuchenBtn.Click += new System.EventHandler(this.SuchenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nach";
            // 
            // Datum
            // 
            this.Datum.CustomFormat = "dd.MM.yyyy || HH.mm";
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Datum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Datum.Location = new System.Drawing.Point(43, 172);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(151, 20);
            this.Datum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fahrplan";
            // 
            // FahrplanListView
            // 
            this.FahrplanListView.Location = new System.Drawing.Point(43, 199);
            this.FahrplanListView.Name = "FahrplanListView";
            this.FahrplanListView.Size = new System.Drawing.Size(556, 130);
            this.FahrplanListView.TabIndex = 8;
            this.FahrplanListView.UseCompatibleStateImageBehavior = false;
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FahrplanListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SuchenBtn);
            this.Controls.Add(this.CbAnkunftsort);
            this.Controls.Add(this.CbAbfahrtsOrt);
            this.Name = "Fahrplan";
            this.Size = new System.Drawing.Size(602, 369);
            this.Load += new System.EventHandler(this.Fahrplan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbAbfahrtsOrt;
        private System.Windows.Forms.ComboBox CbAnkunftsort;
        private System.Windows.Forms.Button SuchenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView FahrplanListView;
    }
}
