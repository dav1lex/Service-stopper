namespace AppStopper17_0
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.stoppAppB = new System.Windows.Forms.Button();
            this.errorTB = new System.Windows.Forms.RichTextBox();
            this.servCB = new System.Windows.Forms.ComboBox();
            this.updateB = new System.Windows.Forms.Button();
            this.showip = new System.Windows.Forms.Button();
            this.iplabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // stoppAppB
            // 
            this.stoppAppB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stoppAppB.Location = new System.Drawing.Point(67, 29);
            this.stoppAppB.Margin = new System.Windows.Forms.Padding(2);
            this.stoppAppB.Name = "stoppAppB";
            this.stoppAppB.Size = new System.Drawing.Size(63, 51);
            this.stoppAppB.TabIndex = 1;
            this.stoppAppB.Text = "Stop Service";
            this.stoppAppB.UseVisualStyleBackColor = false;
            this.stoppAppB.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorTB
            // 
            this.errorTB.Location = new System.Drawing.Point(11, 158);
            this.errorTB.Margin = new System.Windows.Forms.Padding(2);
            this.errorTB.Name = "errorTB";
            this.errorTB.Size = new System.Drawing.Size(191, 103);
            this.errorTB.TabIndex = 2;
            this.errorTB.Text = "";
            // 
            // servCB
            // 
            this.servCB.FormattingEnabled = true;
            this.servCB.Location = new System.Drawing.Point(134, 36);
            this.servCB.Margin = new System.Windows.Forms.Padding(2);
            this.servCB.Name = "servCB";
            this.servCB.Size = new System.Drawing.Size(201, 21);
            this.servCB.TabIndex = 7;
            // 
            // updateB
            // 
            this.updateB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateB.Location = new System.Drawing.Point(206, 193);
            this.updateB.Margin = new System.Windows.Forms.Padding(2);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(63, 31);
            this.updateB.TabIndex = 9;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = false;
            // 
            // showip
            // 
            this.showip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showip.Location = new System.Drawing.Point(67, 95);
            this.showip.Margin = new System.Windows.Forms.Padding(2);
            this.showip.Name = "showip";
            this.showip.Size = new System.Drawing.Size(63, 31);
            this.showip.TabIndex = 10;
            this.showip.Text = "show ip";
            this.showip.UseVisualStyleBackColor = false;
            this.showip.Click += new System.EventHandler(this.showip_Click);
            // 
            // iplabel
            // 
            this.iplabel.AutoSize = true;
            this.iplabel.Location = new System.Drawing.Point(200, 104);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(0, 13);
            this.iplabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 272);
            this.Controls.Add(this.iplabel);
            this.Controls.Add(this.showip);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.servCB);
            this.Controls.Add(this.errorTB);
            this.Controls.Add(this.stoppAppB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Service Stopper";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button stoppAppB;
        private System.Windows.Forms.RichTextBox errorTB;
        private System.Windows.Forms.ComboBox servCB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Button showip;
        private System.Windows.Forms.Label iplabel;
    }
}

