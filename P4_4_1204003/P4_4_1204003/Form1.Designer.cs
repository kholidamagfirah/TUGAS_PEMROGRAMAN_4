namespace P4_4_1204003
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNPM = new System.Windows.Forms.TextBox();
            this.tbNoHP = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbKapital = new System.Windows.Forms.TextBox();
            this.tbKecil = new System.Windows.Forms.TextBox();
            this.tbTinggi = new System.Windows.Forms.TextBox();
            this.tbBerat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUpload = new System.Windows.Forms.Button();
            this.tbExit = new System.Windows.Forms.Button();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(230, 42);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(112, 22);
            this.tbNama.TabIndex = 0;
            this.tbNama.Leave += new System.EventHandler(this.tbNama_Leave);
            // 
            // tbNPM
            // 
            this.tbNPM.Location = new System.Drawing.Point(230, 95);
            this.tbNPM.Name = "tbNPM";
            this.tbNPM.Size = new System.Drawing.Size(112, 22);
            this.tbNPM.TabIndex = 1;
            this.tbNPM.Leave += new System.EventHandler(this.tbNPM_Leave);
            // 
            // tbNoHP
            // 
            this.tbNoHP.Location = new System.Drawing.Point(230, 147);
            this.tbNoHP.Name = "tbNoHP";
            this.tbNoHP.Size = new System.Drawing.Size(112, 22);
            this.tbNoHP.TabIndex = 2;
            this.tbNoHP.Leave += new System.EventHandler(this.tbNoHP_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(230, 205);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(112, 22);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbKapital
            // 
            this.tbKapital.Location = new System.Drawing.Point(758, 45);
            this.tbKapital.Name = "tbKapital";
            this.tbKapital.Size = new System.Drawing.Size(112, 22);
            this.tbKapital.TabIndex = 4;
            this.tbKapital.Leave += new System.EventHandler(this.tbKapital_Leave);
            // 
            // tbKecil
            // 
            this.tbKecil.Location = new System.Drawing.Point(758, 92);
            this.tbKecil.Name = "tbKecil";
            this.tbKecil.Size = new System.Drawing.Size(112, 22);
            this.tbKecil.TabIndex = 5;
            this.tbKecil.Leave += new System.EventHandler(this.tbKecil_Leave);
            // 
            // tbTinggi
            // 
            this.tbTinggi.Location = new System.Drawing.Point(758, 147);
            this.tbTinggi.Name = "tbTinggi";
            this.tbTinggi.Size = new System.Drawing.Size(112, 22);
            this.tbTinggi.TabIndex = 6;
            this.tbTinggi.TextChanged += new System.EventHandler(this.tbTinggi_TextChanged);
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(758, 205);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(112, 22);
            this.tbBerat.TabIndex = 7;
            this.tbBerat.TextChanged += new System.EventHandler(this.tbBerat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "NAMA\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "NPM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "NO.HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "NAMA (DENGAN HURUF KAPITAL)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "NAMA (DENGAN HURUF KECIL)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "TINGGI BADAN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "BERAT BADAN";
            // 
            // tbUpload
            // 
            this.tbUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpload.Location = new System.Drawing.Point(344, 321);
            this.tbUpload.Name = "tbUpload";
            this.tbUpload.Size = new System.Drawing.Size(84, 23);
            this.tbUpload.TabIndex = 16;
            this.tbUpload.Text = "Upload";
            this.tbUpload.UseVisualStyleBackColor = true;
            this.tbUpload.Click += new System.EventHandler(this.tbUpload_Click);
            // 
            // tbExit
            // 
            this.tbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExit.Location = new System.Drawing.Point(516, 320);
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(84, 23);
            this.tbExit.TabIndex = 17;
            this.tbExit.Text = "E&xit";
            this.tbExit.UseVisualStyleBackColor = true;
            this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1060, 451);
            this.Controls.Add(this.tbExit);
            this.Controls.Add(this.tbUpload);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBerat);
            this.Controls.Add(this.tbTinggi);
            this.Controls.Add(this.tbKecil);
            this.Controls.Add(this.tbKapital);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNoHP);
            this.Controls.Add(this.tbNPM);
            this.Controls.Add(this.tbNama);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "BIODATA DIRI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNPM;
        private System.Windows.Forms.TextBox tbNoHP;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbKapital;
        private System.Windows.Forms.TextBox tbKecil;
        private System.Windows.Forms.TextBox tbTinggi;
        private System.Windows.Forms.TextBox tbBerat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button tbUpload;
        private System.Windows.Forms.Button tbExit;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

