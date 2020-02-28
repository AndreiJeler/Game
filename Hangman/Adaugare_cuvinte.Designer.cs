namespace Hangman
{
    partial class Adaugare_cuvinte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adaugare_cuvinte));
            this.label1 = new System.Windows.Forms.Label();
            this.dificultate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cuvant = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dificultate:";
            // 
            // dificultate
            // 
            this.dificultate.FormattingEnabled = true;
            this.dificultate.Items.AddRange(new object[] {
            "Usor",
            "Normal",
            "Greu"});
            this.dificultate.Location = new System.Drawing.Point(91, 22);
            this.dificultate.Name = "dificultate";
            this.dificultate.Size = new System.Drawing.Size(119, 21);
            this.dificultate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuvantul:";
            // 
            // cuvant
            // 
            this.cuvant.Location = new System.Drawing.Point(91, 65);
            this.cuvant.Name = "cuvant";
            this.cuvant.Size = new System.Drawing.Size(119, 20);
            this.cuvant.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adaugare_cuvinte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 233);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuvant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dificultate);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adaugare_cuvinte";
            this.Text = "Adaugare_cuvinte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dificultate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuvant;
        private System.Windows.Forms.Button button1;
    }
}