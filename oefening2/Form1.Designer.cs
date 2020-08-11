namespace oefening2
{
    partial class Form1
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.Geslacht = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.gbProvince = new System.Windows.Forms.GroupBox();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.Geslacht.SuspendLayout();
            this.gbProvince.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(31, 47);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(35, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Naam";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(30, 79);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(34, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Adres";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(29, 108);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(41, 13);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "leefTijd";
            // 
            // Geslacht
            // 
            this.Geslacht.Controls.Add(this.rb2);
            this.Geslacht.Controls.Add(this.rb1);
            this.Geslacht.Location = new System.Drawing.Point(32, 135);
            this.Geslacht.Name = "Geslacht";
            this.Geslacht.Size = new System.Drawing.Size(98, 100);
            this.Geslacht.TabIndex = 3;
            this.Geslacht.TabStop = false;
            this.Geslacht.Text = "Geslacht";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(6, 54);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(46, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Man";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 31);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(55, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Vrouw";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // gbProvince
            // 
            this.gbProvince.Controls.Add(this.rb7);
            this.gbProvince.Controls.Add(this.rb6);
            this.gbProvince.Controls.Add(this.rb5);
            this.gbProvince.Controls.Add(this.rb4);
            this.gbProvince.Controls.Add(this.rb3);
            this.gbProvince.Location = new System.Drawing.Point(167, 135);
            this.gbProvince.Name = "gbProvince";
            this.gbProvince.Size = new System.Drawing.Size(125, 136);
            this.gbProvince.TabIndex = 4;
            this.gbProvince.TabStop = false;
            this.gbProvince.Text = "Province";
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Location = new System.Drawing.Point(6, 111);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(93, 17);
            this.rb7.TabIndex = 9;
            this.rb7.TabStop = true;
            this.rb7.Text = "West Flanders";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(6, 88);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(89, 17);
            this.rb6.TabIndex = 3;
            this.rb6.TabStop = true;
            this.rb6.Text = "East Flanders";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(6, 65);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(100, 17);
            this.rb5.TabIndex = 2;
            this.rb5.TabStop = true;
            this.rb5.Text = "Flemish Brabant";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(6, 42);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(62, 17);
            this.rb4.TabIndex = 1;
            this.rb4.TabStop = true;
            this.rb4.Text = "Limburg";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(6, 19);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(64, 17);
            this.rb3.TabIndex = 0;
            this.rb3.TabStop = true;
            this.rb3.Text = "Antwerp";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(101, 47);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 5;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(101, 79);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 6;
            // 
            // nud
            // 
            this.nud.AllowDrop = true;
            this.nud.Location = new System.Drawing.Point(101, 108);
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(120, 20);
            this.nud.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Indienen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(524, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.gbProvince);
            this.Controls.Add(this.Geslacht);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Geslacht.ResumeLayout(false);
            this.Geslacht.PerformLayout();
            this.gbProvince.ResumeLayout(false);
            this.gbProvince.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lboefening2;
        private System.Windows.Forms.TextBox tboefening2;
        private System.Windows.Forms.Label lb1oefening2;
        private System.Windows.Forms.TextBox tb1oefening2;
        private System.Windows.Forms.NumericUpDown nudoefening2;
        private System.Windows.Forms.Label lb2oefening2;
        private System.Windows.Forms.RadioButton rboefening1;
        private System.Windows.Forms.RadioButton rb1oefening2;
        private System.Windows.Forms.Label lb3oefening3;
        private System.Windows.Forms.Label lb4oefening2;
        private System.Windows.Forms.RadioButton rb2oefening2;
        private System.Windows.Forms.RadioButton rb3oefening2;
        private System.Windows.Forms.RadioButton rb4oefening2;
        private System.Windows.Forms.RadioButton rb5oefening2;
        private System.Windows.Forms.RadioButton rb6oefening2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb6oefening2;
        private System.Windows.Forms.RadioButton rb7oefening2;
        private System.Windows.Forms.RadioButton rb8oefening2;
        private System.Windows.Forms.RadioButton rb9oefening2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label lb7oefening2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Button butoefening2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.GroupBox Geslacht;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox gbProvince;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Button button1;
    }
}

