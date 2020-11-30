namespace QrHandler_WF.Pages
{
    partial class CreatePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePage));
            this.contentInputField = new System.Windows.Forms.TextBox();
            this.createQrButton = new System.Windows.Forms.Button();
            this.contentLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contentInputField
            // 
            this.contentInputField.Location = new System.Drawing.Point(29, 305);
            this.contentInputField.Name = "contentInputField";
            this.contentInputField.Size = new System.Drawing.Size(250, 20);
            this.contentInputField.TabIndex = 5;
            // 
            // createQrButton
            // 
            this.createQrButton.FlatAppearance.BorderSize = 0;
            this.createQrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createQrButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQrButton.ForeColor = System.Drawing.Color.White;
            this.createQrButton.Image = ((System.Drawing.Image)(resources.GetObject("createQrButton.Image")));
            this.createQrButton.Location = new System.Drawing.Point(29, 328);
            this.createQrButton.Name = "createQrButton";
            this.createQrButton.Size = new System.Drawing.Size(250, 53);
            this.createQrButton.TabIndex = 4;
            this.createQrButton.Text = "CREATE";
            this.createQrButton.UseVisualStyleBackColor = true;
            this.createQrButton.Click += new System.EventHandler(this.createQrButton_Click);
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLabel.Location = new System.Drawing.Point(25, 282);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(73, 20);
            this.contentLabel.TabIndex = 7;
            this.contentLabel.Text = "Content:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CreatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.contentInputField);
            this.Controls.Add(this.createQrButton);
            this.Name = "CreatePage";
            this.Size = new System.Drawing.Size(304, 384);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentInputField;
        private System.Windows.Forms.Button createQrButton;
        private System.Windows.Forms.Label contentLabel;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
