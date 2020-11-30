namespace QrHandler_WF.Pages
{
    partial class DownloadPage
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadPage));
            this.downloadButton = new System.Windows.Forms.Button();
            this.pathInputField = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.folderSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.Image = ((System.Drawing.Image)(resources.GetObject("downloadButton.Image")));
            this.downloadButton.Location = new System.Drawing.Point(19, 336);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(262, 36);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "DOWNLOAD";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // pathInputField
            // 
            this.pathInputField.Location = new System.Drawing.Point(3, 288);
            this.pathInputField.Name = "pathInputField";
            this.pathInputField.Size = new System.Drawing.Size(259, 20);
            this.pathInputField.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(3, 264);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(88, 21);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "FILE PATH:";
            // 
            // folderSearchButton
            // 
            this.folderSearchButton.Location = new System.Drawing.Point(268, 286);
            this.folderSearchButton.Name = "folderSearchButton";
            this.folderSearchButton.Size = new System.Drawing.Size(33, 23);
            this.folderSearchButton.TabIndex = 3;
            this.folderSearchButton.Text = "...";
            this.folderSearchButton.UseVisualStyleBackColor = true;
            this.folderSearchButton.Click += new System.EventHandler(this.folderSearchButton_Click);
            // 
            // DownloadPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.folderSearchButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathInputField);
            this.Controls.Add(this.downloadButton);
            this.Name = "DownloadPage";
            this.Size = new System.Drawing.Size(304, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox pathInputField;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button folderSearchButton;
    }
}
