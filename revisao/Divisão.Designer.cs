namespace revisao
{
    partial class Divisão
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
            this.tx_Valor2 = new System.Windows.Forms.TextBox();
            this.tx_Valor1 = new System.Windows.Forms.TextBox();
            this.bt_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_Valor2
            // 
            this.tx_Valor2.Location = new System.Drawing.Point(96, 89);
            this.tx_Valor2.Multiline = true;
            this.tx_Valor2.Name = "tx_Valor2";
            this.tx_Valor2.Size = new System.Drawing.Size(114, 30);
            this.tx_Valor2.TabIndex = 0;
            // 
            // tx_Valor1
            // 
            this.tx_Valor1.Location = new System.Drawing.Point(96, 33);
            this.tx_Valor1.Multiline = true;
            this.tx_Valor1.Name = "tx_Valor1";
            this.tx_Valor1.Size = new System.Drawing.Size(114, 30);
            this.tx_Valor1.TabIndex = 1;
            // 
            // bt_Calcular
            // 
            this.bt_Calcular.Location = new System.Drawing.Point(115, 143);
            this.bt_Calcular.Name = "bt_Calcular";
            this.bt_Calcular.Size = new System.Drawing.Size(83, 30);
            this.bt_Calcular.TabIndex = 2;
            this.bt_Calcular.Text = "Calcular";
            this.bt_Calcular.UseVisualStyleBackColor = true;
            this.bt_Calcular.Click += new System.EventHandler(this.bt_Calcular_Click);
            // 
            // Divisão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.bt_Calcular);
            this.Controls.Add(this.tx_Valor1);
            this.Controls.Add(this.tx_Valor2);
            this.Name = "Divisão";
            this.Text = "Divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_Valor2;
        private System.Windows.Forms.TextBox tx_Valor1;
        private System.Windows.Forms.Button bt_Calcular;
    }
}