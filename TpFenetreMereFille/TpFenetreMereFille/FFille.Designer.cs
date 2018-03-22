namespace TpFenetreMereFille
{
    partial class FFille
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
            this.lbNom = new System.Windows.Forms.Label();
            this.tbNomFille = new System.Windows.Forms.TextBox();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(1, 48);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(101, 13);
            this.lbNom.TabIndex = 1;
            this.lbNom.Text = "Je change de nom :";
            // 
            // tbNomFille
            // 
            this.tbNomFille.Location = new System.Drawing.Point(110, 47);
            this.tbNomFille.Name = "tbNomFille";
            this.tbNomFille.Size = new System.Drawing.Size(81, 20);
            this.tbNomFille.TabIndex = 2;
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(98, 101);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(77, 25);
            this.btnMaMere.TabIndex = 3;
            this.btnMaMere.Text = "MaMère";
            this.btnMaMere.UseVisualStyleBackColor = true;
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.tbNomFille);
            this.Controls.Add(this.lbNom);
            this.Name = "FFille";
            this.Text = "Fille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNomFille;
        private System.Windows.Forms.Button btnMaMere;
    }
}