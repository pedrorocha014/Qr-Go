namespace QrCodeHandler.Pages
{
    partial class PageCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contentField = new System.Windows.Forms.TextBox();
            this.logoPathField = new System.Windows.Forms.TextBox();
            this.searchLogoBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.qrImageField = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrImageField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conteúdo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo";
            // 
            // contentField
            // 
            this.contentField.Location = new System.Drawing.Point(117, 230);
            this.contentField.Name = "contentField";
            this.contentField.Size = new System.Drawing.Size(200, 20);
            this.contentField.TabIndex = 2;
            // 
            // logoPathField
            // 
            this.logoPathField.Location = new System.Drawing.Point(117, 287);
            this.logoPathField.Name = "logoPathField";
            this.logoPathField.Size = new System.Drawing.Size(200, 20);
            this.logoPathField.TabIndex = 3;
            // 
            // searchLogoBtn
            // 
            this.searchLogoBtn.Location = new System.Drawing.Point(284, 287);
            this.searchLogoBtn.Name = "searchLogoBtn";
            this.searchLogoBtn.Size = new System.Drawing.Size(33, 20);
            this.searchLogoBtn.TabIndex = 4;
            this.searchLogoBtn.Text = "...";
            this.searchLogoBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(117, 324);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(200, 43);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "CRIAR";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // qrImageField
            // 
            this.qrImageField.Location = new System.Drawing.Point(117, 3);
            this.qrImageField.Name = "qrImageField";
            this.qrImageField.Size = new System.Drawing.Size(200, 200);
            this.qrImageField.TabIndex = 6;
            this.qrImageField.TabStop = false;
            // 
            // PageCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.qrImageField);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.searchLogoBtn);
            this.Controls.Add(this.logoPathField);
            this.Controls.Add(this.contentField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PageCreate";
            this.Size = new System.Drawing.Size(442, 384);
            ((System.ComponentModel.ISupportInitialize)(this.qrImageField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contentField;
        private System.Windows.Forms.TextBox logoPathField;
        private System.Windows.Forms.Button searchLogoBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.PictureBox qrImageField;
    }
}
