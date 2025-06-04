namespace CalculatorClientWinForms
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
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.cmbOperatie = new System.Windows.Forms.ComboBox();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.lstIstoric = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(15, 38);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(84, 23);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Numar A:";
            this.lblA.Click += new System.EventHandler(this.lblA_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(133, 31);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 30);
            this.txtA.TabIndex = 1;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(15, 70);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(88, 23);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Numar B: ";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(133, 63);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 30);
            this.txtB.TabIndex = 3;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(15, 105);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(82, 23);
            this.lblOp.TabIndex = 4;
            this.lblOp.Text = "Operatie:";
            // 
            // cmbOperatie
            // 
            this.cmbOperatie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperatie.FormattingEnabled = true;
            this.cmbOperatie.Items.AddRange(new object[] {
            "Adunare",
            "Scădere",
            "Înmulțire",
            "Împărțire",
            "Radical",
            "Putere"});
            this.cmbOperatie.Location = new System.Drawing.Point(123, 104);
            this.cmbOperatie.Name = "cmbOperatie";
            this.cmbOperatie.Size = new System.Drawing.Size(121, 31);
            this.cmbOperatie.TabIndex = 5;
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCalculeaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculeaza.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalculeaza.Location = new System.Drawing.Point(6, 144);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(99, 26);
            this.btnCalculeaza.TabIndex = 6;
            this.btnCalculeaza.Text = "Calculeaza:";
            this.btnCalculeaza.UseVisualStyleBackColor = false;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezultat.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRezultat.Location = new System.Drawing.Point(34, 224);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(96, 28);
            this.lblRezultat.TabIndex = 7;
            this.lblRezultat.Text = "Rezultat:";
            // 
            // lstIstoric
            // 
            this.lstIstoric.FormattingEnabled = true;
            this.lstIstoric.ItemHeight = 16;
            this.lstIstoric.Location = new System.Drawing.Point(26, 255);
            this.lstIstoric.Name = "lstIstoric";
            this.lstIstoric.Size = new System.Drawing.Size(150, 84);
            this.lstIstoric.TabIndex = 8;
            this.lstIstoric.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblA);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.lblB);
            this.groupBox1.Controls.Add(this.btnCalculeaza);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.cmbOperatie);
            this.groupBox1.Controls.Add(this.lblOp);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 201);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operații Matematice";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalveaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalveaza.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalveaza.ForeColor = System.Drawing.Color.Black;
            this.btnSalveaza.Location = new System.Drawing.Point(26, 357);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(124, 35);
            this.btnSalveaza.TabIndex = 10;
            this.btnSalveaza.Text = "Salveaza Istoric";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.LightCoral;
            this.btnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSterge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSterge.ForeColor = System.Drawing.Color.White;
            this.btnSterge.Location = new System.Drawing.Point(26, 407);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(124, 33);
            this.btnSterge.TabIndex = 11;
            this.btnSterge.Text = "🗑️ Șterge Tot";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(802, 464);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstIstoric);
            this.Controls.Add(this.lblRezultat);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Web Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.ComboBox cmbOperatie;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.ListBox lstIstoric;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnSterge;
    }
}

