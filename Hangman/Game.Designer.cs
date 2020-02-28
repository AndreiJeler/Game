namespace Hangman
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmareParolaAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareCuvinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCuvinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optiuniToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optiuniToolStripMenuItem
            // 
            this.optiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmareParolaAdminToolStripMenuItem,
            this.adaugareCuvinteToolStripMenuItem,
            this.listaCuvinteToolStripMenuItem});
            this.optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            this.optiuniToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.optiuniToolStripMenuItem.Text = "Optiuni";
            // 
            // confirmareParolaAdminToolStripMenuItem
            // 
            this.confirmareParolaAdminToolStripMenuItem.Name = "confirmareParolaAdminToolStripMenuItem";
            this.confirmareParolaAdminToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.confirmareParolaAdminToolStripMenuItem.Text = "Confirmare parola admin";
            this.confirmareParolaAdminToolStripMenuItem.Click += new System.EventHandler(this.confirmareParolaAdminToolStripMenuItem_Click);
            // 
            // adaugareCuvinteToolStripMenuItem
            // 
            this.adaugareCuvinteToolStripMenuItem.Name = "adaugareCuvinteToolStripMenuItem";
            this.adaugareCuvinteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.adaugareCuvinteToolStripMenuItem.Text = "Adaugare cuvinte";
            this.adaugareCuvinteToolStripMenuItem.Visible = false;
            this.adaugareCuvinteToolStripMenuItem.Click += new System.EventHandler(this.adaugareCuvinteToolStripMenuItem_Click);
            // 
            // listaCuvinteToolStripMenuItem
            // 
            this.listaCuvinteToolStripMenuItem.Name = "listaCuvinteToolStripMenuItem";
            this.listaCuvinteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.listaCuvinteToolStripMenuItem.Text = "Lista cuvinte";
            this.listaCuvinteToolStripMenuItem.Visible = false;
            this.listaCuvinteToolStripMenuItem.Click += new System.EventHandler(this.listaCuvinteToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(201, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Joc nou";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(201, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Highscores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(201, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Usor\r\n<4 litere\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(201, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Normal\r\n5-6 litere\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(201, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "Greu\r\n>6 litere\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(460, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 65);
            this.button6.TabIndex = 6;
            this.button6.Text = "Inapoi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 365);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmareParolaAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareCuvinteToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCuvinteToolStripMenuItem;
        private System.Windows.Forms.Button button6;
    }
}