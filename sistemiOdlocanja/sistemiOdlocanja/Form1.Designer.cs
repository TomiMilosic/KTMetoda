namespace sistemiOdlocanja
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DodajPoljabtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.obcutljivosttextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pomocbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj parameter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj alternativo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Izracunaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DodajPoljabtn
            // 
            this.DodajPoljabtn.Location = new System.Drawing.Point(607, 402);
            this.DodajPoljabtn.Name = "DodajPoljabtn";
            this.DodajPoljabtn.Size = new System.Drawing.Size(92, 23);
            this.DodajPoljabtn.TabIndex = 3;
            this.DodajPoljabtn.Text = "Dodaj polja";
            this.DodajPoljabtn.UseVisualStyleBackColor = true;
            this.DodajPoljabtn.Click += new System.EventHandler(this.DodajPoljabtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(930, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Obcutljivost";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // obcutljivosttextbox
            // 
            this.obcutljivosttextbox.Location = new System.Drawing.Point(930, 402);
            this.obcutljivosttextbox.Name = "obcutljivosttextbox";
            this.obcutljivosttextbox.Size = new System.Drawing.Size(75, 20);
            this.obcutljivosttextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(891, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vnesi id parametra(od 1 naprej): ";
            // 
            // pomocbtn
            // 
            this.pomocbtn.Location = new System.Drawing.Point(219, 428);
            this.pomocbtn.Name = "pomocbtn";
            this.pomocbtn.Size = new System.Drawing.Size(174, 23);
            this.pomocbtn.TabIndex = 7;
            this.pomocbtn.Text = "Pomoč!";
            this.pomocbtn.UseVisualStyleBackColor = true;
            this.pomocbtn.Click += new System.EventHandler(this.pomocbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1142, 457);
            this.Controls.Add(this.pomocbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.obcutljivosttextbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DodajPoljabtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DodajPoljabtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox obcutljivosttextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pomocbtn;
    }
}

