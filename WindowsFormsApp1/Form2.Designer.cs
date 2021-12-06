
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.stanKonta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stan_konta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.przelew = new System.Windows.Forms.Button();
            this.wyplata = new System.Windows.Forms.Button();
            this.wplata = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stanKonta
            // 
            this.stanKonta.AutoSize = true;
            this.stanKonta.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stanKonta.Location = new System.Drawing.Point(593, 63);
            this.stanKonta.Name = "stanKonta";
            this.stanKonta.Size = new System.Drawing.Size(81, 38);
            this.stanKonta.TabIndex = 1;
            this.stanKonta.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(424, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stan Konta:";
            // 
            // stan_konta
            // 
            this.stan_konta.AutoSize = true;
            this.stan_konta.BackColor = System.Drawing.Color.Black;
            this.stan_konta.Dock = System.Windows.Forms.DockStyle.Top;
            this.stan_konta.FlatAppearance.BorderSize = 0;
            this.stan_konta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stan_konta.ForeColor = System.Drawing.Color.White;
            this.stan_konta.Location = new System.Drawing.Point(0, 0);
            this.stan_konta.Name = "stan_konta";
            this.stan_konta.Size = new System.Drawing.Size(200, 100);
            this.stan_konta.TabIndex = 2;
            this.stan_konta.Text = "Stan Konta";
            this.stan_konta.UseVisualStyleBackColor = false;
            this.stan_konta.Click += new System.EventHandler(this.stan_konta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.przelew);
            this.panel1.Controls.Add(this.wyplata);
            this.panel1.Controls.Add(this.wplata);
            this.panel1.Controls.Add(this.stan_konta);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 500);
            this.panel1.TabIndex = 3;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Black;
            this.logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(0, 400);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(200, 100);
            this.logout.TabIndex = 6;
            this.logout.Text = "Wyloguj";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // przelew
            // 
            this.przelew.AutoSize = true;
            this.przelew.BackColor = System.Drawing.Color.Black;
            this.przelew.Dock = System.Windows.Forms.DockStyle.Top;
            this.przelew.FlatAppearance.BorderSize = 0;
            this.przelew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przelew.ForeColor = System.Drawing.Color.White;
            this.przelew.Location = new System.Drawing.Point(0, 300);
            this.przelew.Name = "przelew";
            this.przelew.Size = new System.Drawing.Size(200, 100);
            this.przelew.TabIndex = 5;
            this.przelew.Text = "Przelew";
            this.przelew.UseVisualStyleBackColor = false;
            this.przelew.Click += new System.EventHandler(this.przelew_Click);
            // 
            // wyplata
            // 
            this.wyplata.AutoSize = true;
            this.wyplata.BackColor = System.Drawing.Color.Black;
            this.wyplata.Dock = System.Windows.Forms.DockStyle.Top;
            this.wyplata.FlatAppearance.BorderSize = 0;
            this.wyplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wyplata.ForeColor = System.Drawing.Color.White;
            this.wyplata.Location = new System.Drawing.Point(0, 200);
            this.wyplata.Name = "wyplata";
            this.wyplata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wyplata.Size = new System.Drawing.Size(200, 100);
            this.wyplata.TabIndex = 4;
            this.wyplata.Text = "Wypłać";
            this.wyplata.UseVisualStyleBackColor = false;
            this.wyplata.Click += new System.EventHandler(this.wyplata_Click);
            // 
            // wplata
            // 
            this.wplata.AutoSize = true;
            this.wplata.BackColor = System.Drawing.Color.Black;
            this.wplata.Dock = System.Windows.Forms.DockStyle.Top;
            this.wplata.FlatAppearance.BorderSize = 0;
            this.wplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wplata.ForeColor = System.Drawing.Color.White;
            this.wplata.Location = new System.Drawing.Point(0, 100);
            this.wplata.Name = "wplata";
            this.wplata.Size = new System.Drawing.Size(200, 100);
            this.wplata.TabIndex = 3;
            this.wplata.Text = "Wpłać";
            this.wplata.UseVisualStyleBackColor = false;
            this.wplata.Click += new System.EventHandler(this.wplata_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stanKonta);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label stanKonta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stan_konta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button przelew;
        private System.Windows.Forms.Button wyplata;
        private System.Windows.Forms.Button wplata;
    }
}