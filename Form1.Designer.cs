
namespace wyscigg
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pies1 = new System.Windows.Forms.PictureBox();
            this.trasa = new System.Windows.Forms.PictureBox();
            this.pies2 = new System.Windows.Forms.PictureBox();
            this.pies3 = new System.Windows.Forms.PictureBox();
            this.pies4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jamesButton = new System.Windows.Forms.RadioButton();
            this.martinButton = new System.Windows.Forms.RadioButton();
            this.johnButton = new System.Windows.Forms.RadioButton();
            this.jamesBetLabel = new System.Windows.Forms.Label();
            this.martinBetLabel = new System.Windows.Forms.Label();
            this.johnBetLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pies1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // pies1
            // 
            this.pies1.Image = global::wyscigg.Properties.Resources.piese;
            this.pies1.Location = new System.Drawing.Point(21, 22);
            this.pies1.Name = "pies1";
            this.pies1.Size = new System.Drawing.Size(78, 20);
            this.pies1.TabIndex = 1;
            this.pies1.TabStop = false;
            // 
            // trasa
            // 
            this.trasa.Image = global::wyscigg.Properties.Resources.mapa;
            this.trasa.Location = new System.Drawing.Point(12, 12);
            this.trasa.Name = "trasa";
            this.trasa.Size = new System.Drawing.Size(601, 202);
            this.trasa.TabIndex = 0;
            this.trasa.TabStop = false;
            // 
            // pies2
            // 
            this.pies2.Image = global::wyscigg.Properties.Resources.piese;
            this.pies2.Location = new System.Drawing.Point(21, 71);
            this.pies2.Name = "pies2";
            this.pies2.Size = new System.Drawing.Size(78, 20);
            this.pies2.TabIndex = 2;
            this.pies2.TabStop = false;
            // 
            // pies3
            // 
            this.pies3.Image = global::wyscigg.Properties.Resources.piese;
            this.pies3.Location = new System.Drawing.Point(21, 127);
            this.pies3.Name = "pies3";
            this.pies3.Size = new System.Drawing.Size(78, 20);
            this.pies3.TabIndex = 3;
            this.pies3.TabStop = false;
            // 
            // pies4
            // 
            this.pies4.Image = global::wyscigg.Properties.Resources.piese;
            this.pies4.Location = new System.Drawing.Point(21, 178);
            this.pies4.Name = "pies4";
            this.pies4.Size = new System.Drawing.Size(78, 20);
            this.pies4.TabIndex = 4;
            this.pies4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.johnBetLabel);
            this.groupBox1.Controls.Add(this.martinBetLabel);
            this.groupBox1.Controls.Add(this.jamesBetLabel);
            this.groupBox1.Controls.Add(this.johnButton);
            this.groupBox1.Controls.Add(this.martinButton);
            this.groupBox1.Controls.Add(this.jamesButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dom Bukmacherski";
            // 
            // jamesButton
            // 
            this.jamesButton.AutoSize = true;
            this.jamesButton.Location = new System.Drawing.Point(9, 54);
            this.jamesButton.Name = "jamesButton";
            this.jamesButton.Size = new System.Drawing.Size(83, 17);
            this.jamesButton.TabIndex = 0;
            this.jamesButton.TabStop = true;
            this.jamesButton.Text = "jamesButton";
            this.jamesButton.UseVisualStyleBackColor = true;
            this.jamesButton.CheckedChanged += new System.EventHandler(this.jamesButton_CheckedChanged);
            // 
            // martinButton
            // 
            this.martinButton.AutoSize = true;
            this.martinButton.Location = new System.Drawing.Point(9, 90);
            this.martinButton.Name = "martinButton";
            this.martinButton.Size = new System.Drawing.Size(84, 17);
            this.martinButton.TabIndex = 1;
            this.martinButton.TabStop = true;
            this.martinButton.Text = "martinButton";
            this.martinButton.UseVisualStyleBackColor = true;
            this.martinButton.CheckedChanged += new System.EventHandler(this.martinButton_CheckedChanged);
            // 
            // johnButton
            // 
            this.johnButton.AutoSize = true;
            this.johnButton.Location = new System.Drawing.Point(9, 125);
            this.johnButton.Name = "johnButton";
            this.johnButton.Size = new System.Drawing.Size(76, 17);
            this.johnButton.TabIndex = 2;
            this.johnButton.TabStop = true;
            this.johnButton.Text = "johnButton";
            this.johnButton.UseVisualStyleBackColor = true;
            this.johnButton.CheckedChanged += new System.EventHandler(this.johnButton_CheckedChanged);
            // 
            // jamesBetLabel
            // 
            this.jamesBetLabel.AutoSize = true;
            this.jamesBetLabel.Location = new System.Drawing.Point(181, 56);
            this.jamesBetLabel.Name = "jamesBetLabel";
            this.jamesBetLabel.Size = new System.Drawing.Size(76, 13);
            this.jamesBetLabel.TabIndex = 3;
            this.jamesBetLabel.Text = "jamesBetLabel";
            // 
            // martinBetLabel
            // 
            this.martinBetLabel.AutoSize = true;
            this.martinBetLabel.Location = new System.Drawing.Point(181, 92);
            this.martinBetLabel.Name = "martinBetLabel";
            this.martinBetLabel.Size = new System.Drawing.Size(77, 13);
            this.martinBetLabel.TabIndex = 4;
            this.martinBetLabel.Text = "martinBetLabel";
            // 
            // johnBetLabel
            // 
            this.johnBetLabel.AutoSize = true;
            this.johnBetLabel.Location = new System.Drawing.Point(181, 127);
            this.johnBetLabel.Name = "johnBetLabel";
            this.johnBetLabel.Size = new System.Drawing.Size(69, 13);
            this.johnBetLabel.TabIndex = 5;
            this.johnBetLabel.Text = "johnBetLabel";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(70, 167);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 6;
            this.name.Text = "name";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(127, 162);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 7;
            this.betButton.Text = "stawia";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(218, 162);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "zł na czarta nr";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(452, 162);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "minimumBetLabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ZAKŁADY";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 53);
            this.button2.TabIndex = 14;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pies4);
            this.Controls.Add(this.pies3);
            this.Controls.Add(this.pies2);
            this.Controls.Add(this.pies1);
            this.Controls.Add(this.trasa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pies1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pies4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox trasa;
        private System.Windows.Forms.PictureBox pies1;
        private System.Windows.Forms.PictureBox pies2;
        private System.Windows.Forms.PictureBox pies3;
        private System.Windows.Forms.PictureBox pies4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label johnBetLabel;
        private System.Windows.Forms.Label martinBetLabel;
        private System.Windows.Forms.Label jamesBetLabel;
        private System.Windows.Forms.RadioButton johnButton;
        private System.Windows.Forms.RadioButton martinButton;
        private System.Windows.Forms.RadioButton jamesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

