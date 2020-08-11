namespace oefening1
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
            this.inactief = new System.Windows.Forms.ListBox();
            this.actief = new System.Windows.Forms.ListBox();
            this.but1 = new System.Windows.Forms.Button();
            this.mijntextbox1 = new System.Windows.Forms.TextBox();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inactief
            // 
            this.inactief.FormattingEnabled = true;
            this.inactief.Location = new System.Drawing.Point(97, 117);
            this.inactief.Name = "inactief";
            this.inactief.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.inactief.Size = new System.Drawing.Size(99, 173);
            this.inactief.TabIndex = 0;
            // 
            // actief
            // 
            this.actief.FormattingEnabled = true;
            this.actief.Location = new System.Drawing.Point(295, 117);
            this.actief.Name = "actief";
            this.actief.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.actief.Size = new System.Drawing.Size(94, 173);
            this.actief.TabIndex = 1;
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(278, 47);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(111, 37);
            this.but1.TabIndex = 2;
            this.but1.Text = "Toevoegen";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.butmijnbutton1_Click);
            // 
            // mijntextbox1
            // 
            this.mijntextbox1.Location = new System.Drawing.Point(71, 56);
            this.mijntextbox1.Name = "mijntextbox1";
            this.mijntextbox1.Size = new System.Drawing.Size(125, 20);
            this.mijntextbox1.TabIndex = 3;
            this.mijntextbox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mijntextbox1_KeyDown);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(214, 164);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(75, 23);
            this.but2.TabIndex = 4;
            this.but2.Text = "=>";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(214, 218);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(75, 23);
            this.but3.TabIndex = 5;
            this.but3.Text = "<=";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.mijntextbox1);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.actief);
            this.Controls.Add(this.inactief);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inactief;
        private System.Windows.Forms.ListBox actief;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.TextBox mijntextbox1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
    }
}

