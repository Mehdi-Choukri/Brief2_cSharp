namespace Brief_cSharp
{
    partial class Formulaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbPays = new System.Windows.Forms.ComboBox();
            this.cmbVille = new System.Windows.Forms.ComboBox();
            this.correct1 = new System.Windows.Forms.Label();
            this.correct2 = new System.Windows.Forms.Label();
            this.correct3 = new System.Windows.Forms.Label();
            this.correct4 = new System.Windows.Forms.Label();
            this.correct5 = new System.Windows.Forms.Label();
            this.correct6 = new System.Windows.Forms.Label();
            this.correct7 = new System.Windows.Forms.Label();
            this.correct8 = new System.Windows.Forms.Label();
            this.cmbSpecialite = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtADR = new System.Windows.Forms.TextBox();
            this.correct9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de naissance";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(214, 49);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(202, 26);
            this.txtnom.TabIndex = 2;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(214, 97);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(202, 26);
            this.txtDate.TabIndex = 3;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pays";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ville";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(588, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 26);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(588, 49);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(202, 26);
            this.txtPrenom.TabIndex = 8;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prenom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Specialité";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Telephone";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(214, 162);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(202, 26);
            this.txtTel.TabIndex = 12;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbPays
            // 
            this.cmbPays.FormattingEnabled = true;
            this.cmbPays.Location = new System.Drawing.Point(214, 218);
            this.cmbPays.Name = "cmbPays";
            this.cmbPays.Size = new System.Drawing.Size(202, 28);
            this.cmbPays.TabIndex = 18;
            this.cmbPays.SelectedIndexChanged += new System.EventHandler(this.cmbPays_SelectedIndexChanged);
            // 
            // cmbVille
            // 
            this.cmbVille.FormattingEnabled = true;
            this.cmbVille.Location = new System.Drawing.Point(588, 215);
            this.cmbVille.Name = "cmbVille";
            this.cmbVille.Size = new System.Drawing.Size(202, 28);
            this.cmbVille.TabIndex = 19;
            this.cmbVille.SelectedIndexChanged += new System.EventHandler(this.cmbVille_SelectedIndexChanged);
            // 
            // correct1
            // 
            this.correct1.AutoSize = true;
            this.correct1.ForeColor = System.Drawing.Color.LimeGreen;
            this.correct1.Location = new System.Drawing.Point(423, 52);
            this.correct1.Name = "correct1";
            this.correct1.Size = new System.Drawing.Size(18, 20);
            this.correct1.TabIndex = 20;
            this.correct1.Text = "✓";
            // 
            // correct2
            // 
            this.correct2.AutoSize = true;
            this.correct2.ForeColor = System.Drawing.Color.LimeGreen;
            this.correct2.Location = new System.Drawing.Point(423, 97);
            this.correct2.Name = "correct2";
            this.correct2.Size = new System.Drawing.Size(18, 20);
            this.correct2.TabIndex = 21;
            this.correct2.Text = "✓";
            // 
            // correct3
            // 
            this.correct3.AutoSize = true;
            this.correct3.ForeColor = System.Drawing.Color.LimeGreen;
            this.correct3.Location = new System.Drawing.Point(423, 162);
            this.correct3.Name = "correct3";
            this.correct3.Size = new System.Drawing.Size(18, 20);
            this.correct3.TabIndex = 22;
            this.correct3.Text = "✓";
            // 
            // correct4
            // 
            this.correct4.AutoSize = true;
            this.correct4.ForeColor = System.Drawing.Color.LimeGreen;
            this.correct4.Location = new System.Drawing.Point(423, 222);
            this.correct4.Name = "correct4";
            this.correct4.Size = new System.Drawing.Size(18, 20);
            this.correct4.TabIndex = 23;
            this.correct4.Text = "✓";
            // 
            // correct5
            // 
            this.correct5.AutoSize = true;
            this.correct5.ForeColor = System.Drawing.Color.LimeGreen;
            this.correct5.Location = new System.Drawing.Point(808, 55);
            this.correct5.Name = "correct5";
            this.correct5.Size = new System.Drawing.Size(18, 20);
            this.correct5.TabIndex = 24;
            this.correct5.Text = "✓";
            // 
            // correct6
            // 
            this.correct6.AutoSize = true;
            this.correct6.ForeColor = System.Drawing.Color.LimeGreen;
            this.correct6.Location = new System.Drawing.Point(808, 103);
            this.correct6.Name = "correct6";
            this.correct6.Size = new System.Drawing.Size(18, 20);
            this.correct6.TabIndex = 25;
            this.correct6.Text = "✓";
            // 
            // correct7
            // 
            this.correct7.AutoSize = true;
            this.correct7.ForeColor = System.Drawing.Color.LimeGreen;
            this.correct7.Location = new System.Drawing.Point(808, 168);
            this.correct7.Name = "correct7";
            this.correct7.Size = new System.Drawing.Size(18, 20);
            this.correct7.TabIndex = 26;
            this.correct7.Text = "✓";
            // 
            // correct8
            // 
            this.correct8.AutoSize = true;
            this.correct8.ForeColor = System.Drawing.Color.LimeGreen;
            this.correct8.Location = new System.Drawing.Point(808, 223);
            this.correct8.Name = "correct8";
            this.correct8.Size = new System.Drawing.Size(18, 20);
            this.correct8.TabIndex = 27;
            this.correct8.Text = "✓";
            // 
            // cmbSpecialite
            // 
            this.cmbSpecialite.FormattingEnabled = true;
            this.cmbSpecialite.Location = new System.Drawing.Point(590, 162);
            this.cmbSpecialite.Name = "cmbSpecialite";
            this.cmbSpecialite.Size = new System.Drawing.Size(202, 28);
            this.cmbSpecialite.TabIndex = 28;
            this.cmbSpecialite.SelectedIndexChanged += new System.EventHandler(this.cmbSpecialite_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(224, 428);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Errors";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(135, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Adresse";
            // 
            // txtADR
            // 
            this.txtADR.Location = new System.Drawing.Point(215, 272);
            this.txtADR.Name = "txtADR";
            this.txtADR.Size = new System.Drawing.Size(372, 26);
            this.txtADR.TabIndex = 33;
            this.txtADR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // correct9
            // 
            this.correct9.AutoSize = true;
            this.correct9.ForeColor = System.Drawing.Color.LimeGreen;
            this.correct9.Location = new System.Drawing.Point(603, 275);
            this.correct9.Name = "correct9";
            this.correct9.Size = new System.Drawing.Size(18, 20);
            this.correct9.TabIndex = 34;
            this.correct9.Text = "✓";
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 574);
            this.Controls.Add(this.correct9);
            this.Controls.Add(this.txtADR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSpecialite);
            this.Controls.Add(this.correct8);
            this.Controls.Add(this.correct7);
            this.Controls.Add(this.correct6);
            this.Controls.Add(this.correct5);
            this.Controls.Add(this.correct4);
            this.Controls.Add(this.correct3);
            this.Controls.Add(this.correct2);
            this.Controls.Add(this.correct1);
            this.Controls.Add(this.cmbVille);
            this.Controls.Add(this.cmbPays);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulaire";
            this.Text = "Formulaire";
            this.Load += new System.EventHandler(this.Formulaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbPays;
        private System.Windows.Forms.ComboBox cmbVille;
        private System.Windows.Forms.Label correct1;
        private System.Windows.Forms.Label correct2;
        private System.Windows.Forms.Label correct3;
        private System.Windows.Forms.Label correct4;
        private System.Windows.Forms.Label correct5;
        private System.Windows.Forms.Label correct6;
        private System.Windows.Forms.Label correct7;
        private System.Windows.Forms.Label correct8;
        private System.Windows.Forms.ComboBox cmbSpecialite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtADR;
        private System.Windows.Forms.Label correct9;
    }
}