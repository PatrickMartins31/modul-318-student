namespace Swisstransport
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FahrplanBtn = new System.Windows.Forms.Button();
            this.PanelFahrplan = new System.Windows.Forms.Panel();
            this.StandortsFahrplanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FahrplanBtn
            // 
            this.FahrplanBtn.BackColor = System.Drawing.Color.Turquoise;
            this.FahrplanBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FahrplanBtn.BackgroundImage")));
            this.FahrplanBtn.Location = new System.Drawing.Point(12, 12);
            this.FahrplanBtn.Name = "FahrplanBtn";
            this.FahrplanBtn.Size = new System.Drawing.Size(101, 101);
            this.FahrplanBtn.TabIndex = 0;
            this.FahrplanBtn.UseVisualStyleBackColor = false;
            this.FahrplanBtn.Click += new System.EventHandler(this.FahrplanBtn_Click);
            // 
            // PanelFahrplan
            // 
            this.PanelFahrplan.Location = new System.Drawing.Point(12, 119);
            this.PanelFahrplan.Name = "PanelFahrplan";
            this.PanelFahrplan.Size = new System.Drawing.Size(500, 398);
            this.PanelFahrplan.TabIndex = 1;
            // 
            // StandortsFahrplanBtn
            // 
            this.StandortsFahrplanBtn.BackColor = System.Drawing.Color.White;
            this.StandortsFahrplanBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StandortsFahrplanBtn.BackgroundImage")));
            this.StandortsFahrplanBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.StandortsFahrplanBtn.Location = new System.Drawing.Point(120, 13);
            this.StandortsFahrplanBtn.Name = "StandortsFahrplanBtn";
            this.StandortsFahrplanBtn.Size = new System.Drawing.Size(101, 101);
            this.StandortsFahrplanBtn.TabIndex = 2;
            this.StandortsFahrplanBtn.UseVisualStyleBackColor = false;
            this.StandortsFahrplanBtn.Click += new System.EventHandler(this.StandortsFahrplanBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 529);
            this.Controls.Add(this.StandortsFahrplanBtn);
            this.Controls.Add(this.FahrplanBtn);
            this.Controls.Add(this.PanelFahrplan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FahrplanBtn;
        private System.Windows.Forms.Panel PanelFahrplan;
        private System.Windows.Forms.Button StandortsFahrplanBtn;
    }
}

